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
    public partial class Loyalty_Program : MetroFramework.Forms.MetroForm
    {
        public Loyalty_Program()
        {
            InitializeComponent();
        }

        private void Loyalty_Program_Load(object sender, EventArgs e)
        {
            txtFName.Enabled = false;
            txtPhoneNumber.Enabled = false;
            txtEmailAddress.Enabled = false;
            txtDob.Enabled = false;
            btnAdd.Enabled = false;
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
        int isMember;
        private void Membership()
        {
            //Get Customer Details
            SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
            sqlcon.Open();
            string Select = "SELECT CustomerID, CustomerFullName, CustomerPhoneNumber, CustomerEmailAddress, CustomerDOB, isMember FROM Customers WHERE CustomerFullName ='" + listBox1.Text.ToString() + "'";
            SqlCommand sqlcom = new SqlCommand(Select, sqlcon);
            SqlDataReader reader;
            reader = sqlcom.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    CustomerID = Convert.ToInt32((reader["CustomerID"]));
                    CustomerName = (reader["CustomerFullName"].ToString());
                    CustomerPnumber = (reader["CustomerPhoneNumber"].ToString());
                    CustomerEmailAddress = (reader["CustomerEmailAddress"].ToString());
                    CustomerDOB = (reader["CustomerDOB"].ToString());
                    isMember = Convert.ToInt32((reader["isMember"]));

                    txtFName.Text = CustomerName.ToString();
                    txtPhoneNumber.Text = CustomerPnumber;
                    txtEmailAddress.Text = CustomerEmailAddress;
                    txtDob.Text = CustomerDOB;

                    if (isMember == 1)
                    {
                        pictureBox1.Image = imageList1.Images[0];
                    }
                    else
                    {
                        pictureBox1.Image = imageList1.Images[1];
                    }
                }
            }
            reader.Close();
            sqlcon.Close();
        }
        int CustomerID;
        string CustomerName;
        string CustomerPnumber;
        string CustomerEmailAddress;
        string CustomerDOB;
     

        private void listBox1_Click(object sender, EventArgs e)
        {
            Membership();
            
            

                //Get Customer Details
                SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
                sqlcon.Open();
                string Select = "SELECT CustomerID, CustomerFullName, CustomerPhoneNumber, CustomerEmailAddress, CustomerDOB, isMember FROM Customers WHERE CustomerFullName ='" + listBox1.Text.ToString() + "'";
                SqlCommand sqlcom = new SqlCommand(Select, sqlcon);
                SqlDataReader reader;
                reader = sqlcom.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        CustomerID = Convert.ToInt32((reader["CustomerID"]));
                        CustomerName = (reader["CustomerFullName"].ToString());
                        CustomerPnumber = (reader["CustomerPhoneNumber"].ToString());
                        CustomerEmailAddress = (reader["CustomerEmailAddress"].ToString());
                        CustomerDOB = (reader["CustomerDOB"].ToString());
                        isMember = Convert.ToInt32((reader["isMember"]));

                        txtFName.Text = CustomerName.ToString();
                        txtPhoneNumber.Text = CustomerPnumber;
                        txtEmailAddress.Text = CustomerEmailAddress;
                        txtDob.Text = CustomerDOB;


                    }
                }
                reader.Close();
                sqlcon.Close();
                btnAdd.Enabled = true;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DialogResult result = MetroFramework.MetroMessageBox.Show(this, "Are you Sure you want to Add this Customer to the Loyalty Program?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
                    sqlcon.Open();
                    string Update = "UPDATE Customers SET isMember ='" + Globals_Class.isLoyaltyMember.ToString() + "' WHERE CustomerID ='" + CustomerID + "'";
                    SqlCommand sqlcom = new SqlCommand(Update, sqlcon);
                    sqlcom.ExecuteNonQuery();
                    sqlcon.Close();

                    MetroFramework.MetroMessageBox.Show(this, "User Added to The Loyalty Program!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    btnAdd.Enabled = false;

                    //Refresh List
                    listBox1.Text = "";
                    listBox1.Items.Clear();

                    SqlConnection sqlcon2 = new SqlConnection(Globals_Class.ConnectionString);
                    sqlcon2.Open();
                    string CMD2 = "SELECT CustomerFullName FROM Customers";
                    SqlCommand sqlcom2 = new SqlCommand(CMD2, sqlcon2);
                    SqlDataReader Reader2;
                    Reader2 = sqlcom2.ExecuteReader();

                    if (Reader2.HasRows)
                    {
                        while (Reader2.Read())
                        {
                            listBox1.Items.Add(Reader2["CustomerFullName"].ToString());
                        }
                    }
                    Reader2.Close();
                    sqlcon2.Close();
                }
                catch
                {
                    MetroFramework.MetroMessageBox.Show(this, "Could not Connect to the Database!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                btnAdd.Enabled = false;
                listBox1.Items.Clear();

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
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

