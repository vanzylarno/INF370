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
    public partial class VineyardTours_Booked : MetroFramework.Forms.MetroForm
    {
        public VineyardTours_Booked()
        {
            InitializeComponent();
        }
        int SelectedWineTastingID;
        string SelectedMonth;
        private void VineyardTours_Booked_Load(object sender, EventArgs e)
        {
            panel1.Enabled = false;

            SelectedMonth = cbxMonth.SelectedText;
        }

        private void cbxMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedMonth = cbxMonth.SelectedItem.ToString();
            lbxCustomerName.Items.Clear();
            SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
            sqlcon.Open();
            string Command = "SELECT VineyardTourID, CustomerFullName FROM VineyardTours WHERE TourDate Like '%" + SelectedMonth + "%'";
            SqlCommand sqlcom = new SqlCommand(Command, sqlcon);
            SqlDataReader reader;
            reader = sqlcom.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    lbxCustomerName.Items.Add(reader["CustomerFullName"].ToString());
                    SelectedWineTastingID = Convert.ToInt32((reader["VineyardTourID"]));
                }
            }
            reader.Close();
            sqlcon.Close();
        }

        private void lbxCustomerName_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
            sqlcon.Open();
            string Select = "SELECT * FROM VineyardTours WHERE CustomerFullName ='" + lbxCustomerName.Text.ToString() + "'";
            SqlCommand sqlcom = new SqlCommand(Select, sqlcon);
            SqlDataReader reader;
            reader = sqlcom.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    txtDate.Text = (reader["TourDate"].ToString());
                    txtTime.Text = (reader["TourTime"].ToString());
                    txtCustomerName.Text = (reader["CustomerFullName"].ToString());
                    txtPhoneNumber.Text = (reader["CustomerPhoneNumber"].ToString());
                    txtGroupSize.Text = (reader["GroupSize"].ToString());
                    txtEmailAddress.Text = (reader["CustomerEmailAddress"].ToString());

                }
            }
            reader.Close();
            sqlcon.Close();
        }
    }
}
