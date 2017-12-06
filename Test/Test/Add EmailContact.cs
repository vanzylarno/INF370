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
    public partial class Add_EmailContact : MetroFramework.Forms.MetroForm
    {
        public Add_EmailContact()
        {
            InitializeComponent();
        }

        private void Add_EmailContact_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if(txtEmail.Text == "" || txtName.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "Not all information required has been provided!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
                    sqlcon.Open();
                    string cmd = "Insert into EmailContacts(ContactName, EmailAddress) VALUES(@ContactName, @EmailAddress)";
                    SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
                    sqlcom.Parameters.Add(new SqlParameter("@ContactName", txtName.Text));
                    sqlcom.Parameters.Add(new SqlParameter("@EmailAddress", txtEmail.Text));
                    sqlcom.ExecuteNonQuery();
                    sqlcon.Close();

                    MetroFramework.MetroMessageBox.Show(this, "New Contact Added Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                    txtEmail.Text = "";
                    txtName.Text = "";
                }
                catch
                {
                    MetroFramework.MetroMessageBox.Show(this, "A Connection to the Database could not be made!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
