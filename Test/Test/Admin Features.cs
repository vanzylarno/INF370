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

namespace Test
{
    public partial class Admin_Features : MetroFramework.Forms.MetroForm
    {
        public Admin_Features()
        {
            InitializeComponent();
        }

        private void Admin_Features_Load(object sender, EventArgs e)
        {

        }


        private void metroTile5_Click(object sender, EventArgs e)
        {
            Database_Backup_Form myform = new Database_Backup_Form();
            myform.ShowDialog();
        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            Restore_Database_Form myform = new Restore_Database_Form();
            myform.ShowDialog();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Add_new_User myform = new Add_new_User();
            myform.ShowDialog();

        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            Find_a_User myform = new Find_a_User();
            myform.ShowDialog();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            Delete_a_User myform = new Delete_a_User();
            myform.ShowDialog();

        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            Update_a_User myform = new Update_a_User();
            myform.ShowDialog();
        }
    }
}

