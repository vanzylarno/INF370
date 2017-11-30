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
    public partial class Add_New_Customer : MetroFramework.Forms.MetroForm
    {
        public Add_New_Customer()
        {
            InitializeComponent();
        }

        private void Add_New_Customer_Load(object sender, EventArgs e)
        {

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
                    //Variables
                    int isMemberStatus = 0;
                    decimal PointsAvailable = 0;
                    string Fname = txtFName.Text;
                    string pNumber = txtPNumber.Text;
                    string eAddress = txtEAddress.Text;
                    string DOB = dtpDOB.Text;

                    SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
                    sqlcon.Open();
                    string cmd = "INSERT INTO Customers(CustomerFullName, CustomerPhoneNumber, CustomerEmailAddress, CustomerDOB, LoyaltyPointsAvailable, isMember) VALUES(@CustomerFullName, @CustomerPhoneNumber, @CustomerEmailAddress, @CustomerDOB, @LoyaltyPointsAvailable, @isMember)";
                    SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
                    sqlcom.Parameters.Add(new SqlParameter("@CustomerFullName", Fname));
                    sqlcom.Parameters.Add(new SqlParameter("@CustomerPhoneNumber", pNumber));
                    sqlcom.Parameters.Add(new SqlParameter("@CustomerEmailAddress", eAddress));
                    sqlcom.Parameters.Add(new SqlParameter("@CustomerDOB", DOB));
                    sqlcom.Parameters.Add(new SqlParameter("@LoyaltyPointsAvailable", isMemberStatus));
                    sqlcom.Parameters.Add(new SqlParameter("@isMember", PointsAvailable));
                    sqlcom.ExecuteNonQuery();
                    sqlcon.Close();

                    MetroFramework.MetroMessageBox.Show(this, "The New Customer was added Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    txtFName.Text = "";
                    txtEAddress.Text = "";
                    txtPNumber.Text = "";
                    dtpDOB.Text = "";
                }
                catch
                {
                    MetroFramework.MetroMessageBox.Show(this, "A Connection Could not be made to the Database!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void dtpDOB_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtEAddress_Click(object sender, EventArgs e)
        {

        }

        private void txtPNumber_Click(object sender, EventArgs e)
        {

        }

        private void txtFName_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
