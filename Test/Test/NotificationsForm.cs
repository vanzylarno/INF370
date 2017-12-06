using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace Test
{
    public partial class NotificationsForm : MetroFramework.Forms.MetroForm
    {
        public NotificationsForm()
        {
            InitializeComponent();
        }

        private void NotificationsForm_Load(object sender, EventArgs e)
        {

        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            Add_Notification myform = new Add_Notification();
            myform.ShowDialog();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Update_Notification myform = new Update_Notification();
            myform.ShowDialog();

        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            Delete_Notification myform = new Delete_Notification();
            myform.ShowDialog();
        }
    }
}
