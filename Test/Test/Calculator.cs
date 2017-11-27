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
    public partial class Calculator : MetroFramework.Forms.MetroForm
    {

        double value;
        string soperator;
        bool check;

        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }
        private void PNumber(object sender, EventArgs e)
        {
            if ((soperator == "+") || (soperator == "-") || (soperator == "*") || (soperator == "/"))
            {
                if(check)
                {
                    check = false;
                    txtResult.Text = "0";
                    
                }
            }
            Button b = sender as Button;
            if (txtResult.Text == "0")
                txtResult.Text = b.Text;
            else
                txtResult.Text += b.Text;
        }
        private void POperator(object sender, EventArgs e)
        {
            Button b = sender as Button;
            value = double.Parse(txtResult.Text);
            soperator = b.Text;
            txtResult.Text += b.Text;
            check = true;
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            value = 0;
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            try
            {
                switch(soperator)
                {
                    case "+":
                        txtResult.Text = (value + double.Parse(txtResult.Text)).ToString();
                        break;
                    case "-":
                        txtResult.Text = (value - double.Parse(txtResult.Text)).ToString();
                        break;
                    case "*":
                        txtResult.Text = (value * double.Parse(txtResult.Text)).ToString();
                        break;
                    case "/":
                        txtResult.Text = (value / double.Parse(txtResult.Text)).ToString();
                        break;
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
