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
    public partial class Inventory_Form : MetroFramework.Forms.MetroForm
    {
        public Inventory_Form()
        {
            InitializeComponent();
        }

        private void Inventory_Form_Load(object sender, EventArgs e)
        {

        }

        private void mtAdd_Click(object sender, EventArgs e)
        {
            Add_Inventory_Product myform = new Add_Inventory_Product();
            myform.ShowDialog();
        }

        private void mtDelete_Click(object sender, EventArgs e)
        {
            Delete_a_Inventory_product myform = new Delete_a_Inventory_product();
            myform.ShowDialog();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Find_Inventory_Product myform = new Find_Inventory_Product();
            myform.ShowDialog();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            Update_Inventory_Product myform = new Update_Inventory_Product();
            myform.ShowDialog();
        }

    }
}
