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
    public partial class Find_a_Forgotten_Password_Form : MetroFramework.Forms.MetroForm
    {
        public Find_a_Forgotten_Password_Form()
        {
            InitializeComponent();
        }

        private void Find_a_Forgotten_Password_Form_Load(object sender, EventArgs e)
        {
            txtUserSecurityQuestion.ReadOnly = true;
            txtUserSecurityQuestion.Enabled = false;
            txtSecurityQuestionAnswer.Enabled = false;
            btnFindPassword.Enabled = false;
        }

        private void btnSendUserInfo_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "Please enter a Username into the Field Provided!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {

                    SqlConnection sqlCon = new SqlConnection(Globals_Class.ConnectionString);
                    sqlCon.Open();

                    string SelectQuery = "SELECT * FROM Users Where Username ='" + txtUsername.Text + "'";
                    SqlCommand sqlCom = new SqlCommand(SelectQuery, sqlCon);
                    SqlDataReader sqlReader;

                    sqlReader = sqlCom.ExecuteReader();

                    while (sqlReader.Read())
                    {
                        txtUserSecurityQuestion.Text = (sqlReader["UserSecurityQuestion"].ToString());
                    }

                    sqlCon.Close();
                    txtSecurityQuestionAnswer.Enabled = true;
                    btnFindPassword.Enabled = true;
                }
                catch
                {
                    MetroFramework.MetroMessageBox.Show(this, "The Username Provided does not match any Records!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnFindPassword_Click(object sender, EventArgs e)
        {
            if (txtSecurityQuestionAnswer.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "Please enter the Security Question Answer into the Field Provided!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {

                    SqlConnection sqlCon = new SqlConnection(Globals_Class.ConnectionString);
                    sqlCon.Open();

                    string SelectQuery = "SELECT * FROM Users Where UserSecurityQuestionAnswer ='" + txtSecurityQuestionAnswer.Text + "'";
                    SqlCommand sqlCom = new SqlCommand(SelectQuery, sqlCon);
                    SqlDataReader sqlReader;

                    sqlReader = sqlCom.ExecuteReader();

                    while (sqlReader.Read())
                    {
                        string Password = (sqlReader["UserPassword"].ToString()); 
                        MetroFramework.MetroMessageBox.Show(this, "Your Password is :" + "\n" + Password, "Message", MessageBoxButtons.OK, MessageBoxIcon.None);

                    }

                    sqlCon.Close();
                    this.Close();
                    this.Dispose(true);

                }
                catch
                {
                    MetroFramework.MetroMessageBox.Show(this, "The Security Question Answer Provided does not match any Records!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
