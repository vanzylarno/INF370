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
    public partial class Evaluate_Salary : MetroFramework.Forms.MetroForm
    {
        public Evaluate_Salary()
        {
            InitializeComponent();
        }
        int SelectedEmployee;

        private void Evaluate_Salary_Load(object sender, EventArgs e)
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
            panel2.Enabled = false;
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
                        SelectedEmployee = Convert.ToInt32((reader["EmployeeID"]));
                        txtAmount.Text = (reader["SalaryAmount"].ToString());
                        txtBonus.Text = (reader["SalaryBonus"].ToString());
                        txtInterval.Text = (reader["SalaryPaymentInterval"].ToString());
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
                byte[] image = (byte[])(ds.Tables[0].Rows[0]["EmployeeImage"]);
                MemoryStream ms = new MemoryStream(image);
                pictureBox1.Image = Image.FromStream(ms);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                ms.Close();
                panel2.Enabled = true;
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
                        SelectedEmployee = Convert.ToInt32((reader["EmployeeID"]));
                        txtAmount.Text = (reader["SalaryAmount"].ToString());
                        txtBonus.Text = (reader["SalaryBonus"].ToString());
                        txtInterval.Text = (reader["SalaryPaymentInterval"].ToString());
                    }
                }
                reader.Close();
                sqlcon.Close();
                panel2.Enabled = true;
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
            if (txtSAmount.Text == "" || txtSBonus.Text == "" || cbxInterval.SelectedItem.ToString() == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "Not All information required has been Provided!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            { 
            DialogResult dialog = MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to update this Employee's Salary?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialog == DialogResult.Yes)
                {
                    try
                   {
                        //Variables
                        decimal SalaryAmount = Convert.ToDecimal(txtSAmount.Text);
                        string Date = cbxInterval.SelectedItem.ToString();
                        decimal Bonus = Convert.ToDecimal(txtSBonus.Text);

                        SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
                        sqlcon.Open();
                        string cmd = "Update Employees Set SalaryAmount =@SalaryAmount, SalaryPaymentInterval =@SalaryPaymentInterval, SalaryBonus =@SalaryBonus WHERE EmployeeID ='" + SelectedEmployee.ToString() + "'";
                        SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
                        sqlcom.Parameters.Add(new SqlParameter("@SalaryAmount", SalaryAmount));
                        sqlcom.Parameters.Add(new SqlParameter("@SalaryPaymentInterval", Date));
                        sqlcom.Parameters.Add(new SqlParameter("@SalaryBonus", Bonus));
                        sqlcom.ExecuteNonQuery();
                        sqlcon.Close();

                        MetroFramework.MetroMessageBox.Show(this, "The Employee's Salary has been updated Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);


                        listBox1.Items.Clear();

                        SqlConnection sqlcon2 = new SqlConnection(Globals_Class.ConnectionString);
                        sqlcon2.Open();
                        string Select2 = "SELECT EmployeeName FROM Employees";
                        SqlCommand sqlcom2 = new SqlCommand(Select2, sqlcon2);
                        SqlDataReader reader2 = sqlcom2.ExecuteReader();
                        if (reader2.HasRows)
                        {
                            while (reader2.Read())
                            {
                                listBox1.Items.Add(reader2["EmployeeName"].ToString());
                            }
                        }
                        reader2.Close();
                        sqlcon2.Close();
                        panel2.Enabled = false;
                        txtSAmount.Text = "";
                        txtSBonus.Text = "";
                        cbxInterval.SelectedItem = "";
                        

                    }
                    catch
                    {
                        MetroFramework.MetroMessageBox.Show(this, "A Connection to the Database Could not be Made!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                   }
                }
            }
        }
    }
}
