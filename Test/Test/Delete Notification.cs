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
    public partial class Delete_Notification : MetroFramework.Forms.MetroForm
    {
        public Delete_Notification()
        {
            InitializeComponent();
        }
        int Selected;

        private void Delete_Notification_Load(object sender, EventArgs e)
        {
            metroButton1.Enabled = false;
            txtOldDate.Enabled = false;
            txtOldDescription.Enabled = false;
            txtOldName.Enabled = false;
            SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
            sqlcon.Open();
            string cmd = "SELECT NotificationName FROM Notifications";
            SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
            SqlDataReader r;
            r = sqlcom.ExecuteReader();
            if (r.HasRows)
            {
                while (r.Read())
                {
                    listBox1.Items.Add((r["NotificationName"].ToString()));
                }
            }
            r.Close();
            sqlcon.Close();
        }

        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
            sqlcon.Open();
            string cmd = "SELECT NotificationName FROM Notifications WHERE NotificationDate LIKE '%" + metroTextBox1.Text + "%'";
            SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
            SqlDataReader r;
            r = sqlcom.ExecuteReader();
            if (r.HasRows)
            {
                while (r.Read())
                {
                    listBox1.Items.Add((r["NotificationName"].ToString()));

                }
            }
            r.Close();
            sqlcon.Close();
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
            sqlcon.Open();
            string cmd = "SELECT * FROM Notifications WHERE NotificationName ='" + listBox1.Text.ToString() + "'";
            SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
            SqlDataReader r;
            r = sqlcom.ExecuteReader();
            if (r.HasRows)
            {
                while (r.Read())
                {
                    Selected = Convert.ToInt32((r["NotificationID"]));
                    txtOldName.Text = (r["NotificationName"].ToString());
                    txtOldDescription.Text = (r["NotificationDescription"].ToString());
                    txtOldDate.Text = (r["NotificationDate"].ToString());
                    metroButton1.Enabled = true;
                }
            }
            r.Close();
            sqlcon.Close();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            DialogResult r = MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to Delete this Notification?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (r == DialogResult.Yes)
            {
                try
                {
                    SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
                    sqlcon.Open();
                    string cmd = "DELETE FROM Notifications WHERE NotificationID ='" + Selected.ToString() + "'";
                    SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
                    sqlcom.ExecuteNonQuery();
                    sqlcon.Close();


                    MetroFramework.MetroMessageBox.Show(this, "Notification Deleted Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                
                    txtOldDate.Text = "";
                    txtOldDescription.Text = "";
                    txtOldName.Text = "";
                   

                    listBox1.Items.Clear();
                    SqlConnection sqlcon2 = new SqlConnection(Globals_Class.ConnectionString);
                    sqlcon2.Open();
                    string cmd2 = "SELECT NotificationName FROM Notifications";
                    SqlCommand sqlcom2 = new SqlCommand(cmd2, sqlcon2);
                    SqlDataReader r2;
                    r2 = sqlcom2.ExecuteReader();
                    if (r2.HasRows)
                    {
                        while (r2.Read())
                        {
                            listBox1.Items.Add((r2["NotificationName"].ToString()));
                        }
                    }
                    r2.Close();
                    sqlcon2.Close();
                }
                catch
                {
                    MetroFramework.MetroMessageBox.Show(this, "A Connection to the Database Could not be Made!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
