﻿using System;
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
    public partial class Delete_a_Contact : MetroFramework.Forms.MetroForm
    {
        public Delete_a_Contact()
        {
            InitializeComponent();
        }
        int SelectedContact;
        private void Delete_a_Contact_Load(object sender, EventArgs e)
        {
            metroButton1.Enabled = true;
            txtOldEmail.Enabled = false;
            txtOldName.Enabled = false;

            SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
            sqlcon.Open();
            string cmd = "SELECT EmailAddress FROM EmailContacts";
            SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
            SqlDataReader dr;
            dr = sqlcom.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    listBox1.Items.Add((dr["EmailAddress"].ToString()));
                }
            }
            dr.Close();
            sqlcon.Close();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
            sqlcon.Open();
            string cmd = "SELECT EmailAddress, EmailID FROM EmailContacts WHERE ContactName LIKE '%" + txtFilter.Text + "%'";
            SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
            SqlDataReader dr;
            dr = sqlcom.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    listBox1.Items.Add((dr["EmailAddress"].ToString()));
                    
                }
            }
            dr.Close();
            sqlcon.Close();
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
            sqlcon.Open();
            string cmd = "SELECT EmailID, EmailAddress, ContactName FROM EmailContacts WHERE EmailAddress ='" + listBox1.Text.ToString() + "'";
            SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
            SqlDataReader dr;
            dr = sqlcom.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    txtOldEmail.Text = (dr["EmailAddress"].ToString());
                    txtOldName.Text = (dr["ContactName"].ToString());
                    SelectedContact = Convert.ToInt32((dr["EmailID"]));
                }
            }
            dr.Close();
            sqlcon.Close();
            metroButton1.Enabled = true;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to Delete this Contact?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                try
                {
                    SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
                    sqlcon.Open();
                    string cmd = "DELETE FROM EmailContacts WHERE EmailID ='" + SelectedContact.ToString() + "'";
                    SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
                    sqlcom.ExecuteNonQuery();
                    sqlcon.Close();

                    MetroFramework.MetroMessageBox.Show(this, "The Contact has been Deleted Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                    
                    txtOldEmail.Text = "";
                    txtOldName.Text = "";
                    listBox1.Items.Clear();

                    SqlConnection sqlcon2 = new SqlConnection(Globals_Class.ConnectionString);
                    sqlcon2.Open();
                    string cmd2 = "SELECT EmailAddress FROM EmailContacts";
                    SqlCommand sqlcom2 = new SqlCommand(cmd2, sqlcon2);
                    SqlDataReader dr2;
                    dr2 = sqlcom2.ExecuteReader();
                    if (dr2.HasRows)
                    {
                        while (dr2.Read())
                        {
                            listBox1.Items.Add((dr2["EmailAddress"].ToString()));
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
}
