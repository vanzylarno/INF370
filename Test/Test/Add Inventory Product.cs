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
    public partial class Add_Inventory_Product : MetroFramework.Forms.MetroForm
    {
        public Add_Inventory_Product()
        {
            InitializeComponent();
        }
        string FileLocation;
        private void Add_Inventory_Product_Load(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
        }

        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileLocation = ofd.FileName;
                btnAdd.Enabled = true;
                pictureBox1.Image = Image.FromFile(FileLocation);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtProductName.Text == "" || txtProductType.Text == "" || txtQuantity.Text == "" || txtDescription.Text == "" || FileLocation == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "Not all information required has been provided!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {

                    string productName = txtProductName.Text;
                    string ProductType = txtProductType.Text;
                    string ProductDescription = txtDescription.Text;
                    int Quantity = Convert.ToInt32(txtQuantity.Text);
                    byte[] image = null;
                    FileStream fs = new FileStream(FileLocation, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    image = br.ReadBytes((int)fs.Length);

                    SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
                    sqlcon.Open();
                    string Insert = "INSERT INTO Products(ProductName, ProductType, ProductDescription, ProductQuantity, ProductImage) VALUES(@ProductName, @ProductType, @ProductDescription, @ProductQuantity, @ProductImage)";
                    SqlCommand sqlcom = new SqlCommand(Insert, sqlcon);
                    sqlcom.Parameters.Add(new SqlParameter("@ProductName", productName));
                    sqlcom.Parameters.Add(new SqlParameter("@ProductType", ProductType));
                    sqlcom.Parameters.Add(new SqlParameter("@ProductDescription", ProductDescription));
                    sqlcom.Parameters.Add(new SqlParameter("@ProductQuantity", Quantity));
                    sqlcom.Parameters.Add(new SqlParameter("@ProductImage", image));
                    sqlcom.ExecuteNonQuery();

                    MetroFramework.MetroMessageBox.Show(this, "The New Product was Added Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtProductName.Text = "";
                    txtDescription.Text = "";
                    txtProductType.Text = "";
                    txtQuantity.Text = "";
                    FileLocation = "";
                    btnAdd.Enabled = false;

                }
                catch
                {

                    MetroFramework.MetroMessageBox.Show(this, "An Error Occurred Whislt Adding the New Product!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
