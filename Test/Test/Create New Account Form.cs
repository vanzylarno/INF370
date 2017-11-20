using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Test
{
    public partial class Create_New_Account_Form : MetroFramework.Forms.MetroForm
    {
        public Create_New_Account_Form()
        {
            InitializeComponent();
        }

        private void Create_New_Account_Form_Load(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "" || txtPasswordRetype.Text == "" || txtSecurityQuestion.Text == "" || txtSecurityQuestionAnswer.Text == "" || txtEmailAddress.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "Not all fields provided have been filled out!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if( txtPassword.Text != txtPasswordRetype.Text)
            {
                MetroFramework.MetroMessageBox.Show(this, "The Passwords provided do not match!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtUsername.Text == "admin" || txtPassword.Text == "admin")
            {
                MetroFramework.MetroMessageBox.Show(this, "Invalid Information was Given!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Text = "";
                txtPassword.Text = "";
                txtPasswordRetype.Text = "";
                txtSecurityQuestion.Text = "";
                txtSecurityQuestionAnswer.Text = "";
                txtEmailAddress.Text = "";
            }
            else
            {
                try
                {
                    string Username = txtUsername.Text;
                    string Password = txtPassword.Text;
                    string PasswordRetype = txtPasswordRetype.Text;
                    string SecurityQuestion = txtSecurityQuestion.Text;
                    string SecurityQuestionAnswer = txtSecurityQuestionAnswer.Text;
                    string EmailAddress = txtEmailAddress.Text;

                    SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
                    string InsertQuery = "INSERT INTO Users(Username, UserPassword, UserSecurityQuestion, UserSecurityQuestionAnswer, UserEmailAddress) VALUES(@Username, @UserPassword, @UserSecurityQuestion, @UserSecurityQuestionAnswer, @UserEmailAddress)";
                    SqlCommand sqlCom = new SqlCommand(InsertQuery, sqlcon);
                    sqlCom.Parameters.AddWithValue("@Username", Username);
                    sqlCom.Parameters.AddWithValue("@UserPassword", Password);
                    sqlCom.Parameters.AddWithValue("@UserSecurityQuestion", SecurityQuestion);
                    sqlCom.Parameters.AddWithValue("@UserSecurityQuestionAnswer", SecurityQuestionAnswer);
                    sqlCom.Parameters.AddWithValue("@UserEmailAddress", EmailAddress);

                    sqlcon.Open();
                    sqlCom.ExecuteNonQuery();
                    sqlcon.Close();

                    MetroFramework.MetroMessageBox.Show(this, "The new Account was Created Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);

                    this.Close();
                    this.Dispose(true);
                }
                catch
                {
                    MetroFramework.MetroMessageBox.Show(this, "An Error has occurred while Creating a New Account!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }



        }
    }
}
