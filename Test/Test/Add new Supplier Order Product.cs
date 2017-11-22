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


namespace Test
{
    public partial class Add_new_Supplier_Order_Product : MetroFramework.Forms.MetroForm
    {
        public Add_new_Supplier_Order_Product()
        {
            InitializeComponent();
        }

        private void Add_new_Supplier_Order_Product_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtProductName.Text == "" || metroTextBox1.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "Not all information required was provided!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    string ProductName = txtProductName.Text;
                    string Description = metroTextBox1.Text;
                    SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
                    sqlcon.Open();
                    string Command = "INSERT INTO SupplierOrderProduct(SupplierOrderProductName, SupplierOrderProductDescription) VALUES(@SupplierOrderProductName, @SupplierOrderProductDescription)";
                    SqlCommand sqlcom = new SqlCommand(Command, sqlcon);
                    sqlcom.Parameters.Add(new SqlParameter("@SupplierOrderProductName", ProductName));
                    sqlcom.Parameters.Add(new SqlParameter("@SupplierOrderProductDescription", Description));
                    sqlcom.ExecuteNonQuery();
                    sqlcon.Close();
                    MetroFramework.MetroMessageBox.Show(this, "The new Product was added Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtProductName.Text = "";
                    metroTextBox1.Text = "";

                }
                catch
                {
                    MetroFramework.MetroMessageBox.Show(this, "The new Product Could not be made at this time!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
