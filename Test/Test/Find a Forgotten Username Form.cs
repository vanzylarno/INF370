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
    public partial class Find_a_Forgotten_Username_Form : MetroFramework.Forms.MetroForm
    {
        public Find_a_Forgotten_Username_Form()
        {
            InitializeComponent();
        }

        private void Find_a_Forgotten_Username_Form_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (txtUserEmail.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "Please Enter Your Username into the Field Provided!", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                try
                {
                    SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
                    string SelectQuery = "SELECT * FROM Users WHERE UserEmailAddress ='" + txtUserEmail.Text + "'";
                    sqlcon.Open();

                    SqlCommand sqlcom = new SqlCommand(SelectQuery, sqlcon);
                    SqlDataReader Reader;
                    Reader = sqlcom.ExecuteReader();

                    while (Reader.Read())
                    {
                        string Username = (Reader["UserName"].ToString());
                        MetroFramework.MetroMessageBox.Show(this, "Your Username is : " + "\n" + Username, "Message", MessageBoxButtons.OK, MessageBoxIcon.None);

                    }
                    sqlcon.Close();
                    this.Close();
                    this.Dispose(true);
                }
                catch
                {
                    MetroFramework.MetroMessageBox.Show(this, "The Username Provided Does not Match Any Records!", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
            
        }
    }
}
