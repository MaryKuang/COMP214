using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Oracle.ManagedDataAccess.Client;
using System.Configuration;
using System.Data;


public partial class Categories : System.Web.UI.UserControl
{
    string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
    OracleConnection conn = new OracleConnection();

    protected void Page_Load(object sender, EventArgs e)
    {

        if (!Page.IsPostBack)
        {

            BindCategories();

        }
    }

    private void BindCategories()
    {

        conn.ConnectionString = connectionString;
        OracleCommand comm = conn.CreateCommand();
        comm.CommandType = CommandType.Text;
        comm.CommandText = "select categoryID, categoryname from categories";
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

        drpListCategories.DataSource = ds;
        drpListCategories.DataValueField = "categoryID";
        drpListCategories.DataTextField = "categoryname";
        drpListCategories.DataBind();
        int counter = drpListCategories.Items.Count;
        drpListCategories.Items.Insert(counter, new ListItem("Other", "-1"));
        txtCategory.Visible = false;
        lblInput.Visible = false;
        btnCategoryAdd.Visible = false;
        btnCategoryAdd.Enabled = false;

    }


    protected void drpListCategories_SelectedIndexChanged(object sender, EventArgs e)
    {


        if (drpListCategories.SelectedItem.Value == "-1")
        {
            txtCategory.Visible = true;
            lblInput.Visible = true;
            btnCategoryAdd.Enabled = true;
            btnCategoryAdd.Visible = true;
        }
        else
        {
            lblInput.Visible = false;
            txtCategory.Visible = false;
            btnCategoryAdd.Enabled = false;
            btnCategoryAdd.Visible = false;
        }


    }

    protected void btnCategoryAdd_Click(object sender, EventArgs e)
    {
        conn.ConnectionString = connectionString;
        OracleCommand comm = conn.CreateCommand();
        comm.CommandText = "Insert into categories values(CATEGORIES_ID_SEQ.nextval,:categoryName)";
        comm.CommandType = CommandType.Text;
        comm.Parameters.Add(":categoryName", OracleDbType.Varchar2, ParameterDirection.Input);
        comm.Parameters[":categoryName"].Value = txtCategory.Text;

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

        Response.Redirect("Addrecipe.aspx");
        //drpListCategories.DataSource = ds;
        //drpListCategories.DataBind();
    }
}
