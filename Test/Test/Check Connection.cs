using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Test
{
    public partial class Check_Connection : MetroFramework.Forms.MetroForm
    {
        public Check_Connection()
        {
            InitializeComponent();
        }

        private void Check_Connection_Load(object sender, EventArgs e)
        {
            lblConnection.Text = "";
            try
            {
                SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
                sqlcon.Open();
                pictureBox1.Image = imageList1.Images[0];
                lblConnection.Text = "Connected!";
                lblConnection.ForeColor = System.Drawing.Color.Green;
                sqlcon.Close();
            }
            catch
            {
                pictureBox1.Image = imageList1.Images[1];
                lblConnection.Text = "Disconnected!";
                lblConnection.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}
