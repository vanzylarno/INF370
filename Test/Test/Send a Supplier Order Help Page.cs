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
    public partial class Send_a_Supplier_Order_Help_Page : MetroFramework.Forms.MetroForm
    {
        public Send_a_Supplier_Order_Help_Page()
        {
            InitializeComponent();
        }

        private void Send_a_Supplier_Order_Help_Page_Load(object sender, EventArgs e)
        {

        }

        private void AddSupplier_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose(true);
            Add_Supplier_Form myfrom = new Add_Supplier_Form();
            myfrom.ShowDialog();

            
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose(true);
            Add_new_Supplier_Order_Product myform = new Add_new_Supplier_Order_Product();
            myform.ShowDialog();
        }
    }
}
