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
    public partial class Help_Form : MetroFramework.Forms.MetroForm
    {
        public Help_Form()
        {
            InitializeComponent();
        }

        private void Help_Form_Load(object sender, EventArgs e)
        {

        }

        private void mtForgottenPassword_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose(true);
            Find_a_Forgotten_Password_Form myform = new Find_a_Forgotten_Password_Form();
            myform.ShowDialog();

        }

        private void mtFindAForgottenUsername_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose(true);
            Find_a_Forgotten_Username_Form myForm = new Find_a_Forgotten_Username_Form();
            myForm.ShowDialog();

        }

        private void mtCreateANewPassword_Click(object sender, EventArgs e)
        {

            this.Close();
            this.Dispose(true);
            Create_a_New_Password_Form myFom = new Create_a_New_Password_Form();
            myFom.ShowDialog();
        }
    }
}
