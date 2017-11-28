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
    public partial class Make_a_New_Sale : MetroFramework.Forms.MetroForm
    {
        public Make_a_New_Sale()
        {
            InitializeComponent();
        }
        

        private void Make_a_New_Sale_Load(object sender, EventArgs e)
        {
            try
            {


                btnAddToBasket.Enabled = false;
                btnCaptureSale.Enabled = false;
                txtName.Enabled = false;
                txtPrice.Enabled = false;
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
                    while (dr.Read())
                    {
                        listBox1.Items.Add((dr["ProductName"].ToString()));
                    }
                }
                dr.Close();
                sqlcon.Close();
            }
            catch
            {
                MetroFramework.MetroMessageBox.Show(this, "A Connection to the Database could not be Made!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
                string Command = "SELECT ProductName, ProductType, ProductDescription, ProductQuantityInStock, ProductImage, ProductPrice FROM Products WHERE ProductName ='" + listBox1.Text.ToString() + "'";
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
                        txtQuantity.Text = Convert.ToString((dr["ProductQuantityInStock"]));
                        txtPrice.Text = (dr["ProductPrice"].ToString());
                    }
                }
                dr.Close();
                sqlcon.Close();
                btnAddToBasket.Enabled = true;
            }
            catch
            {
                MetroFramework.MetroMessageBox.Show(this, "An Error Occurred Whilst Retrieving your Product Information!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private static readonly Random getrandom = new Random();
        private static readonly object syncLock = new object();
        public static int GetRandomNumber(int min, int max)
        {
            lock (syncLock)
            { // synchronize
                return getrandom.Next(min, max);
            }
        }

        private void btnAddToBasket_Click(object sender, EventArgs e)
        {
            if (txtQuantityPurchased.Text == "" || txtName.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "Not all information Required has been Provided!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    //Variables
                    string ItemName = txtName.Text;
                    int Quantity = Convert.ToInt32(txtQuantityPurchased.Text);
                    decimal productPrice = Convert.ToDecimal(txtPrice.Text);
                    decimal LinePrice = Quantity * productPrice;
                    
                    int UniqueNumber = GetRandomNumber(1, 999999999); 

                    //Insert Into Basket
                    SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
                    sqlcon.Open();
                    string cmd = "INSERT INTO Basket(ItemName, ItemQuantity, LinePrice, uniqueNumber) VALUES(@ItemName, @ItemQuantity, @LinePrice, @UniqueNumber)";
                    SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
                    sqlcom.Parameters.Add(new SqlParameter("@ItemName", ItemName));
                    sqlcom.Parameters.Add(new SqlParameter("@ItemQuantity", Quantity));
                    sqlcom.Parameters.Add(new SqlParameter("@LinePrice", LinePrice));
                    sqlcom.Parameters.Add(new SqlParameter("@UniqueNumber", UniqueNumber));
                    sqlcom.ExecuteNonQuery();
                    sqlcon.Close();

                    

                    
                    this.dataGridView1.Rows.Add(ItemName, Quantity.ToString(), LinePrice.ToString());
                    btnCaptureSale.Enabled = true;


                    txtQuantityPurchased.Text = "";
                    

                }
                catch
                {
                    MetroFramework.MetroMessageBox.Show(this, "An Error Occurred Whilst Capturing your Sale Information!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }



        }

        private void btnCaptureSale_Click(object sender, EventArgs e)
        {
            try
            {

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {


                    SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
                    sqlcon.Open();
                    string Command = "INSERT INTO Sales(ItemName, ItemQuantity, LinePrice) VALUES(@ItemName, @ItemQuantity, @LinePrice)";
                    SqlCommand sqlcom = new SqlCommand(Command, sqlcon);
                    sqlcom.Parameters.AddWithValue("@ItemName", row.Cells["colItemName"].Value);
                    sqlcom.Parameters.AddWithValue("@ItemQuantity", row.Cells["colItemQuantity"].Value);
                    sqlcom.Parameters.AddWithValue("@LinePrice", row.Cells["colLinePrice"].Value);
                    sqlcom.ExecuteNonQuery();
                    sqlcon.Close();


                }

                MetroFramework.MetroMessageBox.Show(this, "The New Sale was Captured Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                this.dataGridView1.Rows.Clear();

            }
            catch
            {
                MetroFramework.MetroMessageBox.Show(this, "An Error Occurred Whilst Capturing your Sale Information!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.dataGridView1.Rows.Clear();
            }
        }
    }
}
