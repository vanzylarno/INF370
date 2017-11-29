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
    public partial class Sales_Form : MetroFramework.Forms.MetroForm
    {
        public Sales_Form()
        {
            InitializeComponent();
        }

        private void Sales_Form_Load(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Make_a_New_Sale myform = new Make_a_New_Sale();
            myform.ShowDialog();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            Refund_Sale myform = new Refund_Sale();
            myform.ShowDialog();
        }
    }
}
