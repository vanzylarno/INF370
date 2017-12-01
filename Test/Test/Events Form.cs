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
    public partial class Events_Form : MetroFramework.Forms.MetroForm
    {
        public Events_Form()
        {
            InitializeComponent();
        }

        private void Events_Form_Load(object sender, EventArgs e)
        {

        }

        private void AddSupplier_Click(object sender, EventArgs e)
        {
            Wine_Tasting_Form myform = new Wine_Tasting_Form();
            myform.ShowDialog();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Vineyard_Tours_Form myform = new Vineyard_Tours_Form();
            myform.ShowDialog();
        }
    }
}
