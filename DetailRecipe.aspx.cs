using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Oracle.ManagedDataAccess.Client;
using System.Configuration;
using System.Data;

public partial class DetailRecipe : ThemePage
{
    string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
    OracleConnection conn = new OracleConnection();

    string _connstring = "Data Source=oracle1.centennialcollege.ca:1521/SQLD;User ID=COMP214F16_001_P_17;Password=password";

   

    protected void Page_Load(object sender, EventArgs e)
    {
      if(!Page.IsPostBack) { 
       // conn.ConnectionString = connectionString;
      //  OracleCommand comm = conn.CreateCommand();
      //             comm.CommandType = CommandType.Text;
      //             comm.CommandText = "select recipeid,recipename,userid,categoryid,cookingtime,servingtime,description from recipes where recipeid=" + Request.QueryString["param"];
            string _sql;
            DataSet ds;
               int _recordsAffected;
            OracleDataReader _rdrObj;
            string txtName;
            int numRECIPEID;
            string txtRemarks;
            DataTable table;
            table = new DataTable();
            try
        {

 
                OracleConnection conn = new OracleConnection(_connstring);
                conn.Open();
                DataSet _ds = new DataSet();
                OracleCommand comm = conn.CreateCommand();
                comm.CommandType = CommandType.Text;
                comm.CommandText = "select recipeid,recipename,userid,categoryid,cookingtime,servingtime,description from recipes_VIEW where recipeid=" + Request.QueryString["param"];

         
                OracleDataAdapter myDB = new OracleDataAdapter(comm);
  
               ds = new DataSet();
              myDB.Fill(ds);
                conn.Close();
                conn.Dispose();
                conn = null;
            }
            catch (Exception ex)
            {
                Console.WriteLine("SQL error" + ex.Message);
                throw new Exception("Err in running" + ex.Message);
            }
          finally
        {
            //comm.Connection.Close();
        }
            DetailsView1.DataSource = ds;
     DetailsView1.DataBind();
              //    conn.Close();
             //   conn.Dispose();
              //  conn = null;
        }
      //  BindView();

    }
//    protected void btnDetailIngredients_Click(object sender, EventArgs e)
//    {
//        /*  ((List<Recipe>)Application["Recipe"]).Add(new Recipe
//          {
//              RecipeName = tbxRecipeName.Text,
//              AuthorName = tbxSubmit.Text,
//              Category = Convert.ToString(dpdownList.SelectedItem),
//              CookingTime = tbxPrepare.Text,
//              ServingNumber = tbxServings.Text,
//              Description = tbxDescription.Text
//          });   */


    protected void btnDetailIngredients_Click(object sender, EventArgs e)
    {
        string _connstring = "Data Source=oracle1.centennialcollege.ca:1521/SQLD;User ID=COMP214F16_001_P_17;Password=password";
        //        conn.ConnectionString = connectionString;
        OracleConnection conn = new OracleConnection(_connstring);
        OracleCommand comm = conn.CreateCommand();
        comm.CommandType = CommandType.Text;
        comm.CommandText = "select recipeid,ingredientid,quantity,unit from recipeandingredient where recipeid=" + Request.QueryString["param"];
        DataSet ds;
      //  string _sql;
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
        GridView1.DataSource = ds;
        GridView1.DataBind();



    }  
 
    protected void btnDelete_Click(object sender, EventArgs e)
    {
        string _connstring = "Data Source=oracle1.centennialcollege.ca:1521/SQLD;User ID=COMP214F16_001_P_17;Password=password";
        //        conn.ConnectionString = connectionString;
        OracleConnection conn = new OracleConnection(_connstring);
//        conn.ConnectionString = connectionString;
        OracleCommand comm = conn.CreateCommand();
        comm.CommandType = CommandType.Text;
      comm.CommandText = "delete from recipes where recipeid=" + Request.QueryString["param"];
        string _sql;
        DataSet ds;
        try
        {
         //   _sql = "delete from recipes where recipeid = :ID ";
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
        //     DetailsView1.DataSource = ds;
        //    DetailsView1.DataBind();  
        Response.Redirect("~/Recipes.aspx");
    }



    protected void btnDetailCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Recipes.aspx");
    }


    protected void DetailsView1_ModeChanging(object sender, DetailsViewModeEventArgs e)
    {
        DetailsView1.ChangeMode(e.NewMode);

        string _sql;
        DataSet ds;
        int _recordsAffected;
        OracleDataReader _rdrObj;
        string txtName;
        int numRECIPEID;
        string txtRemarks;
        DataTable table;
        table = new DataTable();
        try
        {

            OracleConnection conn = new OracleConnection(_connstring);
        conn.Open();
        DataSet _ds = new DataSet();
        OracleCommand comm = conn.CreateCommand();
        comm.CommandType = CommandType.Text;
        comm.CommandText = "select recipeid,recipename,userid,categoryid,cookingtime,servingtime,description from recipes where recipeid=" + Request.QueryString["param"];

      
        OracleDataAdapter myDB = new OracleDataAdapter(comm);
  
        ds = new DataSet();
        myDB.Fill(ds);
        conn.Close();
        conn.Dispose();
        conn = null;
    }
            catch (Exception ex)
            {
                Console.WriteLine("SQL error" + ex.Message);
                throw new Exception("Err in running" + ex.Message);
}
          finally
        {
            //comm.Connection.Close();
        }
            DetailsView1.DataSource = ds;
     DetailsView1.DataBind();
          

    }


    protected void DetailsView1_ItemUpdating(object sender, DetailsViewUpdateEventArgs e)
    {
        TextBox newRecipeName = (TextBox)DetailsView1.FindControl("txtRecipeName");
        TextBox newCategoryID = (TextBox)DetailsView1.FindControl("txtCategoryID");
        TextBox newCookingtime = (TextBox)DetailsView1.FindControl("txtCookingtime");
        TextBox newServingtime = (TextBox)DetailsView1.FindControl("txtServingtime");
        TextBox newDescription = (TextBox)DetailsView1.FindControl("txtDescription");
 //       string userID = DetailsView1.FindControl(lblUserID.Text);

        string newName = newRecipeName.Text;
        string newCategory = newCategoryID.Text;
        string newTime = newCookingtime.Text;
        string newServing =newServingtime.Text;
        string newDes = newDescription.Text;
        try
        {
            OracleConnection conn = new OracleConnection(_connstring);
            conn.Open();
            OracleCommand comm = conn.CreateCommand();
            comm.CommandText = "Recipe_update2";
            comm.CommandType = CommandType.StoredProcedure;

            OracleParameter _InParam1 = new OracleParameter();
            _InParam1.ParameterName = "recipename1";
            _InParam1.OracleDbType = OracleDbType.Varchar2;
            _InParam1.Direction = ParameterDirection.Input;
            //            _InParam1.Value = tbxRecipeName.Text;
            //    _InParam1.Value = (TextBox)DetailsViewDetail.FindControl("editRecipename");
            _InParam1.Value = newName;
            comm.Parameters.Add(_InParam1);

            OracleParameter _InParam2 = new OracleParameter();
            _InParam2.ParameterName = "cookingtime1";
            _InParam2.OracleDbType = OracleDbType.Varchar2;
            _InParam2.Direction = ParameterDirection.Input;
               _InParam2.Value = newTime;
            comm.Parameters.Add(_InParam2);

            OracleParameter _InParam3 = new OracleParameter();
            _InParam3.ParameterName = "SERVINGNUMBER1";
            _InParam3.OracleDbType = OracleDbType.Varchar2;
            _InParam3.Direction = ParameterDirection.Input;
               _InParam3.Value = newServing;
            comm.Parameters.Add(_InParam3);

            OracleParameter _InParam4 = new OracleParameter();
            _InParam4.ParameterName = "DES1";
            _InParam4.OracleDbType = OracleDbType.Varchar2;
            _InParam4.Direction = ParameterDirection.Input;
                  _InParam4.Value = newDes;
            comm.Parameters.Add(_InParam4);


            OracleParameter _InParam5 = new OracleParameter();
            _InParam5.ParameterName = "CATE";
            _InParam5.OracleDbType = OracleDbType.Varchar2;
            _InParam5.Direction = ParameterDirection.Input;
            _InParam5.Value = newCategory;
            comm.Parameters.Add(_InParam5);

            OracleParameter _InParam6 = new OracleParameter();
            _InParam6.ParameterName = "ID1";
            _InParam6.OracleDbType = OracleDbType.Varchar2;
            _InParam6.Direction = ParameterDirection.Input;
            _InParam6.Value = Request.QueryString["param"];
            comm.Parameters.Add(_InParam6);


            comm.ExecuteNonQuery();

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
            //          conn.Connection.Close();
        }

        Response.Redirect("~/Recipes.aspx");


    }

    protected void GridView1_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
    {

    }

    //protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    //{
    //    GridView1.EditIndex = e.NewEditIndex;
    //    BindView();
    //}

    protected void BindView()
    { 
        conn.ConnectionString = connectionString;
    OracleCommand comm = conn.CreateCommand();
    comm.CommandType = CommandType.Text;
        comm.CommandText = "select * from recipeandingredient where recipeid="+ Request.QueryString["param"];
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
        GridView1.DataSource = ds;
        GridView1.DataBind();

    }


    protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        GridViewRow row = GridView1.Rows[e.RowIndex];
         Label Id = (Label)row.FindControl("ingredientID");
      //  TextBox updateIngreID = (TextBox)row.FindControl("ingredientID");
        TextBox updateQuan = (TextBox)row.FindControl("Quantity");
        TextBox UpdateUnit = (TextBox)row.FindControl("Unit");
        int ingerID = Convert.ToInt32(Id.Text);
        string quan = updateQuan.Text;
        string measure = UpdateUnit.Text;

        try
        {
            OracleConnection conn = new OracleConnection(_connstring);
            conn.Open();
            OracleCommand comm = conn.CreateCommand();
            comm.CommandText = "bridge_update2";
            comm.CommandType = CommandType.StoredProcedure;

            OracleParameter _InParam1 = new OracleParameter();
            _InParam1.ParameterName = "ingredientID1";
            _InParam1.OracleDbType = OracleDbType.Varchar2;
            _InParam1.Direction = ParameterDirection.Input;
            //            _InParam1.Value = tbxRecipeName.Text;
            //    _InParam1.Value = (TextBox)DetailsViewDetail.FindControl("editRecipename");
            _InParam1.Value = ingerID;
            comm.Parameters.Add(_InParam1);

            OracleParameter _InParam2 = new OracleParameter();
            _InParam2.ParameterName = "Quantity1";
            _InParam2.OracleDbType = OracleDbType.Varchar2;
            _InParam2.Direction = ParameterDirection.Input;
            _InParam2.Value = quan;
            comm.Parameters.Add(_InParam2);

            OracleParameter _InParam3 = new OracleParameter();
            _InParam3.ParameterName = "Unit1";
            _InParam3.OracleDbType = OracleDbType.Varchar2;
            _InParam3.Direction = ParameterDirection.Input;
            _InParam3.Value = measure;
            comm.Parameters.Add(_InParam3);


            OracleParameter _InParam4 = new OracleParameter();
            _InParam4.ParameterName = "recipeID1";
            _InParam4.OracleDbType = OracleDbType.Varchar2;
            _InParam4.Direction = ParameterDirection.Input;
            _InParam4.Value = Request.QueryString["param"];
            comm.Parameters.Add(_InParam4);

            comm.ExecuteNonQuery();

            comm.Connection.Close();
            comm.Connection.Dispose();
            comm = null;
        }


        catch
        {
            throw;
          }

        finally
        {
           
        }
      
       
    }

    protected void GridView1_RowEditing1(object sender, GridViewEditEventArgs e)
    {

        GridView1.EditIndex = e.NewEditIndex;
        BindView();

    }

    protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
         
        GridView1.EditIndex = -1;
        BindView();
   
}

    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        GridViewRow row = GridView1.Rows[e.RowIndex];
        Label Id = (Label)row.FindControl("ingredientID");

        conn.ConnectionString = connectionString;
        OracleCommand comm = conn.CreateCommand();
        comm.CommandText = "delete from recipeandingredient where ingredientID="+Id;
        comm.CommandType = CommandType.Text;
        DataSet ds;

        try
        {
            comm.Connection.Open();
           comm.ExecuteNonQuery();

        //    OracleDataAdapter myDB = new OracleDataAdapter(comm);
         //   myDB.SelectCommand = comm;
         //   ds = new DataSet();
          //  myDB.Fill(ds);
        }
        catch
        {

            throw;
        }
        finally
        {
            comm.Connection.Close();
        }


      //  GridView1.DataSource = ds;
        GridView1.DataBind();


    }
}