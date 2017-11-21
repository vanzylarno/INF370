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
    public partial class Add_Supplier_Form : MetroFramework.Forms.MetroForm
    {
        public Add_Supplier_Form()
        {
            InitializeComponent();
        }

        private void Add_Supplier_Form_Load(object sender, EventArgs e)
        {
            btnAddSupplier.Enabled = false;
        }
        string ImageLocation;
        private void btnFindImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                ImageLocation = ofd.FileName;
                pictureBox1.Image = Image.FromFile(ImageLocation);
                btnAddSupplier.Enabled = true;
            }
        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            if (txtAddress.Text == "" || txtEmailAddress.Text == "" || txtSupplierName.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "Not All Information Required was Provided!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //Variables
                byte[] SupplierImage = null;
                FileStream fs = new FileStream(ImageLocation, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                SupplierImage = br.ReadBytes((int)fs.Length);
                string SupplierName = txtSupplierName.Text;
                string SupplierAddress = txtAddress.Text;
                string SupplierEmailAddress = txtEmailAddress.Text;

                try
                {
                    SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
                    sqlcon.Open();
                    string Command = "INSERT INTO SupplierInforamtion(SupplierName, SupplierAddress, SupplierEmailAddress, SupplierImage) VALUES(@SupplierName, @SupplierAddress, @SupplierEmailAddress, @SupplierImage)";
                    SqlCommand sqlcom = new SqlCommand(Command, sqlcon);
                    sqlcom.Parameters.Add(new SqlParameter("@SupplierName", SupplierName));
                    sqlcom.Parameters.Add(new SqlParameter("@SupplierAddress", SupplierAddress));
                    sqlcom.Parameters.Add(new SqlParameter("@SupplierEmailAddress", SupplierEmailAddress));
                    sqlcom.Parameters.Add(new SqlParameter("@SupplierImage", SupplierImage));
                    sqlcom.ExecuteNonQuery();
                    sqlcon.Close();

                    MetroFramework.MetroMessageBox.Show(this, "New Supplier Added Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);

                    txtAddress.Text = "";
                    txtEmailAddress.Text = "";
                    txtSupplierName.Text = "";
                    ImageLocation = "";

                }
                catch
                {
                    MetroFramework.MetroMessageBox.Show(this, "An Error Occurred whilst Adding a New Supplier!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
