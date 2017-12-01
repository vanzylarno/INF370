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
    public partial class Wine_Tasting_Form : MetroFramework.Forms.MetroForm
    {
        public Wine_Tasting_Form()
        {
            InitializeComponent();
        }

        private void Wine_Tasting_Form_Load(object sender, EventArgs e)
        {

        }

        private void AddSupplier_Click(object sender, EventArgs e)
        {
            Add_Wine_Tasting myform = new Add_Wine_Tasting();
            myform.ShowDialog();

        }

        private void UpdateSupplier_Click(object sender, EventArgs e)
        {
            Update_a_Wine_Tasting myform = new Update_a_Wine_Tasting();
            myform.ShowDialog();
        }

        private void DeleteSupplier_Click(object sender, EventArgs e)
        {
            Delete_a_Wine_Tasting myform = new Delete_a_Wine_Tasting();
            myform.ShowDialog();
        }

        private void FindSupplier_Click(object sender, EventArgs e)
        {
            Find_Wine_Tasting myform = new Find_Wine_Tasting();
            myform.ShowDialog();

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Wine_Tastings_Booked myform = new Wine_Tastings_Booked();
            myform.ShowDialog();
        }
    }
}
