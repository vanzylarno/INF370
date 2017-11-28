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
    public partial class Delete_a_Inventory_product : MetroFramework.Forms.MetroForm
    {
        public Delete_a_Inventory_product()
        {
            InitializeComponent();
        }

        private void Delete_a_Inventory_product_Load(object sender, EventArgs e)
        {
          
            SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
            sqlcon.Open();
            string Query = "SELECT ProductName FROM Products";
            SqlCommand sqlcom = new SqlCommand(Query, sqlcon);
            SqlDataReader dr;
            dr = sqlcom.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    listBox1.Items.Add((dr["ProductName"].ToString()));
                }
            }
            dr.Close();
            sqlcon.Close();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
            sqlcon.Open();
            string Query = "SELECT ProductName FROM Products WHERE ProductName LIKE '" + txtFilter.Text + "%'";
            SqlCommand sqlcom = new SqlCommand(Query, sqlcon);
            SqlDataReader dr;
            dr = sqlcom.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    listBox1.Items.Add(dr["ProductName"].ToString());
                }
            }
            sqlcon.Close();
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to delete this Product?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
                sqlcon.Open();
                string Command = "DELETE FROM Products WHERE ProductName ='" + listBox1.Text.ToString() + "'";
                SqlCommand sqlcom = new SqlCommand(Command, sqlcon);
                sqlcom.ExecuteNonQuery();
                MetroFramework.MetroMessageBox.Show(this, "The Product is Successfully Deleted!", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);

                listBox1.Items.Clear();
                SqlConnection sqlcon1 = new SqlConnection(Globals_Class.ConnectionString);
                sqlcon1.Open();
                string Query1 = "SELECT ProductName FROM Products";
                SqlCommand sqlcom1 = new SqlCommand(Query1, sqlcon1);
                SqlDataReader dr1;
                dr1 = sqlcom1.ExecuteReader();

                if (dr1.HasRows)
                {
                    while (dr1.Read())
                    {
                        listBox1.Items.Add(dr1["ProductName"].ToString());
                    }
                }
                sqlcon1.Close();
            }
        }

        private void txtFilter_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
