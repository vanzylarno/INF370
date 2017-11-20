using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Controls;
using LiveCharts;
using LiveCharts.WinForms;
using LiveCharts.Charts;
using LiveCharts.Configurations;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using System.Data.SqlClient;


namespace Test
{
    public partial class Suppliers_Form : MetroFramework.Forms.MetroForm
    {
        public Suppliers_Form()
        {
            InitializeComponent();

       
        }

        private void Suppliers_Form_Load(object sender, EventArgs e)
        {

            SqlConnection sqlCon = new SqlConnection(Globals_Class.ConnectionString);
            sqlCon.Open();
            string Command = "SELECT * FROM SupplierInforamtion";
            SqlCommand sqlCom = new SqlCommand(Command, sqlCon);
            SqlDataAdapter sda = new SqlDataAdapter(Command, sqlCon);

            SqlCommandBuilder commanBuilder = new SqlCommandBuilder(sda);
            DataSet DS = new DataSet();
            sda.Fill(DS);
            dgvSuppliers.ReadOnly = true;
            dgvSuppliers.DataSource = DS.Tables[0];
        }

        private void pieChart1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddNewSupplier_Click(object sender, EventArgs e)
        {
            if (txtSupplierName.Text == "" || txtSupplierAddress.Text == "" || txtSupplierEmailAddress.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "Please Enter Values into the Fields Provided!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                try
                {
                    SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
                    
                    string Commnand = "INSERT INTO SupplierInforamtion(SupplierName, SupplierAddress, SupplierEmailAddress) VALUES(@SupplierName, @SupplierAddress, @SupplierEmailAddress)";
                    SqlCommand sqlcom = new SqlCommand(Commnand, sqlcon);
                    sqlcom.Parameters.AddWithValue("@SupplierName", txtSupplierName.Text);
                    sqlcom.Parameters.AddWithValue("@SupplierAddress", txtSupplierAddress.Text);
                    sqlcom.Parameters.AddWithValue("@SupplierEmailAddress", txtSupplierEmailAddress.Text);

                    sqlcon.Open();
                    sqlcom.ExecuteNonQuery();
                    sqlcon.Close();

                    MetroFramework.MetroMessageBox.Show(this, "The New Supplier was Added Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);

                    //Refresh

                    SqlConnection sqlCon1 = new SqlConnection(Globals_Class.ConnectionString);
                    sqlCon1.Open();
                    string Command1 = "SELECT * FROM SupplierInforamtion";
                    SqlCommand sqlCom1 = new SqlCommand(Command1, sqlCon1);
                    SqlDataAdapter sda1 = new SqlDataAdapter(Command1, sqlCon1);

                    SqlCommandBuilder commanBuilder1 = new SqlCommandBuilder(sda1);
                    DataSet DS1 = new DataSet();
                    sda1.Fill(DS1);
                    dgvSuppliers.ReadOnly = true;
                    dgvSuppliers.DataSource = DS1.Tables[0];

                    txtSupplierName.Text = "";
                    txtSupplierAddress.Text = "";
                    txtSupplierEmailAddress.Text = "";

                }
                catch
                {
                    MetroFramework.MetroMessageBox.Show(this, "An Error Occurred Whilst Adding the New Supplier!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
        }


        int indexRow;
        string UserID;
        private void dgvSuppliers_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex; // get the selected Row Index
            DataGridViewRow row = dgvSuppliers.Rows[indexRow];
            UserID = row.Cells[0].Value.ToString();
        }

        private void btnUpdateSupplier_Click(object sender, EventArgs e)
        {
            if (txtSNameUpdate.Text == "" || txtSupplierAddressUpdate.Text == "" || txtSupplierEmailUpdate.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "Please Enter Values into the Fields Provided!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                DialogResult dialogueResult = MetroFramework.MetroMessageBox.Show(this, "The Selected Supplier Instance Will be Updated to the New Information, Are you sure of this Action?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogueResult == DialogResult.Yes)
                {
                    try
                    {
                        SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
                        sqlcon.Open();

                        string Query = "UPDATE SupplierInforamtion SET SupplierName ='" + txtSNameUpdate.Text + "', SupplierAddress ='" + txtSupplierAddressUpdate.Text + "', SupplierEmailAddress ='" + txtSupplierEmailUpdate.Text + "' WHERE SupplierID ='" + Convert.ToInt32(UserID) + "'";
                        SqlCommand sqlcmd = new SqlCommand(Query, sqlcon);
                        sqlcmd.ExecuteNonQuery();
                        sqlcon.Close();

                        MetroFramework.MetroMessageBox.Show(this, "The Supplier Information was Updated Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        //Refresh

                        SqlConnection sqlCon1 = new SqlConnection(Globals_Class.ConnectionString);
                        sqlCon1.Open();
                        string Command1 = "SELECT * FROM SupplierInforamtion";
                        SqlCommand sqlCom1 = new SqlCommand(Command1, sqlCon1);
                        SqlDataAdapter sda1 = new SqlDataAdapter(Command1, sqlCon1);

                        SqlCommandBuilder commanBuilder1 = new SqlCommandBuilder(sda1);
                        DataSet DS1 = new DataSet();
                        sda1.Fill(DS1);
                        dgvSuppliers.ReadOnly = true;
                        dgvSuppliers.DataSource = DS1.Tables[0];

                        txtSNameUpdate.Text = "";
                        txtSupplierAddressUpdate.Text = "";
                        txtSupplierEmailUpdate.Text = "";

                    }
                    catch
                    {
                        MetroFramework.MetroMessageBox.Show(this, "An Error Occurred Whilst Updating the Supplier Information!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        txtSNameUpdate.Text = "";
                        txtSupplierAddressUpdate.Text = "";
                        txtSupplierEmailUpdate.Text = "";
                    }
                }
                else
                {

                }
            }

        }

        private void btnDeleteSupplier_Click(object sender, EventArgs e)
        {
            DialogResult dialogueResult = MetroFramework.MetroMessageBox.Show(this, "The Supplier selected will be Deleted from the system, are you sure of this action?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogueResult == DialogResult.Yes)
            {
                try
                {
                    SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
                    sqlcon.Open();

                    string Query = "DELETE FROM SupplierInforamtion WHERE SupplierID ='" + Convert.ToInt32(UserID) + "'";
                    SqlCommand sqlcmd = new SqlCommand(Query, sqlcon);
                    sqlcmd.ExecuteNonQuery();
                    sqlcon.Close();

                    MetroFramework.MetroMessageBox.Show(this, "The Supplier Information has been Deleted Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //Refresh

                    SqlConnection sqlCon1 = new SqlConnection(Globals_Class.ConnectionString);
                    sqlCon1.Open();
                    string Command1 = "SELECT * FROM SupplierInforamtion";
                    SqlCommand sqlCom1 = new SqlCommand(Command1, sqlCon1);
                    SqlDataAdapter sda1 = new SqlDataAdapter(Command1, sqlCon1);

                    SqlCommandBuilder commanBuilder1 = new SqlCommandBuilder(sda1);
                    DataSet DS1 = new DataSet();
                    sda1.Fill(DS1);
                    dgvSuppliers.ReadOnly = true;
                    dgvSuppliers.DataSource = DS1.Tables[0];

                   
                }
                catch
                {
                    MetroFramework.MetroMessageBox.Show(this, "An Error has occurred while Deleting the Supplier!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    
                }
            }
        }

        private void btnCaptureNewOrder_Click(object sender, EventArgs e)
        {
            CaptureNewSupplierOrder myform = new CaptureNewSupplierOrder();
            myform.ShowDialog();
        }
    }
}
