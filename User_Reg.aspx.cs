using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace RegistrationProject
{
    public partial class User_Reg : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Save_Click(object sender, EventArgs e)
        {
            if (ValidateInfo())
            {

                SqlConnection con = new SqlConnection();
                //con.ConnectionString = @"Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=RegistrationProjectDB;Integrated Security=True";
                con.ConnectionString = @"Data Source = SQL5109.site4now.net; Initial Catalog = db_a7ebde_dbuserregistration; User Id = db_a7ebde_dbuserregistration_admin; Password = Micronets@2021";

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select count(EmailAddress) as EmailAddress from tbl_UsersRegistration where EmailAddress= '" + this.txt_Email.Text.Trim() + "'";
                string iemail = cmd.ExecuteScalar().ToString();
                
                if (Convert.ToInt32(iemail) > 0)
                {
                    this.lab_MessageBuffer.ForeColor = System.Drawing.Color.Red;
                    this.lab_MessageBuffer.Text = "* This Email address is already registered in Database";
                }
                else
                {
                    cmd.CommandText = string.Format("INSERT INTO[dbo].[tbl_UsersRegistration]([ID], [FirstName], [LastName], [EmailAddress], [MobileNumber], [CreditCardNumber], [CreditCardExpiryDate], [CreditCardCCVNumber]) VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}')", Guid.NewGuid().ToString("N"), this.txt_FirstName.Text.Trim(), this.txt_LastName.Text.Trim(), this.txt_Email.Text.Trim(), this.txt_Mobile.Text.Trim(), this.txt_CreditCardNumber.Text.Trim(), this.txt_CreditCardExpiryDate.Text.Trim(), this.txt_CreditCardCCVNumber.Text.Trim());
                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        this.lab_MessageBuffer.Text = "* User information has been added successfuly to Database";
                    }
                    this.txt_FirstName.Text = string.Empty;
                    this.txt_LastName.Text = string.Empty;
                    this.txt_Email.Text = string.Empty;
                    this.txt_Mobile.Text = string.Empty;
                    this.txt_CreditCardNumber.Text = string.Empty;
                    this.txt_CreditCardExpiryDate.Text = string.Empty;
                    this.txt_CreditCardCCVNumber.Text = string.Empty;
                }
                con.Close();
            }

        }
        public bool ValidateInfo()
        {
            ResetLabel();
            bool flag = true;
            if(! new EmailAddressAttribute().IsValid(this.txt_Email.Text.Trim()))
            {
                this.txt_Email.BorderColor = System.Drawing.Color.Red;
                this.lab_MessageBuffer.ForeColor = System.Drawing.Color.Red;
                this.lab_MessageBuffer.Text += "* Please insert valid Email address" + System.Environment.NewLine;
                flag = false;
            }
            if(! Regex.Match(txt_Mobile.Text.Trim(), @"^([\+]?971[-]?|[0])?[1-9][0-9]{8}$").Success)
            {
                this.txt_Mobile.BorderColor = System.Drawing.Color.Red;
                this.lab_MessageBuffer.ForeColor = System.Drawing.Color.Red;
                this.lab_MessageBuffer.Text += "* Please insert valid Mobile number" + System.Environment.NewLine;
                flag = false;
            }
            if (this.txt_CreditCardNumber.Text.Trim().Length < 16)
            {
                this.txt_CreditCardNumber.BorderColor = System.Drawing.Color.Red;
                this.lab_MessageBuffer.ForeColor = System.Drawing.Color.Red;
                this.lab_MessageBuffer.Text += "* Please insert valid Credit Card number" + System.Environment.NewLine;
                flag = false;
            }
            if (this.txt_CreditCardCCVNumber.Text.Trim().Length < 3)
            {
                this.txt_CreditCardCCVNumber.BorderColor = System.Drawing.Color.Red;
                this.lab_MessageBuffer.ForeColor = System.Drawing.Color.Red;
                this.lab_MessageBuffer.Text += "* Please insert valid CCV number" + System.Environment.NewLine;
                flag = false;
            }
            DateTime inputDateTime = Convert.ToDateTime(txt_CreditCardExpiryDate.Text.Trim());
            if (inputDateTime < DateTime.Now)
            {
                this.txt_CreditCardExpiryDate.BorderColor = System.Drawing.Color.Red;
                this.lab_MessageBuffer.ForeColor = System.Drawing.Color.Red;
                this.lab_MessageBuffer.Text += "* Please select valid Card Expiration Date" + System.Environment.NewLine;
                flag = false;
            }
            return flag;
        }

        public void ResetLabel()
        {
            this.lab_MessageBuffer.Text = "";
            System.Drawing.Color defaultBorderColor = this.txt_FirstName.BorderColor;
            this.lab_MessageBuffer.ForeColor = System.Drawing.Color.Green;

            this.txt_Email.BorderColor = defaultBorderColor;
            this.txt_Mobile.BorderColor = defaultBorderColor;
            this.txt_CreditCardNumber.BorderColor = defaultBorderColor;
            this.txt_CreditCardExpiryDate.BorderColor = defaultBorderColor;
            this.txt_CreditCardCCVNumber.BorderColor = defaultBorderColor;
        }

    }
}