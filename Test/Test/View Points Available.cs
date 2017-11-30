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
    public partial class View_Points_Available : MetroFramework.Forms.MetroForm
    {
        public View_Points_Available()
        {
            InitializeComponent();
        }

        private void View_Points_Available_Load(object sender, EventArgs e)
        {
            lblPAvilable.Text = "0";

            txtFName.Enabled = false;
            txtPhoneNumber.Enabled = false;
            txtEmailAddress.Enabled = false;
            txtDob.Enabled = false;
        
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
        int CustomerID;
        string CustomerName;
        string CustomerPnumber;
        string CustomerEmailAddress;
        string CustomerDOB;
        decimal PointsAvailable;


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

        private void listBox1_Click(object sender, EventArgs e)
        {
            Membership();



            //Get Customer Details
            SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
            sqlcon.Open();
            string Select = "SELECT CustomerID, CustomerFullName, CustomerPhoneNumber, CustomerEmailAddress, CustomerDOB, isMember, LoyaltyPointsAvailable FROM Customers WHERE CustomerFullName ='" + listBox1.Text.ToString() + "'";
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
                    PointsAvailable = Convert.ToDecimal((reader["LoyaltyPointsAvailable"]));

                    txtFName.Text = CustomerName.ToString();
                    txtPhoneNumber.Text = CustomerPnumber;
                    txtEmailAddress.Text = CustomerEmailAddress;
                    txtDob.Text = CustomerDOB;
                    lblPAvilable.Text = PointsAvailable.ToString();


                }
            }
            reader.Close();
            sqlcon.Close();
            
        }
    }
}
