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
    public partial class MainMenu : MetroFramework.Forms.MetroForm
    {
        public MainMenu()
        {
            InitializeComponent();
        }
        string EmployeeType;
        private void MainMenu_Load(object sender, EventArgs e)
        {
            lblUserName.Text = Globals_Class.UserName;

            if (Globals_Class.adminNumber == 1)
            {
                btnAdminFeatures.Visible = true;
                mtEmployees.Enabled = true;

            }
            else
            {
                btnAdminFeatures.Visible = false;
                mtEmployees.Enabled = false;
            }
            //Check if admin or Manager
            SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
            sqlcon.Open();
            string Select = "SELECT EmployeeType FROM Employees WHERE UserName ='" + Globals_Class.UserName.ToString() + "'";
            SqlCommand sqlcom = new SqlCommand(Select, sqlcon);
            SqlDataReader dr;
            dr = sqlcom.ExecuteReader();
            if (dr.HasRows)
            {
                while(dr.Read())
                {
                    EmployeeType = (dr["EmployeeType"].ToString());
                    if (EmployeeType == "Manager")
                    {
                        mtEmployees.Enabled = true;
                    }
                    else
                    {
                        mtEmployees.Enabled = false;
                    }
                }
            }
            dr.Close();
            sqlcon.Close();

            

        }

        private void btnAdminFeatures_Click(object sender, EventArgs e)
        {
            Admin_Features myform = new Admin_Features();
            myform.ShowDialog();
        }

        private void mtSuppliers_Click(object sender, EventArgs e)
        {
            Suppliers_Form myform = new Suppliers_Form();
            myform.ShowDialog();
        }

        private void mtLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose(true);
            frmLogin myform = new frmLogin();
            myform.ShowDialog();
        }

        private void mtSettings_Click(object sender, EventArgs e)
        {
            Account_Settings_Form myform = new Account_Settings_Form();
            myform.ShowDialog();
        }

        private void mtInventory_Click(object sender, EventArgs e)
        {
            Inventory_Form myform = new Inventory_Form();
            myform.ShowDialog();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Calculator myform = new Calculator();
            myform.ShowDialog();

        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            Sales_Form myform = new Sales_Form();
            myform.ShowDialog();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            Customer_s_Form myform = new Customer_s_Form();
            myform.ShowDialog();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            Events_Form myform = new Events_Form();
            myform.ShowDialog();
        }

        private void mtEmployees_Click(object sender, EventArgs e)
        {
            Employees_Form myform = new Employees_Form();
            myform.ShowDialog();
        }
    }
}
