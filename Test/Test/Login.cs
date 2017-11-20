using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Test
{
    public partial class frmLogin : MetroFramework.Forms.MetroForm
    {
    

        public frmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.StyleManager = metroStyleManager1;
            metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
            metroStyleManager1.Style = MetroFramework.MetroColorStyle.Blue;
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
            string Query = "SELECT * FROM Users WHERE UserName='" + txtUsername.Text + "' and UserPassword ='" + txtPassword.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(Query, sqlcon);
            DataTable dtbl = new DataTable();
            SDA.Fill(dtbl);

            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Please enter your Username.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Please enter your Password.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }
            else if (dtbl.Rows.Count == 1)
            {
                SqlConnection sqlcon1 = new SqlConnection(Globals_Class.ConnectionString);
                sqlcon1.Open();
                string Select = "SELECT * FROM Users WHERE UserName ='" + txtUsername.Text + "' AND UserPassword ='" + txtPassword.Text + "'";
                SqlCommand sqlcom1 = new SqlCommand(Select, sqlcon1);
                SqlDataReader SQLREADER;
                SQLREADER = sqlcom1.ExecuteReader();

                while(SQLREADER.Read())
                {
                    string UserName;
                    int ID;
                    UserName = (SQLREADER["UserName"].ToString());
                    ID = Convert.ToInt32((SQLREADER["UserID"]));

                    Globals_Class.UserName = UserName;
                    Globals_Class.UserID = ID;

                    if (ID == 1)
                    {
                        Globals_Class.adminNumber = 1;
                    }
                    else
                    {
                        Globals_Class.adminNumber = 0;
                    }
                }


                MainMenu myform1 = new MainMenu();
                myform1.ShowDialog();
                this.Hide();
                this.Close();
                this.Dispose(true);


            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "The Username and Password entered does not match any records!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCreateNewAccount_Click(object sender, EventArgs e)
        {
            Create_New_Account_Form myForm = new Create_New_Account_Form();
            myForm.ShowDialog();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Help_Form myform = new Help_Form();
            myform.ShowDialog();
        }
    }
}
