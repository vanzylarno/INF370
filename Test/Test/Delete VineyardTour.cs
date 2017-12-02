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
    public partial class Delete_VineyardTour : MetroFramework.Forms.MetroForm
    {
        public Delete_VineyardTour()
        {
            InitializeComponent();
        }
        int SelectedWineTastingID;
        private void Delete_VineyardTour_Load(object sender, EventArgs e)
        {
            panel1.Enabled = false;

            SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
            sqlcon.Open();
            string CMD = "SELECT CustomerFullName FROM VineyardTours";
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
            string CMD = "SELECT CustomerFullName FROM VineyardTours WHERE CustomerFullName LIKE '" + txtFilter.Text + "%'";
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
            string CMD = "SELECT VineyardTourID, TourDate, TourTime, GroupSize, CustomerPhoneNumber FROM VineyardTours WHERE CustomerFullName  ='" + listBox1.Text.ToString() + "'";
            SqlCommand sqlcom = new SqlCommand(CMD, sqlcon);
            SqlDataReader Reader;
            Reader = sqlcom.ExecuteReader();

            if (Reader.HasRows)
            {
                while (Reader.Read())
                {
                    txtOldDate.Text = (Reader["TourDate"].ToString());
                    txtOldPArtySize.Text = (Reader["GroupSize"].ToString());
                    txtOldTime.Text = (Reader["TourTime"].ToString());
                    txtCustomerPNumber.Text = (Reader["CustomerPhoneNumber"].ToString());
                    SelectedWineTastingID = Convert.ToInt32((Reader["VineyardTourID"]));
                }
            }
            Reader.Close();
            sqlcon.Close();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to Delete this Vineyard Tour?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
                    sqlcon.Open();
                    string cmd = "DELETE FROM VineyardTours WHERE VineyardTourID ='" + SelectedWineTastingID.ToString() + "'";
                    SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
                    sqlcom.ExecuteNonQuery();
                    sqlcon.Close();

                    MetroFramework.MetroMessageBox.Show(this, "The Booking has been successfully Deleted!", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);

                    //Update List
                    listBox1.Items.Clear();
                    SqlConnection sqlcon2 = new SqlConnection(Globals_Class.ConnectionString);
                    sqlcon2.Open();
                    string CMD2 = "SELECT CustomerFullName FROM VineyardTours";
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

                    txtCustomerPNumber.Text = "";
                    txtOldDate.Text = "";
                    txtOldPArtySize.Text = "";
                    txtOldTime.Text = "";
                }
                catch
                {
                    MetroFramework.MetroMessageBox.Show(this, "A Connection to the Database could not be Made!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
