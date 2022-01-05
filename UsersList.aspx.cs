using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace RegistrationProject
{
    public partial class UsersList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            //con.ConnectionString = @"Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=RegistrationProjectDB;Integrated Security=True";
            con.ConnectionString = @"Data Source=SQL5109.site4now.net;Initial Catalog=db_a7ebde_dbuserregistration;User Id=db_a7ebde_dbuserregistration_admin;Password=Micronets@2021";

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = string.Format("select [FirstName] as [First Name], [LastName] as [Last Name], [EmailAddress] As [Email Address], [MobileNumber] as [Mobile Number] from [dbo].[tbl_UsersRegistration]");
            SqlDataReader reader = cmd.ExecuteReader();
            GV_UsersList.DataSource = reader;
            GV_UsersList.DataBind();

            con.Close();

        }
    }
}