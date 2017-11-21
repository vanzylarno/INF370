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


        }

        private void AddSupplier_Click(object sender, EventArgs e)
        {


            Add_Supplier_Form myform = new Add_Supplier_Form();
            myform.ShowDialog();
        }

        private void DeleteSupplier_Click(object sender, EventArgs e)
        {


            Delete_a_Supplier_Form myfrom = new Delete_a_Supplier_Form();
            myfrom.ShowDialog();
        }

        private void UpdateSupplier_Click(object sender, EventArgs e)
        {

            Update_a_Supplier_Form myform = new Update_a_Supplier_Form();
            myform.ShowDialog();
        }

        private void FindSupplier_Click(object sender, EventArgs e)
        {
            Find_A_Supplier_Form myfrom = new Find_A_Supplier_Form();
            myfrom.ShowDialog();
        }

        private void SendOrder_Click(object sender, EventArgs e)
        {
            Send_Supplier_Order myfrom = new Send_Supplier_Order();
            myfrom.ShowDialog();
        }
    }
}
