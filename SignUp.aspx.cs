/* Yu Kuang 300540907 */

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
public partial class SignUp : ThemePage
{
    string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
    OracleConnection conn = new OracleConnection();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
          //  BindGrid();
        }

    }

    protected void btnSignUp_Click(object sender, EventArgs e)
    {
        //  Response.Redirect("Login.aspx");

        conn.ConnectionString = connectionString;
        OracleCommand comm = conn.CreateCommand();
        comm.CommandText = "Insert into users (userid,username,password) values(USER_ID_SEQ.nextval,:username,:password)";
        comm.CommandType = CommandType.Text;
        comm.Parameters.Add(":username", OracleDbType.Varchar2, ParameterDirection.Input);
        comm.Parameters[":username"].Value = userName.Text;
        comm.Parameters.Add(":password", OracleDbType.Varchar2, ParameterDirection.Input);
        comm.Parameters[":password"].Value = password.Text;

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

       
        Response.Redirect("Login.aspx");

    }

}
