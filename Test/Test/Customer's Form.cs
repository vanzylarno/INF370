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
    public partial class Customer_s_Form : MetroFramework.Forms.MetroForm
    {
        public Customer_s_Form()
        {
            InitializeComponent();
        }

        private void Customer_s_Form_Load(object sender, EventArgs e)
        {

        }

        private void AddSupplier_Click(object sender, EventArgs e)
        {
            Add_New_Customer myform = new Add_New_Customer();
            myform.ShowDialog();
        }

        private void UpdateSupplier_Click(object sender, EventArgs e)
        {
            Update_Customer myform = new Update_Customer();
            myform.ShowDialog();

        }

        private void FindSupplier_Click(object sender, EventArgs e)
        {
            Find_a_Customer myform = new Find_a_Customer();
            myform.ShowDialog();
        }

        private void DeleteSupplier_Click(object sender, EventArgs e)
        {
            Delete_a_Customer myform = new Delete_a_Customer();
            myform.ShowDialog();

        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            Loyalty_Program myform = new Loyalty_Program();
            myform.ShowDialog();

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            View_Points_Available myform = new View_Points_Available();
            myform.ShowDialog();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            Use_Loyalty_Points myform = new Use_Loyalty_Points();
            myform.ShowDialog();
        }
    }
}
