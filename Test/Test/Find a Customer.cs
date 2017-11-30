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
    public partial class Find_a_Customer : MetroFramework.Forms.MetroForm
    {
        public Find_a_Customer()
        {
            InitializeComponent();
        }

        private void Find_a_Customer_Load(object sender, EventArgs e)
        {
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
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
