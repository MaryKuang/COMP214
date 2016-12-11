using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using Oracle.ManagedDataAccess.Client;
using System.Configuration;
using System.Data;
using System.Collections.Specialized;

//System.Web.UI.Page
public partial class Addrecipe : ThemePage
{
    private Recipe recipe;
    private List<Recipe> recipes;
    string key;


    /* string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
       OracleConnection conn = new OracleConnection();  */

    protected void Page_Load(object sender, EventArgs e)
    {

        /*    recipe = new Recipe();

            if (null != Session["ingredients"])
            {
                recipe.Ingredients = (List<Ingredients>)Session["ingredients"];
            }
            else
            {
                recipe.Ingredients = new List<Ingredients>();
            }
            recipes = (List<Recipe>)Application["Recipes"];  */



    } 

    protected void btnSummit_Click(object sender, EventArgs e)
    {
        /*  ((List<Recipe>)Application["Recipe"]).Add(new Recipe
          {
              RecipeName = tbxRecipeName.Text,
              AuthorName = tbxSubmit.Text,
              Category = Convert.ToString(dpdownList.SelectedItem),
              CookingTime = tbxPrepare.Text,
              ServingNumber = tbxServings.Text,
              Description = tbxDescription.Text
          });   */


        string _connstring = "Data Source=oracle1.centennialcollege.ca:1521/SQLD;User ID=COMP214F16_001_P_17;Password=password";
       
        DataSet ds;

        try
        {
            OracleConnection conn = new OracleConnection(_connstring);
            //      conn.ConnectionString = connectionString;
            conn.Open();
            OracleCommand comm = conn.CreateCommand();
            comm.CommandText = "Recipe_insert";
            comm.CommandType = CommandType.StoredProcedure;

            OracleParameter _InParam1 = new OracleParameter();
            _InParam1.ParameterName = "recipename";
            _InParam1.OracleDbType = OracleDbType.Varchar2;
            _InParam1.Direction = ParameterDirection.Input;
            _InParam1.Value = tbxRecipeName.Text;
            comm.Parameters.Add(_InParam1);

            OracleParameter _InParam2 = new OracleParameter();
            _InParam2.ParameterName = "cookingtime";
            _InParam2.OracleDbType = OracleDbType.Varchar2;
            _InParam2.Direction = ParameterDirection.Input;
            _InParam2.Value = tbxPrepare.Text;
            comm.Parameters.Add(_InParam2);

            OracleParameter _InParam3 = new OracleParameter();
            _InParam3.ParameterName = "SERVINGNUMBER";
            _InParam3.OracleDbType = OracleDbType.Varchar2;
            _InParam3.Direction = ParameterDirection.Input;
            _InParam3.Value = tbxServings.Text;
            comm.Parameters.Add(_InParam3);

            OracleParameter _InParam4 = new OracleParameter();
            _InParam4.ParameterName = "DES1";
            _InParam4.OracleDbType = OracleDbType.Varchar2;
            _InParam4.Direction = ParameterDirection.Input;
            _InParam4.Value = tbxDescription.Text;
            comm.Parameters.Add(_InParam4);

            OracleParameter _InParam5 = new OracleParameter();
            _InParam5.ParameterName = "RECID";
            _InParam5.OracleDbType = OracleDbType.Decimal;                ;
            _InParam5.Direction = ParameterDirection.Output;
 //           _InParam4.Value = tbxDescription.Text;
            comm.Parameters.Add(_InParam5);

            comm.ExecuteNonQuery();
           key =Convert.ToString(_InParam5.Value);
          
//            comm.Connection.Open();
//            comm.ExecuteNonQuery();

 //           OracleDataAdapter myDB = new OracleDataAdapter(comm);
 //           myDB.SelectCommand = comm;
//            ds = new DataSet();
 //           myDB.Fill(ds);
             comm.Connection.Close();
            comm.Connection.Dispose();
            comm = null;
        }
            catch (Exception ex)
        {
            Console.WriteLine("SQL error" + ex.Message);
            throw new Exception("Err in running" + ex.Message);
        }
        finally
        {
  //          comm.Connection.Close();
        }

        tbxRecipeName.Text = "";
        tbxSubmit.Text = "";
        tbxPrepare.Text = "";
        tbxServings.Text = "";
        tbxDescription.Text = "";
    

        Response.Redirect("Recipes.aspx");
    }




    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Session["Ingredients"] = null;
        Response.Redirect("Home.aspx");
    }

    protected void AddIngredients_Click(object sender, EventArgs e)
    {
       // Response.Redirect("AddIngredients.aspx?Key=" + key);

        string _connstring = "Data Source=oracle1.centennialcollege.ca:1521/SQLD;User ID=COMP214F16_001_P_17;Password=password";
        DataSet ds;

        try
        {
            OracleConnection conn = new OracleConnection(_connstring);
            //      conn.ConnectionString = connectionString;
            conn.Open();
            OracleCommand comm = conn.CreateCommand();
            comm.CommandText = "Recipe_insert";
            comm.CommandType = CommandType.StoredProcedure;

            OracleParameter _InParam1 = new OracleParameter();
            _InParam1.ParameterName = "recipename";
            _InParam1.OracleDbType = OracleDbType.Varchar2;
            _InParam1.Direction = ParameterDirection.Input;
            _InParam1.Value = tbxRecipeName.Text;
            comm.Parameters.Add(_InParam1);

            OracleParameter _InParam2 = new OracleParameter();
            _InParam2.ParameterName = "cookingtime";
            _InParam2.OracleDbType = OracleDbType.Varchar2;
            _InParam2.Direction = ParameterDirection.Input;
            _InParam2.Value = tbxPrepare.Text;
            comm.Parameters.Add(_InParam2);

            OracleParameter _InParam3 = new OracleParameter();
            _InParam3.ParameterName = "SERVINGNUMBER";
            _InParam3.OracleDbType = OracleDbType.Varchar2;
            _InParam3.Direction = ParameterDirection.Input;
            _InParam3.Value = tbxServings.Text;
            comm.Parameters.Add(_InParam3);

            OracleParameter _InParam4 = new OracleParameter();
            _InParam4.ParameterName = "DES1";
            _InParam4.OracleDbType = OracleDbType.Varchar2;
            _InParam4.Direction = ParameterDirection.Input;
            _InParam4.Value = tbxDescription.Text;
            comm.Parameters.Add(_InParam4);

            OracleParameter _InParam5 = new OracleParameter();
            _InParam5.ParameterName = "RECID";
            _InParam5.OracleDbType = OracleDbType.Decimal;
            _InParam5.Direction = ParameterDirection.Output;
            //           _InParam4.Value = tbxDescription.Text;
            comm.Parameters.Add(_InParam5);

            comm.ExecuteNonQuery();
            key = Convert.ToString(_InParam5.Value);
      
            comm.Connection.Close();
            comm.Connection.Dispose();
            comm = null;
        }
        catch (Exception ex)
        {
            Console.WriteLine("SQL error" + ex.Message);
            throw new Exception("Err in running" + ex.Message);
        }
        finally
        {
            //          comm.Connection.Close();
        }

        tbxRecipeName.Text = "";
        tbxSubmit.Text = "";
        tbxPrepare.Text = "";
        tbxServings.Text = "";
        tbxDescription.Text = "";

    //    Response.Redirect("AddIngredients.aspx");
        Response.Redirect("AddIngredients.aspx?key="+ key);
       
    }

  
}
