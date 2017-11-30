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
    public partial class Delete_a_Customer : MetroFramework.Forms.MetroForm
    {
        public Delete_a_Customer()
        {
            InitializeComponent();
        }

        private void Delete_a_Customer_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            txtDob.Enabled = false;
            txtEmailAddress.Enabled = false;
            txtFName.Enabled = false;
            txtPhoneNumber.Enabled = false;

            SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
            sqlcon.Open();
            string CMD = "SELECT CustomerFullName FROM Customers";
            SqlCommand sqlcom = new SqlCommand(CMD, sqlcon);
            SqlDataReader Reader;
            Reader = sqlcom.ExecuteReader();

            if (Reader.HasRows)
            {
                while (Reader.Read())
                {
                    listBox1.Items.Add(Reader["CustomerFullName"].ToString());
                }
            }
            Reader.Close();
            sqlcon.Close();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
            sqlcon.Open();
            string CMD = "SELECT CustomerFullName FROM Customers WHERE CustomerFullName LIKE '" + txtFilter.Text + "%'";
            SqlCommand sqlcom = new SqlCommand(CMD, sqlcon);
            SqlDataReader Reader;
            Reader = sqlcom.ExecuteReader();

            if (Reader.HasRows)
            {
                while (Reader.Read())
                {
                    listBox1.Items.Add(Reader["CustomerFullName"].ToString());
                }
            }
            Reader.Close();
            sqlcon.Close();
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
            sqlcon.Open();
            string CMD = "SELECT * FROM Customers WHERE CustomerFullName ='" + listBox1.Text.ToString() + "'";
            SqlCommand sqlcom = new SqlCommand(CMD, sqlcon);
            SqlDataReader Reader;
            Reader = sqlcom.ExecuteReader();

            if (Reader.HasRows)
            {
                while (Reader.Read())
                {
                    txtFName.Text = (Reader["CustomerFullName"].ToString());
                    txtPhoneNumber.Text = (Reader["CustomerPhoneNumber"].ToString());
                    txtEmailAddress.Text = (Reader["CustomerEmailAddress"].ToString());
                    txtDob.Text = Convert.ToString((Reader["CustomerDOB"]));
                }
            }
            Reader.Close();
            sqlcon.Close();
            btnDelete.Enabled = true;

        }
        int CustomerID;
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to Delete this Customer?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    //Get CustomerID
                    SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
                    sqlcon.Open();
                    string Select = "SELECT CustomerID FROM Customers WHERE CustomerFullName ='" + listBox1.Text.ToString() + "'";
                    SqlCommand sqlcom = new SqlCommand(Select, sqlcon);
                    SqlDataReader reader;
                    reader = sqlcom.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            CustomerID = Convert.ToInt32((reader["CustomerID"]));

                        }
                    }
                    reader.Close();
                    sqlcon.Close();

                    SqlConnection sqlcon2 = new SqlConnection(Globals_Class.ConnectionString);
                    sqlcon2.Open();
                    string cmd = "DELETE FROM Customers WHERE CustomerID ='" + CustomerID.ToString() + "'";
                    SqlCommand sqlcom2 = new SqlCommand(cmd, sqlcon2);
                    sqlcom2.ExecuteNonQuery();
                    sqlcon2.Close();
                    MetroFramework.MetroMessageBox.Show(this, "Customer Successfully Deleted!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    btnDelete.Enabled = false;


                    listBox1.Items.Clear();
                    SqlConnection sqlcon3 = new SqlConnection(Globals_Class.ConnectionString);
                    sqlcon3.Open();
                    string CMD3 = "SELECT CustomerFullName FROM Customers";
                    SqlCommand sqlcom3 = new SqlCommand(CMD3, sqlcon3);
                    SqlDataReader Reader3;
                    Reader3 = sqlcom3.ExecuteReader();

                    if (Reader3.HasRows)
                    {
                        while (Reader3.Read())
                        {
                            listBox1.Items.Add(Reader3["CustomerFullName"].ToString());
                        }
                    }
                    Reader3.Close();
                    sqlcon3.Close();
                }
                catch
                {
                    MetroFramework.MetroMessageBox.Show(this, "Could not Connect to the Database!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
