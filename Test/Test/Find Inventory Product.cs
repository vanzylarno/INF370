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
    public partial class Find_Inventory_Product : MetroFramework.Forms.MetroForm
    {
        public Find_Inventory_Product()
        {
            InitializeComponent();
        }

        private void Find_Inventory_Product_Load(object sender, EventArgs e)
        {
            txtName.Enabled = false;
            txtDescription.Enabled = false;
            txtType.Enabled = false;
            txtQuantity.Enabled = false;
            SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
            sqlcon.Open();
            string Query = "SELECT ProductName FROM Products";
            SqlCommand sqlcom = new SqlCommand(Query, sqlcon);
            SqlDataReader dr;
            dr = sqlcom.ExecuteReader();
            if (dr.HasRows)
            {
                while(dr.Read())
                {
                    listBox1.Items.Add((dr["ProductName"].ToString()));
                }
            }
            dr.Close();
            sqlcon.Close();
        }


        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
            sqlcon.Open();
            string Query = "SELECT ProductName FROM Products WHERE ProductName LIKE '" + txtFilter.Text + "%'";
            SqlCommand sqlcom = new SqlCommand(Query, sqlcon);
            SqlDataReader dr;
            dr = sqlcom.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    listBox1.Items.Add(dr["ProductName"].ToString());
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
                string Command = "SELECT ProductName, ProductType, ProductDescription, ProductQuantity, ProductImage FROM Products WHERE ProductName ='" + listBox1.Text.ToString() + "'";
                SqlCommand sqlcom = new SqlCommand(Command, sqlcon);
                SqlDataReader dr;
                SqlDataAdapter da = new SqlDataAdapter(sqlcom);
                SqlCommandBuilder sqlcmb = new SqlCommandBuilder(da);
                DataSet ds = new DataSet();
                da.Fill(ds);
                byte[] image = ((byte[])(ds.Tables[0].Rows[0]["ProductImage"]));
                MemoryStream ms = new MemoryStream(image);
                pictureBox1.Image = Image.FromStream(ms);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                ms.Close();

                dr = sqlcom.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        txtName.Text = (dr["ProductName"].ToString());
                        txtType.Text = (dr["ProductType"].ToString());
                        txtDescription.Text = (dr["ProductDescription"].ToString());
                        txtQuantity.Text = Convert.ToString((dr["ProductQuantity"]));

                    }
                }
                dr.Close();
                sqlcon.Close();
            }
            catch
            {
                MetroFramework.MetroMessageBox.Show(this, "An Error Occurred Whilst Retrieving your ProductN Information!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            

        }
    }
}
