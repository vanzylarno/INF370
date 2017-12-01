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
    public partial class Wine_Tastings_Booked : MetroFramework.Forms.MetroForm
    {
        public Wine_Tastings_Booked()
        {
            InitializeComponent();
        }
        //Variables
        int SelectedWineTastingID;
        string SelectedMonth;

        private void Wine_Tastings_Booked_Load(object sender, EventArgs e)
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
            string Command = "SELECT WineTastingID, CustomerFullName FROM WineTasting WHERE WineTastingDate Like '%" + SelectedMonth +"%'";
            SqlCommand sqlcom = new SqlCommand(Command, sqlcon);
            SqlDataReader reader;
            reader = sqlcom.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    lbxCustomerName.Items.Add(reader["CustomerFullName"].ToString());
                    SelectedWineTastingID = Convert.ToInt32((reader["WineTastingID"]));
                }
            }
            reader.Close();
            sqlcon.Close();
        }

        private void lbxCustomerName_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
            sqlcon.Open();
            string Select = "SELECT * FROM WineTasting WHERE CustomerFullName ='" + lbxCustomerName.Text.ToString() + "'";
            SqlCommand sqlcom = new SqlCommand(Select, sqlcon);
            SqlDataReader reader;
            reader = sqlcom.ExecuteReader();
            if (reader.HasRows)
            {
                while(reader.Read())
                {
                    txtDate.Text = (reader["WineTastingDate"].ToString());
                    txtTime.Text = (reader["WineTastingTime"].ToString());
                    txtCustomerName.Text = (reader["CustomerFullName"].ToString());
                    txtPhoneNumber.Text = (reader["CustomerPhoneNumber"].ToString());
                    txtGroupSize.Text = (reader["PartySize"].ToString());
                    txtEmailAddress.Text = (reader["CustomerEmailAddress"].ToString());

                }
            }
            reader.Close();
            sqlcon.Close();
        }
    }
}
