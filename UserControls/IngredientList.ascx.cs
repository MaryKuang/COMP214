using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Oracle.ManagedDataAccess.Client;
using System.Configuration;
using System.Data;

public partial class UserControls_IngredientList : System.Web.UI.UserControl
{
    string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
    OracleConnection conn = new OracleConnection();

    protected void Page_Load(object sender, EventArgs e)
    {

        string aIngredientValue = A_Ingredient.ingredientValue;

        if (!Page.IsPostBack)
        {


         //  GridView1.Visible = false;

        }
    }



    protected void Button1_Click(object sender, EventArgs e)
    {
        // tbxRecipeName;

        GridView1.Visible = true;
        string aIngredientValue = A_Ingredient.ingredientValue;
        conn.ConnectionString = connectionString;
        OracleCommand comm = conn.CreateCommand();
        comm.CommandText = "Insert into recipeandIngredient values(bridgeid.nextval,:recipeID,:ingredient,:quantity,:unite)";
        comm.CommandType = CommandType.Text;
        comm.Parameters.Add(":recipeID", OracleDbType.Varchar2, ParameterDirection.Input);
      //  comm.Parameters[":recipeid"].Value = :keyid2;
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

      //  GridView1.Visible = true;
       // Response.Redirect("Addrecipe.aspx");
    }

    protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        //connect to database to update the data

    }

}