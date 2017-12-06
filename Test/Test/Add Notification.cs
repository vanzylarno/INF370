using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace Test
{
    public partial class Add_Notification : MetroFramework.Forms.MetroForm
    {
        public Add_Notification()
        {
            InitializeComponent();
        }

        private void Add_Notification_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if(txtName.Text == "" || txtDescription.Text == "" || DTPdate.Text == "" )
            {
                MetroFramework.MetroMessageBox.Show(this, "Not all information required has been provided!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    string name = txtName.Text;
                    string Desc = txtDescription.Text;
                    string date = DTPdate.Text;

                    SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
                    sqlcon.Open();
                    string cmd = "INSERT INTO Notifications(NotificationName, NotificationDescription, NotificationDate) VALUES(@Name, @Description, @Date)";
                    SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
                    sqlcom.Parameters.Add(new SqlParameter("@Name", name));
                    sqlcom.Parameters.Add(new SqlParameter("@Description", Desc));
                    sqlcom.Parameters.Add(new SqlParameter("@Date", date));
                    sqlcom.ExecuteNonQuery();
                    sqlcon.Close();

                    MetroFramework.MetroMessageBox.Show(this, "Notification added Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                    txtName.Text = "";
                    txtDescription.Text = "";
                    DTPdate.Text = "";
                }
                catch
                {

                    MetroFramework.MetroMessageBox.Show(this, "A Connection to the Database Could not be Made!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
