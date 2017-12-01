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
    public partial class Find_Wine_Tasting : MetroFramework.Forms.MetroForm
    {
        public Find_Wine_Tasting()
        {
            InitializeComponent();
        }

        private void Find_Wine_Tasting_Load(object sender, EventArgs e)
        {
            panel1.Enabled = false;

            SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
            sqlcon.Open();
            string CMD = "SELECT CustomerFullName FROM WineTasting";
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
            string CMD = "SELECT CustomerFullName FROM WineTasting WHERE CustomerFullName LIKE '" + txtFilter.Text + "%'";
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
            string CMD = "SELECT WineTastingID, WineTastingDate, WineTastingTime, PartySize, CustomerPhoneNumber FROM WineTasting WHERE CustomerFullName  ='" + listBox1.Text.ToString() + "'";
            SqlCommand sqlcom = new SqlCommand(CMD, sqlcon);
            SqlDataReader Reader;
            Reader = sqlcom.ExecuteReader();

            if (Reader.HasRows)
            {
                while (Reader.Read())
                {
                    txtOldDate.Text = (Reader["WineTastingDate"].ToString());
                    txtOldPArtySize.Text = (Reader["PartySize"].ToString());
                    txtOldTime.Text = (Reader["WineTastingTime"].ToString());
                    txtCustomerPNumber.Text = (Reader["CustomerPhoneNumber"].ToString());
                   
                }
            }
            Reader.Close();
            sqlcon.Close();
        }
    }
}
