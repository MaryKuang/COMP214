using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Oracle.ManagedDataAccess.Client;
using System.Configuration;
using System.Data;

public partial class AddIngredients : System.Web.UI.Page
{
    string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
    OracleConnection conn = new OracleConnection();
 //   string key;
   

    protected void Page_Load(object sender, EventArgs e)
    {
       if(!Page.IsPostBack) { 
        string aIngredientValue = A_Ingredient.ingredientValue;
      //  key=Request.QueryString["key"];
        }

    }

    protected void btnReturn_Click(object sender, EventArgs e)
    {
        Response.Redirect("Recipes.aspx");
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        
            GridView1.Visible = true;
        string aIngredientValue = A_Ingredient.ingredientValue;
        conn.ConnectionString = connectionString;
        OracleCommand comm = conn.CreateCommand();
        comm.CommandText = "Insert into recipeandIngredient values(bridgeid.nextval,:recipeID,:ingredient,:quantity,:unite)";
        comm.CommandType = CommandType.Text;
        comm.Parameters.Add(":recipeID", OracleDbType.Varchar2, ParameterDirection.Input);
        comm.Parameters[":recipeid"].Value = Request.QueryString["key"];
        comm.Parameters.Add(":ingredient", OracleDbType.Varchar2, ParameterDirection.Input);
        comm.Parameters[":ingredient"].Value = aIngredientValue;
        comm.Parameters.Add(":quantity", OracleDbType.Varchar2, ParameterDirection.Input);
        comm.Parameters[":quantity"].Value = txtQuantity.Text;
        comm.Parameters.Add(":unit", OracleDbType.Varchar2, ParameterDirection.Input);
        comm.Parameters[":unit"].Value = txtUnit.Text;


        DataSet ds;

        try
        {
            comm.Connection.Open();
            //      comm.ExecuteNonQuery();

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

       // GridView1.DataSource = ds;
        GridView1.DataBind();

        txtQuantity.Text = "";
        txtUnit.Text = "";



    }

    //protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    //{
    //    GridView1.EditIndex = e.NewEditIndex;

    //  //  BindList();
    //}

   // protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
   // {
   //     GridViewRow row = GridView1.Rows[e.RowIndex];
   //     Label ID = (Label)row.FindControl("ingredientid");
   ////     TextBox updateIngre = (TextBox)row.FindControl("ingredientid");
   //     TextBox updateQuan = (TextBox)row.FindControl("Quantity");
   //     TextBox updateUnit = (TextBox)row.FindControl("Unit");
   //     int ingeridentID = int.Parse(ID.Text);
   //     string quantity = updateQuan.Text;
   //     string measure = updateUnit.Text;

   //     string connectionString =
   //          ConfigurationManager.ConnectionStrings["ConnectionString2"].ConnectionString;
   //     OracleConnection conn = new OracleConnection();
   //     conn.ConnectionString = connectionString;
   //     OracleCommand comm = conn.CreateCommand();
   //     try
   //     {
   //         comm.Connection.Open();
   //         comm.CommandType = CommandType.Text;

   //         comm.CommandType = CommandType.Text;
   //         comm.CommandText = "update ingredients set name ='quantity=" + quantity + ", unitofmeasure= '" + measure + "' where ingredientid = " + ingeridentID;
   //         comm.ExecuteNonQuery();
   //         GridView1.EditIndex = -1;
   //     }

   //     catch ()
   //     {
           
   //     }

   //     finally
   //     {
   //         comm.Connection.Close();
   //     }
   //     BindList();
   // }

   // protected void BindList()
   // {

   // }

}