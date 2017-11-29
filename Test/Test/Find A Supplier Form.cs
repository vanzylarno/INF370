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
    public partial class Find_A_Supplier_Form : MetroFramework.Forms.MetroForm
    {
        public Find_A_Supplier_Form()
        {
            InitializeComponent();
        }

        private void Find_A_Supplier_Form_Load(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            listBox1.Items.Clear();
            SqlConnection sqlcon1 = new SqlConnection(Globals_Class.ConnectionString);
            sqlcon1.Open();
            string Select = "SELECT SupplierName FROM SupplierInforamtion";
            SqlCommand sqlcom1 = new SqlCommand(Select, sqlcon1);
            SqlDataReader Dr;
            Dr = sqlcom1.ExecuteReader();
            if (Dr.HasRows)
            {
                while (Dr.Read())
                {
                    listBox1.Items.Add(Dr["SupplierName"].ToString());
                }
            }
            Dr.Close();
            sqlcon1.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
            sqlcon.Open();
            string Query = "SELECT SupplierName FROM SupplierInforamtion WHERE SupplierName LIKE '" + txtSearch.Text + "%'";
            SqlCommand sqlcom = new SqlCommand(Query, sqlcon);
            SqlDataReader dr;
            dr = sqlcom.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    listBox1.Items.Add(dr["SupplierName"].ToString());
                }
            }
            sqlcon.Close();
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
                sqlcon.Open();
                string Query = "SELECT SupplierImage FROM SupplierInforamtion WHERE SupplierName ='" + listBox1.Text.ToString() + "'";
                SqlCommand sqlcom = new SqlCommand(Query, sqlcon);
                SqlDataAdapter da = new SqlDataAdapter(sqlcom);
                SqlCommandBuilder sqlcmb = new SqlCommandBuilder(da);
                DataSet ds = new DataSet();
                da.Fill(ds);
                sqlcon.Close();
                byte[] image = ((byte[])(ds.Tables[0].Rows[0]["SupplierImage"]));
                MemoryStream ms = new MemoryStream(image);
                pictureBox1.Image = Image.FromStream(ms);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                ms.Close();

                SqlConnection sqlcon2 = new SqlConnection(Globals_Class.ConnectionString);
                sqlcon2.Open();
                string Select = "SELECT SupplierName, SupplierAddress, SupplierEmailAddress FROM SupplierInforamtion WHERE SupplierName ='" + listBox1.Text.ToString() + "'";
                SqlCommand sqlcom2 = new SqlCommand(Select, sqlcon2);
                SqlDataReader myReader;
                myReader = sqlcom2.ExecuteReader();

                if (myReader.HasRows)
                {
                    while (myReader.Read())
                    {
                        label1.Text = (myReader["SupplierName"].ToString());
                        label2.Text = (myReader["SupplierAddress"].ToString());
                        label3.Text = (myReader["SupplierEmailAddress"].ToString());

                    }
                }
                myReader.Close();
                sqlcon2.Close();
            }
            catch
            {

                SqlConnection sqlcon2 = new SqlConnection(Globals_Class.ConnectionString);
                sqlcon2.Open();
                string Select = "SELECT SupplierName, SupplierAddress, SupplierEmailAddress FROM SupplierInforamtion WHERE SupplierName ='" + listBox1.Text.ToString() + "'";
                SqlCommand sqlcom2 = new SqlCommand(Select, sqlcon2);
                SqlDataReader myReader;
                myReader = sqlcom2.ExecuteReader();

                if (myReader.HasRows)
                {
                    while (myReader.Read())
                    {
                        label1.Text = (myReader["SupplierName"].ToString());
                        label2.Text = (myReader["SupplierAddress"].ToString());
                        label3.Text = (myReader["SupplierEmailAddress"].ToString());

                    }
                }
                myReader.Close();
                sqlcon2.Close();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
