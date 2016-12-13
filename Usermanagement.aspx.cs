/* Yu Kuang 300540907 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using Oracle.ManagedDataAccess.Client;
using System.Configuration;
using System.Data;



public partial class Usermanagement : System.Web.UI.Page
{
    string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
    OracleConnection conn = new OracleConnection();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
           BindGrid();

        }
    }

    protected void BindGrid()
    {
        conn.ConnectionString = connectionString;
        OracleCommand comm = conn.CreateCommand();
        comm.CommandType = CommandType.Text;
        comm.CommandText = "select userid, username,role from users";
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


    protected void btnReturn1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Home.aspx");
    }

    protected void btnRole_Click(object sender, EventArgs e)
    {

    }

    protected void btnAddRole_Click(object sender, EventArgs e)
    {
        conn.ConnectionString = connectionString;
        OracleCommand comm = conn.CreateCommand();
        comm.CommandText = "Insert into users (userid,username,role) values(USER_ID_SEQ.nextval,:username,:Role)";
        comm.CommandType = CommandType.Text;
        comm.Parameters.Add(":username", OracleDbType.Varchar2, ParameterDirection.Input);
        comm.Parameters[":username"].Value = txtUserName.Text;
        comm.Parameters.Add(":Role", OracleDbType.Varchar2, ParameterDirection.Input);
        comm.Parameters[":Role"].Value = DropDownList2.SelectedItem.Value;

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

      //  GridView1.DataSource = ds;
      //  GridView1.DataBind();
        Response.Redirect("Usermanagement.aspx");

    }
}