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
    public partial class Employees_Form : MetroFramework.Forms.MetroForm
    {
        public Employees_Form()
        {
            InitializeComponent();
        }

        private void Employees_Form_Load(object sender, EventArgs e)
        {

        }

        private void AddSupplier_Click(object sender, EventArgs e)
        {
            Add_Employee myform = new Add_Employee();
            myform.ShowDialog();

        }

        private void FindSupplier_Click(object sender, EventArgs e)
        {
            Find_Employee myform = new Find_Employee();
            myform.ShowDialog();
        }

        private void DeleteSupplier_Click(object sender, EventArgs e)
        {
            Delete_a_Employee myform = new Delete_a_Employee();
            myform.ShowDialog();
        }

        private void UpdateSupplier_Click(object sender, EventArgs e)
        {
            Update_an_Employee myform = new Update_an_Employee();
            myform.ShowDialog();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Leave_Form myform = new Leave_Form();
            myform.ShowDialog();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            Evaluate_Salary myform = new Evaluate_Salary();
            myform.ShowDialog();
        }
    }
}
