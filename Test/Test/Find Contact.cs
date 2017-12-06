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
    public partial class Find_Contact : MetroFramework.Forms.MetroForm
    {
        public Find_Contact()
        {
            InitializeComponent();
        }

        private void Find_Contact_Load(object sender, EventArgs e)
        {
            txtEmail.Enabled = false;
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
            sqlcon.Open();
            string cmd = "SELECT EmailAddress FROM EmailContacts WHERE ContactName LIKE '%" + txtFilter.Text + "%'";
            SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
            SqlDataReader dr;
            dr = sqlcom.ExecuteReader();
            if(dr.HasRows)
            {
                while(dr.Read())
                {
                    txtEmail.Text = (dr["EmailAddress"].ToString());
                }
            }
            dr.Close();
            sqlcon.Close();
        }
    }
}
