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
    public partial class Update_Notification : MetroFramework.Forms.MetroForm
    {
        public Update_Notification()
        {
            InitializeComponent();
        }

        private void Update_Notification_Load(object sender, EventArgs e)
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
            if(r.HasRows)
            {
                while(r.Read())
                {
                    listBox1.Items.Add((r["NotificationName"].ToString()));
                }
            }
            r.Close();
            sqlcon.Close();
        }

        private void txtNewName_Click(object sender, EventArgs e)
        {

        }
        int Selected;

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
            if (txtNewName.Text == "" || txtNewDescription.Text == "" || metroDateTime1.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "Not All information required has been Provided!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            { 
            DialogResult r = MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to update this Notification?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (r == DialogResult.Yes)
                {
                    try
                    {
                        string name = txtNewName.Text;
                        string desc = txtNewDescription.Text;
                        string date = metroDateTime1.Text;
                        SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
                        sqlcon.Open();
                        string cmd = "UPDATE Notifications SET NotificationName = @Name, NotificationDescription = @Description, NotificationDate = @Date WHERE NotificationID ='" + Selected.ToString() + "'";
                        SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
                        sqlcom.Parameters.Add(new SqlParameter("@Name", name));
                        sqlcom.Parameters.Add(new SqlParameter("@Description", desc));
                        sqlcom.Parameters.Add(new SqlParameter("@Date", date));
                        sqlcom.ExecuteNonQuery();
                        sqlcon.Close();

                        MetroFramework.MetroMessageBox.Show(this, "Notification Updated Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                        txtNewDescription.Text = "";
                        txtNewName.Text = "";
                        txtOldDate.Text = "";
                        txtOldDescription.Text = "";
                        txtOldName.Text = "";
                        metroDateTime1.Text = "";

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
}
