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
    public partial class Reports_Form : MetroFramework.Forms.MetroForm
    {
        public Reports_Form()
        {
            InitializeComponent();
        }

        private void Reports_Form_Load(object sender, EventArgs e)
        {

        }

        private void mtInventory_Click(object sender, EventArgs e)
        {
            Inventory_Report_Page myform = new Inventory_Report_Page();
            myform.ShowDialog();
        }

        private void mtSuppliers_Click(object sender, EventArgs e)
        {
            Suppliers_Report_Form myform = new Suppliers_Report_Form();
            myform.ShowDialog();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            Customers_Report_Page myform = new Customers_Report_Page();
            myform.ShowDialog();
        }

        private void AddSupplier_Click(object sender, EventArgs e)
        {
            Wine_Tasting_Report_Page myform = new Wine_Tasting_Report_Page();
            myform.ShowDialog();
        }
    }
}
