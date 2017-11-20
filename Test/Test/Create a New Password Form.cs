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
    public partial class Create_a_New_Password_Form : MetroFramework.Forms.MetroForm
    {
        public Create_a_New_Password_Form()
        {
            InitializeComponent();
        }

        private void Create_a_New_Password_Form_Load(object sender, EventArgs e)
        {
            txtNewPassword.Enabled = false;
            txtNewPasswordRetype.Enabled = false;
            btnCreateNewPassword.Enabled = false;
        }

        private void btnSendUserInfo_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "Please enter values into the fields provided!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                
                    SqlConnection sqlCon = new SqlConnection(Globals_Class.ConnectionString);
                    sqlCon.Open();
                    string SelectQuery = "SELECT * FROM Users WHERE UserName ='" + txtUsername.Text + "' AND UserPassword ='" + txtPassword.Text + "'";
                    SqlCommand sqlCom = new SqlCommand(SelectQuery, sqlCon);
                    SqlDataAdapter SDA = new SqlDataAdapter(SelectQuery, sqlCon);
                    DataTable dtbl = new DataTable();
                    SDA.Fill(dtbl);

                    if (dtbl.Rows.Count == 1)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "The User is Found!", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                    txtNewPassword.Enabled = true;
                    txtNewPasswordRetype.Enabled = true;
                    btnCreateNewPassword.Enabled = true;
                    txtUsername.Enabled = false;
                    txtPassword.Enabled = false;
                    btnSendUserInfo.Enabled = false;
                    sqlCon.Close();

                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "The User Does not exist on the System!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    sqlCon.Close();

                    }

                
            }
        }

        private void btnCreateNewPassword_Click(object sender, EventArgs e)
        {
            if (txtNewPassword.Text == "" || txtNewPasswordRetype.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "Please enter values into the fields provided!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtNewPassword.Text == txtNewPasswordRetype.Text)
            {
                try
                {
                    SqlConnection slqCon = new SqlConnection(Globals_Class.ConnectionString);
                    slqCon.Open();
                    string Update = "UPDATE Users SET UserPassword ='" + txtNewPassword.Text + "' WHERE UserName ='" +txtUsername.Text +"'";
                    SqlCommand sqlcom = new SqlCommand(Update, slqCon);
                    sqlcom.ExecuteNonQuery();
                    slqCon.Close();
                    MetroFramework.MetroMessageBox.Show(this, "User Password Updated Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                    this.Close();
                    this.Dispose(true);
                }
                catch
                {
                    MetroFramework.MetroMessageBox.Show(this, "An Error Occurred Whilst Updating Your Password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "The New Passwords do Not Match!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
