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
    public partial class Find_Employee : MetroFramework.Forms.MetroForm
    {
        public Find_Employee()
        {
            InitializeComponent();
        }

        private void Find_Employee_Load(object sender, EventArgs e)
        {
            panel1.Enabled = false;
            SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
            sqlcon.Open();
            string Select = "SELECT EmployeeName FROM Employees";
            SqlCommand sqlcom = new SqlCommand(Select, sqlcon);
            SqlDataReader reader = sqlcom.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    listBox1.Items.Add(reader["EmployeeName"].ToString());
                }
            }
            reader.Close();
            sqlcon.Close();
        }

        private void txtFilter_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
                sqlcon.Open();
                string Select = "SELECT * FROM Employees WHERE EmployeeName  ='" + listBox1.Text.ToString() + "'";
                SqlCommand sqlcom = new SqlCommand(Select, sqlcon);
                SqlDataReader reader = sqlcom.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        txtType.Text = (reader["EmployeeType"].ToString());
                        txtName.Text = (reader["EmployeeName"].ToString());
                        txtSurname.Text = (reader["EmployeeSurname"].ToString());
                        txtEmailAddress.Text = (reader["EmployeeEmailAddress"].ToString());
                        txtPhoneNumber.Text = (reader["EmployeePhoneNumber"].ToString());
                        txtDOB.Text = (reader["EmployeeDateOfBirth"].ToString());
                        txtUserName.Text = (reader["UserName"].ToString());
                    }
                }
                reader.Close();
                sqlcon.Close();

                SqlConnection sqlcon2 = new SqlConnection(Globals_Class.ConnectionString);
                sqlcon2.Open();
                string Select2 = "SELECT EmployeeImage FROM Employees WHERE EmployeeName ='" + listBox1.Text.ToString() + "'";
                SqlCommand sqlcom2 = new SqlCommand(Select2, sqlcon2);
                SqlDataAdapter da = new SqlDataAdapter(sqlcom2);
                SqlCommandBuilder cmb = new SqlCommandBuilder(da);
                DataSet ds = new DataSet();

                da.Fill(ds);
                sqlcon2.Close();
                byte[] image = (byte[])(ds.Tables[0].Rows[0]["EmployeeImage"]);
                MemoryStream ms = new MemoryStream(image);
                pictureBox1.Image = Image.FromStream(ms);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                ms.Close();
            }
            catch
            {
                SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
                sqlcon.Open();
                string Select = "SELECT * FROM Employees WHERE EmployeeName  ='" + listBox1.Text.ToString() + "'";
                SqlCommand sqlcom = new SqlCommand(Select, sqlcon);
                SqlDataReader reader = sqlcom.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        txtType.Text = (reader["EmployeeType"].ToString());
                        txtName.Text = (reader["EmployeeName"].ToString());
                        txtSurname.Text = (reader["EmployeeSurname"].ToString());
                        txtEmailAddress.Text = (reader["EmployeeEmailAddress"].ToString());
                        txtPhoneNumber.Text = (reader["EmployeePhoneNumber"].ToString());
                        txtDOB.Text = (reader["EmployeeDateOfBirth"].ToString());
                        txtUserName.Text = (reader["UserName"].ToString());
                    }
                }
                reader.Close();
                sqlcon.Close();
            }

        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
            sqlcon.Open();
            string Select = "SELECT EmployeeName FROM Employees WHERE EmployeeName LIKE '%" + txtFilter.Text + "%'";
            SqlCommand sqlcom = new SqlCommand(Select, sqlcon);
            SqlDataReader reader = sqlcom.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    listBox1.Items.Add(reader["EmployeeName"].ToString());
                }
            }
            reader.Close();
            sqlcon.Close();
        }
    }
}
