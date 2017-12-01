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
    public partial class Add_Wine_Tasting : MetroFramework.Forms.MetroForm
    {
        public Add_Wine_Tasting()
        {
            InitializeComponent();
        }

        private void Add_Wine_Tasting_Load(object sender, EventArgs e)
        {
            panel1.Enabled = false;
            panel2.Enabled = false;
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

        private void metroLabel1_Click(object sender, EventArgs e)
        {
            WineTasting_Help_Page myform = new WineTasting_Help_Page();
            myform.ShowDialog();
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
                    txtCustomerName.Text = (Reader["CustomerFullName"].ToString());
                    txtCustomerPhoneNumber.Text = (Reader["CustomerPhoneNumber"].ToString());
                    txtCustomerEmailAddress.Text = (Reader["CustomerEmailAddress"].ToString());
                }
            }
            panel2.Enabled = true;
            Reader.Close();
            sqlcon.Close();
            
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            metroPanel1.Enabled = false;

            if (dtpDate.Text == "" || txtGroupSize.Text == "" || txtTime.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "Not all information required has been Provided!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult dialog = MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to book this Wine Tasting?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialog == DialogResult.Yes)
                {
                    try
                    {
                        
                        //Variables
                        string WineTastingDate = dtpDate.Text;
                        string WineTastingTime = txtTime.Text;
                        string CustomerFullName = txtCustomerName.Text;
                        string CustomerPhoneNumber = txtCustomerPhoneNumber.Text;
                        int PartySize = Convert.ToInt32(txtGroupSize.Text);
                        string CustomerEmailAddress = txtCustomerEmailAddress.Text;

                        SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
                        sqlcon.Open();
                        string Query = "INSERT INTO WineTasting(WineTastingDate, WineTastingTime, CustomerFullName, CustomerPhoneNumber, PartySize, CustomerEmailAddress) VALUES(@WineTastingDate, @WineTastingTime, @CustomerFullName, @CustomerPhoneNumber, @PartySize, @CustomerEmailAddress)";
                        SqlCommand sqlcom = new SqlCommand(Query, sqlcon);
                        sqlcom.Parameters.Add(new SqlParameter("@WineTastingDate", WineTastingDate));
                        sqlcom.Parameters.Add(new SqlParameter("@WineTastingTime", WineTastingTime));
                        sqlcom.Parameters.Add(new SqlParameter("@CustomerFullName", CustomerFullName));
                        sqlcom.Parameters.Add(new SqlParameter("@CustomerPhoneNumber", CustomerPhoneNumber));
                        sqlcom.Parameters.Add(new SqlParameter("@PartySize", PartySize));
                        sqlcom.Parameters.Add(new SqlParameter("@CustomerEmailAddress", CustomerEmailAddress));
                        sqlcom.ExecuteNonQuery();
                        sqlcon.Close();


                        MetroFramework.MetroMessageBox.Show(this, "Wine Tasting Booking Made Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    catch
                    {
                        MetroFramework.MetroMessageBox.Show(this, "A Connection to the Database could not be made!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                txtTime.Text = "";
                txtGroupSize.Text = "";
                dtpDate.Text = "";
                metroPanel1.Enabled = true;
                panel2.Enabled = false;
            }
        }
    }
}
