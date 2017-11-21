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
using System.IO;

namespace Test
{
    public partial class Account_Settings_Form : MetroFramework.Forms.MetroForm
    {
       
        public Account_Settings_Form()
        {
            InitializeComponent();
        }


        private void Account_Settings_Form_Load(object sender, EventArgs e)
        {
            txtUsername.Enabled = false;
            txtPassword.Enabled = false;
            txtSecurityQuestion.Enabled = false;
            txtSecurityQuestionAnswer.Enabled = false;
            txtEmailAddress.Enabled = false;

            //Get UserInfo
            string GlobalUsername = Globals_Class.UserName;
            SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
            sqlcon.Open();
            string Select = "SELECT * FROM Users WHERE UserName ='" + GlobalUsername + "'";
            SqlCommand sqlcom = new SqlCommand(Select, sqlcon);
            SqlDataReader sqlReader;
            sqlReader = sqlcom.ExecuteReader();

            while (sqlReader.Read())
            {
                try
                {

                    // get values
                    int UserID = (Convert.ToInt32(sqlReader["UserID"]));
                    UserID = Globals_Class.UserID;
                    string Username = (sqlReader["UserName"].ToString());
                    string Password = (sqlReader["UserPassword"].ToString());
                    string SecurityQuestion = (sqlReader["UserSecurityQuestion"].ToString());
                    string SecurityQuestionAnswer = (sqlReader["UserSecurityQuestionAnswer"].ToString());
                    string emailAddress = (sqlReader["UserEmailAddress"].ToString());

                    //Display values
                    txtUsername.Text = Username;
                    txtPassword.Text = Password;
                    txtSecurityQuestion.Text = SecurityQuestion;
                    txtSecurityQuestionAnswer.Text = SecurityQuestionAnswer;
                    txtEmailAddress.Text = emailAddress;
                    byte[] img = (byte[])(sqlReader["UserImage"]);
                    if (img == null)
                        pbxUserImage.Image = null;
                    else
                    {
                        MemoryStream ms = new MemoryStream(img);
                        pbxUserImage.Image = Image.FromStream(ms);
                    }
      
                }
                catch
                {

                    // get values
                    int UserID = (Convert.ToInt32(sqlReader["UserID"]));
                    UserID = Globals_Class.UserID;
                    string Username = (sqlReader["UserName"].ToString());
                    string Password = (sqlReader["UserPassword"].ToString());
                    string SecurityQuestion = (sqlReader["UserSecurityQuestion"].ToString());
                    string SecurityQuestionAnswer = (sqlReader["UserSecurityQuestionAnswer"].ToString());
                    string emailAddress = (sqlReader["UserEmailAddress"].ToString());

                    //Display values
                    txtUsername.Text = Username;
                    txtPassword.Text = Password;
                    txtSecurityQuestion.Text = SecurityQuestion;
                    txtSecurityQuestionAnswer.Text = SecurityQuestionAnswer;
                    txtEmailAddress.Text = emailAddress;
                }

            }

            sqlcon.Close();


          
        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {
   


        }

        private void btnAddNewImage_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult DR = MetroFramework.MetroMessageBox.Show(this, "Choosing to Update Account information will cause the Application to Resart are you sure of this action?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (DR == DialogResult.Yes)
            {
                Update_Account_Information_Form myform = new Update_Account_Information_Form();
                myform.Show();
            }
            else
            {

            }
        }

        private void pbxUserImage_Click(object sender, EventArgs e)
        {

        }
    }
}
