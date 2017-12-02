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
    public partial class Vineyard_Tours_Form : MetroFramework.Forms.MetroForm
    {
        public Vineyard_Tours_Form()
        {
            InitializeComponent();
        }

        private void Vineyard_Tours_Form_Load(object sender, EventArgs e)
        {

        }

        private void DeleteSupplier_Click(object sender, EventArgs e)
        {
            Delete_VineyardTour myform = new Delete_VineyardTour();
            myform.ShowDialog();
        }

        private void AddSupplier_Click(object sender, EventArgs e)
        {
            Add_VineyardTour myform = new Add_VineyardTour();
            myform.ShowDialog();
        }

        private void UpdateSupplier_Click(object sender, EventArgs e)
        {
            Update_a_VineyardTour myform = new Update_a_VineyardTour();
            myform.ShowDialog();
        }

        private void FindSupplier_Click(object sender, EventArgs e)
        {
            Find_a_VineyardTour myform = new Find_a_VineyardTour();
            myform.ShowDialog();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            VineyardTours_Booked myform = new VineyardTours_Booked();
            myform.ShowDialog();
        }
    }
}
