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
    public partial class Update_Messaging_Contact : MetroFramework.Forms.MetroForm
    {
        public Update_Messaging_Contact()
        {
            InitializeComponent();
        }
        int SelectedContact;

        private void Update_Messaging_Contact_Load(object sender, EventArgs e)
        {
            txtNewEmail.Enabled = false;
            txtNewName.Enabled = false;
            txtOldEmail.Enabled = false;
            txtOldName.Enabled = false;

            SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
            sqlcon.Open();
            string cmd = "SELECT ContactPhoneNumber FROM Messaging";
            SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
            SqlDataReader dr;
            dr = sqlcom.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    listBox1.Items.Add((dr["ContactPhoneNumber"].ToString()));
                }
            }
            dr.Close();
            sqlcon.Close();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to Update this Contact?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                if (txtNewEmail.Text == "" || txtNewName.Text == "")
                {
                    MetroFramework.MetroMessageBox.Show(this, "Not all information required has been provided!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    try
                    {
                        string name = txtNewName.Text;
                        string Email = txtNewEmail.Text;

                        SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
                        sqlcon.Open();
                        string cmd = "UPDATE Messaging SET ContactName = @ContactName, ContactPhoneNumber = @EmailAddress WHERE MessageingID ='" + SelectedContact.ToString() + "'";
                        SqlCommand sqlocm = new SqlCommand(cmd, sqlcon);
                        sqlocm.Parameters.Add(new SqlParameter("@ContactName", name));
                        sqlocm.Parameters.Add(new SqlParameter("@EmailAddress", Email));
                        sqlocm.ExecuteNonQuery();
                        sqlcon.Close();

                        MetroFramework.MetroMessageBox.Show(this, "New Contact Information Saved Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                        txtNewEmail.Text = "";
                        txtNewName.Text = "";
                        txtOldEmail.Text = "";
                        txtOldName.Text = "";
                        listBox1.Items.Clear();


                        SqlConnection sqlcon2 = new SqlConnection(Globals_Class.ConnectionString);
                        sqlcon2.Open();
                        string cmd2 = "SELECT ContactPhoneNumber FROM Messaging";
                        SqlCommand sqlcom2 = new SqlCommand(cmd2, sqlcon2);
                        SqlDataReader dr2;
                        dr2 = sqlcom2.ExecuteReader();
                        if (dr2.HasRows)
                        {
                            while (dr2.Read())
                            {
                                listBox1.Items.Add((dr2["ContactPhoneNumber"].ToString()));
                            }
                        }
                        dr2.Close();
                        sqlcon2.Close();
                    }
                    catch
                    {
                        MetroFramework.MetroMessageBox.Show(this, "A Connection to the Database Could not be Made!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
            sqlcon.Open();
            string cmd = "SELECT ContactPhoneNumber, MessageingID FROM Messaging WHERE ContactName LIKE '%" + txtFilter.Text + "%'";
            SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
            SqlDataReader dr;
            dr = sqlcom.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    listBox1.Items.Add((dr["ContactPhoneNumber"].ToString()));

                }
            }
            dr.Close();
            sqlcon.Close();
        }

        private void listBox1_Click(object sender, EventArgs e)
        {

            SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
            sqlcon.Open();
            string cmd = "SELECT MessageingID, ContactPhoneNumber, ContactName FROM Messaging WHERE ContactPhoneNumber ='" + listBox1.Text.ToString() + "'";
            SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
            SqlDataReader dr;
            dr = sqlcom.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    txtOldEmail.Text = (dr["ContactPhoneNumber"].ToString());
                    txtOldName.Text = (dr["ContactName"].ToString());
                    SelectedContact = Convert.ToInt32((dr["MessageingID"]));
                }
            }
            dr.Close();
            sqlcon.Close();
            txtNewEmail.Enabled = true;
            txtNewName.Enabled = true;
        }
    }
}
