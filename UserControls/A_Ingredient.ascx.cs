using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Oracle.ManagedDataAccess.Client;
using System.Configuration;
using System.Data;


public partial class UserControls_A_Ingredient : System.Web.UI.UserControl
{


    public string ingredientValue
    {
        get
        {
            return drpIngredient.SelectedValue;
        }
        //set
        //{
        //    drpIngredient.SelectedValue = value;
        //}
    }



    string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
    OracleConnection conn = new OracleConnection();

    protected void Page_Load(object sender, EventArgs e)
    {
       

        if (!Page.IsPostBack)
        {

            BindIngredients();

        }
    }

    private void BindIngredients()
    {

        conn.ConnectionString = connectionString;
        OracleCommand comm = conn.CreateCommand();
        comm.CommandType = CommandType.Text;
        comm.CommandText = "select ingredientID, ingredientname from ingredients_new";
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

        drpIngredient.DataSource = ds;
        drpIngredient.DataValueField = "IngredientID";
        drpIngredient.DataTextField = "ingredientname";
        drpIngredient.DataBind();
        int counter = drpIngredient.Items.Count;
        drpIngredient.Items.Insert(counter, new ListItem("Other", "-1"));
       
         txtIngredient.Visible = false;
         lblInputIngre.Visible = false;
        btnIngredientAdd.Enabled = false;
        btnIngredientAdd.Visible = false;

    }

    protected void drpIngredient_SelectedIndexChanged(object sender, EventArgs e)
    {
       
        if (drpIngredient.SelectedItem.Value == "-1")
        {
            txtIngredient.Visible = true;
            lblInputIngre.Visible = true;
            btnIngredientAdd.Enabled = true;
            btnIngredientAdd.Visible = true;

        }
        else
        {
            lblInputIngre.Visible = false;
            txtIngredient.Visible = false;
            btnIngredientAdd.Enabled = false;
            btnIngredientAdd.Visible = false;
        }


    }

    protected void btnIngredientAdd_Click(object sender, EventArgs e)
    {
        conn.ConnectionString = connectionString;
        OracleCommand comm = conn.CreateCommand();
        comm.CommandText = "Insert into ingredients_new values(INGREDIENTS_ID_SEQ.nextval,:IngredientName)";
        comm.CommandType = CommandType.Text;
        comm.Parameters.Add(":IngredientName", OracleDbType.Varchar2, ParameterDirection.Input);
        comm.Parameters[":IngredientName"].Value = txtIngredient.Text;

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

        Response.Redirect("AddIngredients.aspx");

    }
}