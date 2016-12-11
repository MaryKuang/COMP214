using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Oracle.ManagedDataAccess.Client;
using System.Configuration;
using System.Data;


//System.Web.UI.Page
public partial class Search : ThemePage
{
    string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
    OracleConnection conn = new OracleConnection();
    
    protected void Page_Load(object sender, EventArgs e)
    {
       if(!Page.IsPostBack)
        { 
        FilldrpSubmitBy();  //dropbox show anthorname 
        FilldrpCategory();   // show category column
        FillIngredientList();  //show ingredient column
        }
    }
    private void FilldrpSubmitBy()
    {
       
          conn.ConnectionString = connectionString;
          OracleCommand comm = conn.CreateCommand();
          comm.CommandType = CommandType.Text;
         comm.CommandText = "select * from recipe";
        DataSet ds;

        try {
            comm.Connection.Open();
            OracleDataAdapter myDB = new OracleDataAdapter(comm);
            ds = new DataSet();
            myDB.Fill(ds);
        }
        catch 
        {
            throw;
        }
        finally {
            comm.Connection.Close();
        }
       
             drpSubmitBy.DataSource =ds;
                drpSubmitBy.DataValueField = "AUTHORNAME";
                drpSubmitBy.DataTextField = "AUTHORNAME";
                drpSubmitBy.DataBind();
               drpSubmitBy.Items.Insert(0, new ListItem("ALL", "%")); //% means All

    }

    private void FilldrpCategory()
    {
   
        conn.ConnectionString = connectionString;
        OracleCommand comm = conn.CreateCommand();
        comm.CommandType = CommandType.Text;
        comm.CommandText = "select * from recipe";
        DataSet ds;
        try
        {
            comm.Connection.Open();
            OracleDataAdapter myDB1 = new OracleDataAdapter(comm);
            ds = new DataSet();
            myDB1.Fill(ds);
        }
        catch 
        {
           
            throw;
        }
        finally
        {
            comm.Connection.Close();
        }
       

        drpCategory.DataSource = ds;
        drpCategory.DataValueField = "CATEGORY";
        drpCategory.DataTextField = "CATEGORY";
        drpCategory.DataBind();
        drpCategory.Items.Insert(0, new ListItem("ALL", "%"));


    }

    private void FillIngredientList()
    {
      
        conn.ConnectionString = connectionString;
        OracleCommand comm = conn.CreateCommand();
        comm.CommandType = CommandType.Text;
        comm.CommandText = "select * from ingredients";
        DataSet ds;
        try
        {
            comm.Connection.Open();
            OracleDataAdapter myDB = new OracleDataAdapter(comm);
            ds = new DataSet();
            myDB.Fill(ds);
        }
        catch 
        {
           
            throw;
        }
        finally
        {
            comm.Connection.Close();
        }
      
        drpIngredientList.DataSource = ds;
        drpIngredientList.DataValueField = "INGREDIENTID";
        drpIngredientList.DataTextField = "INGREDIENTNAME";
        drpIngredientList.DataBind();
        drpIngredientList.Items.Insert(0, new ListItem("ALL", "%"));

    }
    
 
   
    private void BindList()
    {
        if (((string)(drpIngredientList.SelectedItem.Value)).Equals("%"))
        {
            conn.ConnectionString = connectionString;
            OracleCommand comm = conn.CreateCommand();
            comm.CommandText = "Select * from recipe where authorname like :authorname and category like :category";
            comm.CommandType = CommandType.Text;
            comm.Parameters.Add(":authorname", OracleDbType.Varchar2, ParameterDirection.Input);
            comm.Parameters[":authorname"].Value = drpSubmitBy.SelectedItem.Value;
            comm.Parameters.Add(":category", OracleDbType.Varchar2, ParameterDirection.Input);
            comm.Parameters[":category"].Value = drpCategory.SelectedItem.Value;

            DataSet ds;

            try
            {
                comm.Connection.Open();
                comm.ExecuteNonQuery();

                OracleDataAdapter myDB = new OracleDataAdapter(comm);
                myDB.SelectCommand = comm;
                ds = new DataSet();
                myDB.Fill(ds);
            }
            catch
            {

                throw;
            }
            finally
            {
                comm.Connection.Close();
            }


            GridView1.DataSource = ds;
            GridView1.DataBind();

        }
        else
        {
           conn.ConnectionString = connectionString;
           OracleCommand comm = conn.CreateCommand();
           comm.CommandText = "Select r.recipename,r.authorname,r.description,i.ingredientname from recipe r join ingredients i using(recipeid) where authorname like :authorname and category like :category and ingredientname like : ingredientname ";
           comm.CommandType = CommandType.Text;
           comm.Parameters.Add(":authorname",OracleDbType.Varchar2,ParameterDirection.Input);
           comm.Parameters[":authorname"].Value = drpSubmitBy.SelectedItem.Value;
           comm.Parameters.Add(":category", OracleDbType.Varchar2, ParameterDirection.Input);
           comm.Parameters[":category"].Value = drpCategory.SelectedItem.Value;
          comm.Parameters.Add(":ingredientname", OracleDbType.Varchar2, ParameterDirection.Input);
          comm.Parameters[":ingredientname"].Value = drpIngredientList.SelectedItem.Value;

        DataSet ds;

            try
            {
               comm.Connection.Open();
               comm.ExecuteNonQuery();

               OracleDataAdapter myDB = new OracleDataAdapter(comm);
               myDB.SelectCommand = comm;
               ds = new DataSet();
               myDB.Fill(ds);
           }
           catch 
           {

               throw;
           }
           finally
           {
               comm.Connection.Close();
           }

       
        GridView1.DataSource = ds;
        GridView1.DataBind();
        }

    }

   
    protected void btnSearch_Click(object sender, EventArgs e)
    {


        BindList();


    }


}