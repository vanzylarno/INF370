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
    public partial class Delete_a_Employee : MetroFramework.Forms.MetroForm
    {
        public Delete_a_Employee()
        {
            InitializeComponent();
        }
        byte[] image;
        int SelectedEmployee;

        private void Delete_a_Employee_Load(object sender, EventArgs e)
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
                sqlcon.Close();
                image = (byte[])(ds.Tables[0].Rows[0]["EmployeeImage"]);
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

        private void metroButton1_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to Delete this Employee?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(dialog == DialogResult.Yes)
            {
                try
                {
                    SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
                    sqlcon.Open();
                    string Select = "SELECT EmployeeID FROM Employees WHERE EmployeePhoneNumber ='" + txtPhoneNumber.Text + "'";
                    SqlCommand sqlcom = new SqlCommand(Select, sqlcon);
                    SqlDataReader reader;
                    reader = sqlcom.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            SelectedEmployee = Convert.ToInt32((reader["EmployeeID"]));

                            SqlConnection sqlcon2 = new SqlConnection(Globals_Class.ConnectionString);
                            sqlcon2.Open();
                            string Delete = "DELETE FROM Employees WHERE EmployeeID ='" + SelectedEmployee.ToString() + "'";
                            SqlCommand sqlcom2 = new SqlCommand(Delete, sqlcon2);
                            sqlcom2.ExecuteNonQuery();
                            sqlcon2.Close();

                            MetroFramework.MetroMessageBox.Show(this, "Employee Successfully Deleted!", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                        }
                    }
                    reader.Close();
                    sqlcon.Close();


                    listBox1.Items.Clear();
                    SqlConnection sqlcon3 = new SqlConnection(Globals_Class.ConnectionString);
                    sqlcon3.Open();
                    string Select3 = "SELECT EmployeeName FROM Employees";
                    SqlCommand sqlcom3 = new SqlCommand(Select3, sqlcon3);
                    SqlDataReader reader3 = sqlcom3.ExecuteReader();
                    if (reader3.HasRows)
                    {
                        while (reader3.Read())
                        {
                            listBox1.Items.Add(reader3["EmployeeName"].ToString());
                        }
                    }
                    reader3.Close();
                    sqlcon3.Close();

                    txtType.Text = "";
                    txtName.Text = "";
                    txtSurname.Text = "";
                    txtEmailAddress.Text = "";
                    txtPhoneNumber.Text = "";
                    txtDOB.Text = "";
                    txtUserName.Text = "";
                    pictureBox1.Image = null;
                }
                catch
                {
                    MetroFramework.MetroMessageBox.Show(this, "A Connection to the Database could not be Made!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
