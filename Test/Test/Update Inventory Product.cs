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
    public partial class Update_Inventory_Product : MetroFramework.Forms.MetroForm
    {
        public Update_Inventory_Product()
        {
            InitializeComponent();
        }
        string FileLocation;
        int ChosenProductID;

        private void Update_Inventory_Product_Load(object sender, EventArgs e)
        {
            panel1.Hide();
            btnUpdate.Enabled = false;
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to update this Product?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
                sqlcon.Open();
                string Command = "SELECT ProductID FROM Products WHERE ProductName ='" + listBox1.Text.ToString() + "'";
                SqlCommand sqlcom = new SqlCommand(Command, sqlcon);
                SqlDataReader dr;
                dr = sqlcom.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        ChosenProductID = Convert.ToInt32((dr["ProductID"]));
                        panel1.Show();
                        listBox1.Enabled = false;
                        txtFilter.Enabled = false;
                    }
                }
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileLocation = ofd.FileName;
                btnUpdate.Enabled = true;
                pictureBox1.Image = Image.FromFile(FileLocation);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtProductName.Text == "" || txtProductType.Text == "" || txtProductQuantity.Text == "" || txtDescription.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "Not all information required has been provided!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string Name = txtProductName.Text;
                string Type = txtProductType.Text;
                string Description = txtDescription.Text;
                int Quantity = Convert.ToInt32(txtProductQuantity.Text);
                byte[] image = null;
                FileStream fs = new FileStream(FileLocation, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                image = br.ReadBytes((int)fs.Length);
                decimal ProductPrice = Convert.ToDecimal(txtPrice.Text);

                SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
                sqlcon.Open();
                string Command = "UPDATE Products SET ProductName = @ProductName, ProductType = @ProductType, ProductDescription = @ProductDescription, ProductQuantityInStock = @ProductQuantity, ProductImage = @ProductImage, ProductPrice = @ProductPrice";
                SqlCommand sqlcom = new SqlCommand(Command, sqlcon);
                sqlcom.Parameters.Add(new SqlParameter("@ProductName", Name));
                sqlcom.Parameters.Add(new SqlParameter("@ProductType", Type));
                sqlcom.Parameters.Add(new SqlParameter("@ProductDescription", Description));
                sqlcom.Parameters.Add(new SqlParameter("@ProductQuantity", Quantity));
                sqlcom.Parameters.Add(new SqlParameter("@ProductImage", image));
                sqlcom.Parameters.Add(new SqlParameter("@ProductPrice", ProductPrice));
                sqlcom.ExecuteNonQuery();

                MetroFramework.MetroMessageBox.Show(this, "The Product Inforamtion has been Updated Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtProductQuantity.Text = "";
                txtProductType.Text = "";
                txtProductName.Text = "";
                txtDescription.Text = "";
                FileLocation = "";
                txtPrice.Text = "";
                ChosenProductID = 0;

                panel1.Hide();
                listBox1.Items.Clear();
                btnUpdate.Enabled = false;
                SqlConnection sqlcon1 = new SqlConnection(Globals_Class.ConnectionString);
                sqlcon1.Open();
                string Query1 = "SELECT ProductName FROM Products";
                SqlCommand sqlcom1 = new SqlCommand(Query1, sqlcon1);
                SqlDataReader dr1;
                dr1 = sqlcom1.ExecuteReader();
                if (dr1.HasRows)
                {
                    while (dr1.Read())
                    {
                        listBox1.Items.Add((dr1["ProductName"].ToString()));
                    }
                }
                dr1.Close();
                sqlcon1.Close();
                listBox1.Enabled = true;
                txtFilter.Enabled = true;



            }
        }
    }
}
