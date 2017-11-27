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
    public partial class Delete_a_User : MetroFramework.Forms.MetroForm
    {
        int isAdmin;
        public Delete_a_User()
        {
            InitializeComponent();
        }

        private void Delete_a_User_Load(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
            sqlcon.Open();
            string CMD = "SELECT UserName FROM Users";
            SqlCommand sqlcom = new SqlCommand(CMD, sqlcon);
            SqlDataReader Reader;
            Reader = sqlcom.ExecuteReader();

            if (Reader.HasRows)
            {
                while (Reader.Read())
                {
                    listBox1.Items.Add(Reader["UserName"].ToString());
                }
            }
            Reader.Close();
            sqlcon.Close();
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon1 = new SqlConnection(Globals_Class.ConnectionString);
            sqlcon1.Open();
            string Select = "SELECT UserID From Users WHERE UserName ='" + listBox1.Text.ToString() + "'";
            SqlCommand sqlcom1 = new SqlCommand(Select, sqlcon1);
            SqlDataReader Reader;
            Reader = sqlcom1.ExecuteReader();
            if (Reader.HasRows)
            {
                while(Reader.Read())
                {
                    isAdmin = Convert.ToInt32((Reader["UserID"]));

                    if(isAdmin == 1)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "The Admin Account Cannot be Deleted!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        DialogResult dialogResult = MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to delete this user?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (dialogResult == DialogResult.Yes)
                        {
                            try
                            {
                                SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
                                sqlcon.Open();
                                string Command = "DELETE FROM Users WHERE UserName ='" + listBox1.Text.ToString() + "'";
                                SqlCommand sqlcom = new SqlCommand(Command, sqlcon);
                                sqlcom.ExecuteNonQuery();

                                MetroFramework.MetroMessageBox.Show(this, "The Selected User was Deleted Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                                listBox1.Items.Clear();


                                SqlConnection sqlcon2 = new SqlConnection(Globals_Class.ConnectionString);
                                sqlcon2.Open();
                                string CMD2 = "SELECT UserName FROM Users";
                                SqlCommand sqlcom2 = new SqlCommand(CMD2, sqlcon2);
                                SqlDataReader Reader2;
                                Reader2 = sqlcom2.ExecuteReader();

                                if (Reader2.HasRows)
                                {
                                    while (Reader2.Read())
                                    {
                                        listBox1.Items.Add(Reader2["UserName"].ToString());
                                    }
                                }
                                Reader2.Close();
                                sqlcon2.Close();
                            }
                            catch
                            {
                                MetroFramework.MetroMessageBox.Show(this, "An Error Occurred whislt Deleting the User!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                listBox1.Items.Clear();


                                SqlConnection sqlcon3 = new SqlConnection(Globals_Class.ConnectionString);
                                sqlcon3.Open();
                                string CMD3 = "SELECT UserName FROM Users";
                                SqlCommand sqlcom3 = new SqlCommand(CMD3, sqlcon3);
                                SqlDataReader Reader3;
                                Reader3 = sqlcom3.ExecuteReader();

                                if (Reader3.HasRows)
                                {
                                    while (Reader3.Read())
                                    {
                                        listBox1.Items.Add(Reader3["UserName"].ToString());
                                    }
                                }
                                Reader3.Close();
                                sqlcon3.Close();
                            }

                        }
                    }
            }
            
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
            sqlcon.Open();
            string CMD = "SELECT UserName FROM Users WHERE UserEmailAddress LIKE '" + txtFilter.Text + "%'";
            SqlCommand sqlcom = new SqlCommand(CMD, sqlcon);
            SqlDataReader Reader;
            Reader = sqlcom.ExecuteReader();

            if (Reader.HasRows)
            {
                while (Reader.Read())
                {
                    listBox1.Items.Add(Reader["UserName"].ToString());
                }
            }
            Reader.Close();
            sqlcon.Close();
        }
    }
}
