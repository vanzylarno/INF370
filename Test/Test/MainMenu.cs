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
            lblHelp.Hide();
            panel2.Enabled = false;
            lbblDetails.Text = "";
            timer1.Start();
            try
            {

                //Load User Image
                SqlConnection sqlcon2 = new SqlConnection(Globals_Class.ConnectionString);
                sqlcon2.Open();
                string Select2 = "SELECT UserImage FROM Users WHERE UserName ='" + Globals_Class.UserName + "'";
                SqlCommand sqlcom2 = new SqlCommand(Select2, sqlcon2);
                SqlDataAdapter da = new SqlDataAdapter(sqlcom2);
                SqlCommandBuilder cmb = new SqlCommandBuilder(da);
                DataSet ds = new DataSet();

                da.Fill(ds);
                sqlcon2.Close();
                byte[] image = (byte[])(ds.Tables[0].Rows[0]["UserImage"]);
                MemoryStream ms = new MemoryStream(image);
                pictureBox1.Image = Image.FromStream(ms);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                ms.Close();
            }
            catch
            {
                pictureBox1.Image = null;
            }
            lblDate.Text = DateTime.Now.ToShortDateString();
            lblUserName.Text = Globals_Class.UserName;
            lblDay.Text = DateTime.Now.DayOfWeek.ToString();


            if (Globals_Class.adminNumber == 1)
            {
                mtAdmin.Enabled = true;
                mtEmployees.Enabled = true;

            }
            else
            {
                mtAdmin.Enabled = false;
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

        private void mtAdmin_Click(object sender, EventArgs e)
        {
            Admin_Features myform = new Admin_Features();
            myform.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }
        private void SuppliersInfo()
        {
            lblHelp.Show();
            lbblDetails.Text = "This Button Opens the Supplier Screen!" + "\n" +
                "Within this Screen you can Add, Delete, Update and Find a Supplier" + "\n" +
                "As well as Send and Receive Supplier Orders";
            
        }

        private void mtSuppliers_MouseHover(object sender, EventArgs e)
        {
            SuppliersInfo();
            
        }
        private void CustomerInfo()
        {
            lblHelp.Show();
            lbblDetails.Text = "This Button Opens the Customers Screen!" + "\n" +
                "Within this Screen you can Add, Delete, Update and Find a Customer" + "\n" +
                "As well as Add a Customer to the Loyalty Program" + "\n" +
                "and Spend the Loyalty Points Earned by the Customer";
        }

        private void metroTile3_MouseHover(object sender, EventArgs e)
        {
            CustomerInfo();
        }
        private void InventoryInfo()
        {
            lblHelp.Show();
            lbblDetails.Text = "This Button Opens the Inventory Screen!" + "\n" +
                "Within this Screen you can Add, Delete, Update and Find a Inventory Items";
        }

        private void mtInventory_MouseHover(object sender, EventArgs e)
        {
            InventoryInfo();
        }
        private void EventsInfo()
        {
            lblHelp.Show();
            lbblDetails.Text = "This Button Opens the Events Screen!" + "\n" +
                "Within this Screen you can Add, Delete, Update and Find a" + "\n" +
                "Wine Tasting or Vineyard Tour, as well as see all the booked Tours" +
                "\n" + " For each Month";
        }

        private void metroTile4_MouseHover(object sender, EventArgs e)
        {
            EventsInfo();
        }

        private void SalesInfo()
        {
            lblHelp.Show();
            lbblDetails.Text = "This Button Opens the Sales Screen!" + "\n" +
                "Within this Screen you can Make and Refund a Sale";
        }

        private void metroTile2_MouseHover(object sender, EventArgs e)
        {
            SalesInfo();
        }
        private void EmployeesInfo()
        {
            lblHelp.Show();
            lbblDetails.Text = "This Button Opens the Employees Screen!" + "\n" +
                "Within this Screen you can Add, Delete, Update and Find an Employee" + "\n" +
                "As well as Schedule Leave and Evaluate their Salaries" + "\n" +
                "However, this form is only accessible by a Manager";
        }

        private void mtEmployees_MouseHover(object sender, EventArgs e)
        {
            EmployeesInfo();
        }
        private void SettingsInfo()
        {
            lblHelp.Show();
            lbblDetails.Text = "This Button Opens the Settings Screen!" + "\n" +
                "Within this Screen you can View and Update your Personal Inforamtion";
        }

        private void mtSettings_MouseHover(object sender, EventArgs e)
        {
            SettingsInfo();
        }

        private void CalculatorInfo()
        {
            lblHelp.Show();
            lbblDetails.Text = "This Button Opens the Calculator Screen!" + "\n" +
                "This Calculator can be used for daily Calculations";
        }

        private void metroTile1_MouseHover(object sender, EventArgs e)
        {
            CalculatorInfo();
        }
        private void AdminInfo()
        {
            lblHelp.Show();
            lbblDetails.Text = "This Button Opens the Admin Screen!" + "\n" +
                "Within this Screen you can Add, Delete, Update and Find a User" + "\n" +
                "As well as Backup and Restore the System" + "\n" +
                "However, this screen is only acessibly by the Administrator";
        }

        private void mtAdmin_MouseHover(object sender, EventArgs e)
        {
            AdminInfo();
        }

        private void LogoutInfo()
        {
            lblHelp.Show();
            lbblDetails.Text = "This Button logs you out of the System!";
        }

        private void mtLogout_MouseHover(object sender, EventArgs e)
        {
            LogoutInfo();
        }

        private void MainMenu_MouseHover(object sender, EventArgs e)
        {
            lblHelp.Hide();
            lbblDetails.Text = "";
        }
    }
}
