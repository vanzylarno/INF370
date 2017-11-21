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
    public partial class Delete_a_Supplier_Form : MetroFramework.Forms.MetroForm
    {
        public Delete_a_Supplier_Form()
        {
            InitializeComponent();
        }

        private void Delete_a_Supplier_Form_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            SqlConnection sqlcon1 = new SqlConnection(Globals_Class.ConnectionString);
            sqlcon1.Open();
            string Select = "SELECT SupplierName FROM SupplierInforamtion";
            SqlCommand sqlcom1 = new SqlCommand(Select, sqlcon1);
            SqlDataReader Dr;
            Dr = sqlcom1.ExecuteReader();
            if (Dr.HasRows)
            {
                while (Dr.Read())
                {
                    listBox1.Items.Add(Dr["SupplierName"].ToString());
                }
            }
            Dr.Close();
            sqlcon1.Close();
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
            sqlcon.Open();
            string Query = "SELECT SupplierName FROM SupplierInforamtion WHERE SupplierName LIKE '" + txtSearch.Text + "%'";
            SqlCommand sqlcom = new SqlCommand(Query, sqlcon);
            SqlDataReader dr;
            dr = sqlcom.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    listBox1.Items.Add(dr["SupplierName"].ToString());
                }
            }
            sqlcon.Close();

        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to delete this Supplier?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
                sqlcon.Open();
                string Query = "DELETE FROM SupplierInforamtion WHERE SupplierName='" + listBox1.Text.ToString() + "'";
                SqlCommand sqlcom = new SqlCommand(Query, sqlcon);
                sqlcom.ExecuteNonQuery();
                sqlcon.Close();

                MetroFramework.MetroMessageBox.Show(this, "Supplier Deleted Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                listBox1.Items.Clear();
                SqlConnection sqlcon1 = new SqlConnection(Globals_Class.ConnectionString);
                sqlcon1.Open();
                string Select = "SELECT SupplierName FROM SupplierInforamtion";
                SqlCommand sqlcom1 = new SqlCommand(Select, sqlcon1);
                SqlDataReader Dr;
                Dr = sqlcom1.ExecuteReader();
                if (Dr.HasRows)
                {
                    while (Dr.Read())
                    {
                        listBox1.Items.Add(Dr["SupplierName"].ToString());
                    }
                }
                Dr.Close();
                sqlcon1.Close();

                txtSearch.Text = "";
            }
        }
    }
}

