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
    public partial class CaptureNewSupplierOrder : MetroFramework.Forms.MetroForm
    {
        public CaptureNewSupplierOrder()
        {
            InitializeComponent();
        }

        private void CaptureNewSupplierOrder_Load(object sender, EventArgs e)
        {
            txtSupplierName.Enabled = false;
            txtSupplierAddress.Enabled = false;
            txtSupplierEmail.Enabled = false;

            //Populate CBX

            SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
            sqlcon.Open();
            string Select = "SELECT * FROM SupplierInforamtion";
            SqlCommand sqlcom = new SqlCommand(Select, sqlcon);
            SqlDataReader SDA;
            SDA = sqlcom.ExecuteReader();

            while (SDA.Read())
            {
                cbxSuppliers.Items.Add(SDA[2]);
            }


        }

        private void cbxSuppliers_SelectedIndexChanged(object sender, EventArgs e)
        {


            //Populate txtboxes
            SqlConnection sqlcon1 = new SqlConnection(Globals_Class.ConnectionString);
            sqlcon1.Open();
            string selectName = "SELECT * FROM SupplierInforamtion WHERE SupplierName='" + cbxSuppliers.Text + "'";
            SqlCommand sqlcom1 = new SqlCommand(selectName, sqlcon1);
            SqlDataReader SDA1;
            SDA1 = sqlcom1.ExecuteReader();

            while (SDA1.Read())
            {
                string SupplierName = (SDA1["SupplierName"].ToString());
                string SupplierAddress = (SDA1["SupplierAddress"].ToString());
                string SupplierEmailAddress = (SDA1["SupplierEmailAddress"].ToString());

                txtSupplierName.Text = SupplierName;
                txtSupplierAddress.Text = SupplierAddress;
                txtSupplierEmail.Text = SupplierEmailAddress;

                //Populate DGV

                SqlConnection sqlCon2 = new SqlConnection(Globals_Class.ConnectionString);
                sqlCon2.Open();
                string Command2 = "SELECT * FROM SupplierOrder";
                SqlCommand sqlCom2 = new SqlCommand(Command2, sqlCon2);
                SqlDataAdapter sda2 = new SqlDataAdapter(Command2, sqlCon2);

                SqlCommandBuilder commanBuilder2 = new SqlCommandBuilder(sda2);
                DataSet DS2 = new DataSet();
                sda2.Fill(DS2);
                dgvOrders.ReadOnly = true;
                dgvOrders.DataSource = DS2.Tables[0];

            }
        }
    }
}
