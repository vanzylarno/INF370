using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class MainMenu : MetroFramework.Forms.MetroForm
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            lblUserName.Text = Globals_Class.UserName;

            if (Globals_Class.adminNumber == 1)
            {
                btnAdminFeatures.Visible = true;
               
            }
            else
            {
                btnAdminFeatures.Visible = false;
            }
            
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
    }
}
