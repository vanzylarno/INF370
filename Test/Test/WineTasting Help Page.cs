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
    public partial class WineTasting_Help_Page : MetroFramework.Forms.MetroForm
    {
        public WineTasting_Help_Page()
        {
            InitializeComponent();
        }

        private void WineTasting_Help_Page_Load(object sender, EventArgs e)
        {

        }

        private void AddSupplier_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose(true);
            Add_New_Customer myform = new Add_New_Customer();
            myform.ShowDialog();
        }

        private void DeleteSupplier_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose(true);
            Delete_a_Customer myform = new Delete_a_Customer();
            myform.ShowDialog();
        }

        private void UpdateSupplier_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose(true);
            Update_Customer myform = new Update_Customer();
            myform.ShowDialog();
        }

        private void FindSupplier_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose(true);
            Find_a_Customer myform = new Find_a_Customer();
            myform.ShowDialog();
        }
    }
}
