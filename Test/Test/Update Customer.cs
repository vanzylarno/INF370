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
    public partial class Update_Customer : MetroFramework.Forms.MetroForm
    {
        public Update_Customer()
        {
            InitializeComponent();
        }

        private void Update_Customer_Load(object sender, EventArgs e)
        {
            panel1.Enabled = false;

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

        private void txtFilter_Click(object sender, EventArgs e)
        {

        }



        int CustomerID;
        private void listBox1_Click(object sender, EventArgs e)
        {
            DialogResult result = MetroFramework.MetroMessageBox.Show(this, "Are you Sure you want to Update this Customer?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                panel2.Enabled = false;
                panel1.Enabled = true;
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
                
            }
            else
            {
                panel1.Enabled = false;
                panel2.Enabled = true;
                listBox1.Text = "";
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
            
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (txtFName.Text == "" || txtPNumber.Text == "" || txtEAddress.Text == "" || dtpDOB.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "Not all information required has been provided!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    //Update Customer Instance
                    //Variables
                    string Fname = txtFName.Text;
                    string pNumber = txtPNumber.Text;
                    string EmailAddress = txtEAddress.Text;
                    string DOB = dtpDOB.Text;

                    SqlConnection sqlcon2 = new SqlConnection(Globals_Class.ConnectionString);
                    sqlcon2.Open();
                    string Update = "UPDATE Customers SET CustomerFullName = @CustomerFullName, CustomerPhoneNumber = @CustomerPhoneNumber, CustomerEmailAddress = @CustomerEmailAddress, CustomerDOB = @CustomerDOB WHERE CustomerID ='" + CustomerID.ToString() + "'";
                    SqlCommand sqlcom2 = new SqlCommand(Update, sqlcon2);
                    sqlcom2.Parameters.Add(new SqlParameter("@CustomerFullName", Fname));
                    sqlcom2.Parameters.Add(new SqlParameter("@CustomerPhoneNumber", pNumber));
                    sqlcom2.Parameters.Add(new SqlParameter("@CustomerEmailAddress", EmailAddress));
                    sqlcom2.Parameters.Add(new SqlParameter("@CustomerDOB", DOB));
                    sqlcom2.ExecuteNonQuery();
                    sqlcon2.Close();

                    MetroFramework.MetroMessageBox.Show(this, "The Customer has been Updated Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    panel1.Enabled = false;
                    panel2.Enabled = true;

                    txtFName.Text = "";
                    txtEAddress.Text = "";
                    txtPNumber.Text = "";
                    dtpDOB.Text = "";

                    //Update Listbox
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
                catch
                {
                    MetroFramework.MetroMessageBox.Show(this, "A Connection Could not be made to the Database!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void txtFilter_TextChanged_1(object sender, EventArgs e)
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
    }
}
