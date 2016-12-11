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
  //  string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
  //  OracleConnection conn = new OracleConnection();
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

 //          _sql = " select * from recipes where recipeid = :IDVALUE ";
 //               _sql = " select * from recipes where  to_number(:IDVALUE) = recipeid ";
 //                     _sql = " select * from recipes ";

                //               OracleConnection conn = new OracleConnection();
                OracleConnection conn = new OracleConnection(_connstring);
                conn.Open();
                DataSet _ds = new DataSet();
                OracleCommand comm = conn.CreateCommand();
                comm.CommandType = CommandType.Text;
                comm.CommandText = "select recipeid,recipename,userid,categoryid,cookingtime,servingtime,description from recipes_VIEW where recipeid=" + Request.QueryString["param"];

                //             comm.CommandType = CommandType.Text;
                //             comm.BindByName = true;
                //           OracleDataAdapter myDB = new OracleDataAdapter(_sql, conn);

                //        comm.Connection.Open();
                //           comm.Parameters.Clear();
                //           comm.Parameters.Add(new OracleParameter(":IDVALUE", Request.QueryString["param"]));

                /*                    OracleParameter _idParam = comm.CreateParameter();
                                     _idParam.ParameterName = "IDVALUE";
                                     _idParam.OracleDbType = OracleDbType.Decimal;
                  //                   _idParam.Value = 1023;
                                        _idParam.Value = Request.QueryString["param"];
                           comm.Parameters.Add(_idParam);
           */
                OracleDataAdapter myDB = new OracleDataAdapter(comm);
  //              _rdrObj = comm.ExecuteReader();
   //             table.Load(_rdrObj);

                /*     _recordsAffected = comm.ExecuteNonQuery();
                _rdrObj = comm.ExecuteReader();
                        if (_rdrObj.HasRows)
                {
                            if (_rdrObj.Read())
                            {
                                numRECIPEID = _rdrObj.GetDecimal(_rdrObj.GetOrdinal("RECIPEID"));
                                txtName = _rdrObj.GetString(_rdrObj.GetOrdinal("RECIPENAME"));
                                txtRemarks = _rdrObj.GetString(_rdrObj.GetOrdinal("DESCRIPTION"));
                              
                            }
                        }
                */
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


//        string _connstring = "Data Source=oracle1.centennialcollege.ca:1521/SQLD;User ID=COMP214F16_001_P_17;Password=password";

//        DataSet ds;

//        try
//        {
//            OracleConnection conn = new OracleConnection(_connstring);
//            conn.Open();
//            OracleCommand comm = conn.CreateCommand();
//            comm.CommandText = "Recipe_update";
//            comm.CommandType = CommandType.StoredProcedure;

//            OracleParameter _InParam1 = new OracleParameter();
//            _InParam1.ParameterName = "recipename1";
//            _InParam1.OracleDbType = OracleDbType.Varchar2;
//            _InParam1.Direction = ParameterDirection.Input;
//            //            _InParam1.Value = tbxRecipeName.Text;
//             //    _InParam1.Value = (TextBox)DetailsViewDetail.FindControl("editRecipename");
//               _InParam1.Value = "2222";
//            comm.Parameters.Add(_InParam1);

//            OracleParameter _InParam2 = new OracleParameter();
//            _InParam2.ParameterName = "cookingtime1";
//            _InParam2.OracleDbType = OracleDbType.Varchar2;
//            _InParam2.Direction = ParameterDirection.Input;
//              comm.Parameters.Add(_InParam2);

//            OracleParameter _InParam3 = new OracleParameter();
//            _InParam3.ParameterName = "SERVINGNUMBER1";
//            _InParam3.OracleDbType = OracleDbType.Varchar2;
//            _InParam3.Direction = ParameterDirection.Input;
//               comm.Parameters.Add(_InParam3);

//            OracleParameter _InParam4 = new OracleParameter();
//            _InParam4.ParameterName = "DES1";
//            _InParam4.OracleDbType = OracleDbType.Varchar2;
//            _InParam4.Direction = ParameterDirection.Input;
//            comm.Parameters.Add(_InParam4);

//            comm.ExecuteNonQuery();

//            comm.Connection.Close();
//            comm.Connection.Dispose();
//            comm = null;
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine("SQL error" + ex.Message);
//            throw new Exception("Err in running" + ex.Message);
//        }
//        finally
//        {
//            //          comm.Connection.Close();
//        } */

// //       tbxRecipeName.Text = "";
//  //      tbxSubmit.Text = "";
// //       tbxPrepare.Text = "";
////        tbxServings.Text = "";
//  //      tbxDescription.Text = "";

//        Response.Redirect("Recipes.aspx");
//    } 

    protected void btnDetailIngredients_Click(object sender, EventArgs e)
    {
        string _connstring = "Data Source=oracle1.centennialcollege.ca:1521/SQLD;User ID=COMP214F16_001_P_17;Password=password";
        //        conn.ConnectionString = connectionString;
        OracleConnection conn = new OracleConnection(_connstring);
        OracleCommand comm = conn.CreateCommand();
        comm.CommandType = CommandType.Text;
        comm.CommandText = "select recipeid,ingredientid,quantity,unit from recipeandingredient where recipeid=" + Request.QueryString["param"];
        DataSet ds;
        string _sql;
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
        DetailsView2.DataSource = ds;
        DetailsView2.DataBind();



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
            _InParam6.Value = "3003";
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
}