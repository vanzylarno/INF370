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
    public partial class Update_an_Employee : MetroFramework.Forms.MetroForm
    {
        public Update_an_Employee()
        {
            InitializeComponent();
        }
        int SelectedEmployee;
        string FileLocation;
        string UserName;

        private void Update_an_Employee_Load(object sender, EventArgs e)
        {
            btnAddEmployee.Enabled = false;
            panel2.Enabled = false;
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

        private void metroButton1_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to Update this Employee?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
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
                    }
                }
                reader.Close();
                sqlcon.Close();
                listBox1.Enabled = false;
                txtFilter.Enabled = false;
                panel2.Enabled = true;
                metroButton1.Enabled = false;
            }
        }


        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileLocation = ofd.FileName;
                pictureBox2.Image = Image.FromFile(FileLocation);

                btnAddEmployee.Enabled = true;
            }
        }


        private void cbxEmployeeType_Click(object sender, EventArgs e)
        {
            cbxEmployeeType.Items.Clear();
            SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
            sqlcon.Open();
            string cmd = "SELECT EmployeeTypeDescription FROM EmployeeType";
            SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
            SqlDataReader reader;
            reader = sqlcom.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    cbxEmployeeType.Items.Add(reader["EmployeeTypeDescription"]);
                }
            }
            reader.Close();
            sqlcon.Close();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            if (txtEmployeeName.Text == "" || txtEmployeeSurname.Text == "" || txtEmployeeEmailAddress.Text == "" || txtEmployeePhoneNumber.Text == "" || dtpDOB.Text == "" || txtUserName.Text == "" || cbxEmployeeType.SelectedItem.ToString() == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "Not all Inforamtion required has been provided!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {

                    //Variables
                    string EmployeeName = txtEmployeeName.Text;
                    string EmployeeSurname = txtEmployeeSurname.Text;
                    string EmployeeEmailAddress = txtEmployeeEmailAddress.Text;
                    string EmployeePhoneNumber = txtEmployeePhoneNumber.Text;
                    string EmployeeDOB = dtpDOB.Text;
                    string UserName = metroTextBox1.Text;
                    string EmployeeType = cbxEmployeeType.SelectedItem.ToString();

                    byte[] image = null;
                    FileStream fs = new FileStream(FileLocation, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    image = br.ReadBytes((int)fs.Length);


                    SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
                    sqlcon.Open();
                    string cmd = "UPDATE Employees SET EmployeeType = @EmployeeType, EmployeeName = @EmployeeName, EmployeeSurname = @EmployeeSurname, EmployeeEmailAddress = @EmployeeEmailAddress, EmployeePhoneNumber = @EmployeePhoneNumber, EmployeeDateOfBirth = @EmployeeDateOfBirth, EmployeeImage = @EmployeeImage, UserName = @UserName WHERE EmployeeID ='" + SelectedEmployee.ToString() + "'";
                    SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
                    sqlcom.Parameters.Add(new SqlParameter("@EmployeeType", EmployeeType));
                    sqlcom.Parameters.Add(new SqlParameter("@EmployeeName", EmployeeName));
                    sqlcom.Parameters.Add(new SqlParameter("@EmployeeSurname", EmployeeSurname));
                    sqlcom.Parameters.Add(new SqlParameter("@EmployeeEmailAddress", EmployeeEmailAddress));
                    sqlcom.Parameters.Add(new SqlParameter("@EmployeePhoneNumber", EmployeePhoneNumber));
                    sqlcom.Parameters.Add(new SqlParameter("@EmployeeDateOfBirth", EmployeeDOB));
                    sqlcom.Parameters.Add(new SqlParameter("@EmployeeImage", image));
                    sqlcom.Parameters.Add(new SqlParameter("@UserName", UserName));
                    sqlcom.ExecuteNonQuery();
                    sqlcon.Close();

                    MetroFramework.MetroMessageBox.Show(this, "The Employee was Updated Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);

                    cbxEmployeeType.Text = "";
                    txtEmployeeName.Text = "";
                    txtEmployeeSurname.Text = "";
                    txtEmployeeEmailAddress.Text = "";
                    txtEmployeePhoneNumber.Text = "";
                    dtpDOB.Text = "";
                    txtUserName.Text = "";
                    pictureBox1.Image = null;
                    listBox1.Enabled = true;
                    txtFilter.Enabled = true;
                    panel2.Enabled = false;
                    metroButton1.Enabled = true;

                    // Refresh List
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

                }
                catch
                {
                    MetroFramework.MetroMessageBox.Show(this, "A Connection to the Database could not be Made!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void txtEmployeeEmailAddress_Click(object sender, EventArgs e)
        {

        }

        private void txtEmployeeEmailAddress_TextChanged(object sender, EventArgs e)
        {
            //Find UserName
            SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
            sqlcon.Open();
            string Select = "Select UserName FROM Users WHERE UserEmailAddress LIKE '%" + txtEmployeeEmailAddress.Text + "%'";
            SqlCommand sqlcom = new SqlCommand(Select, sqlcon);
            SqlDataReader dr;
            dr = sqlcom.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    metroTextBox1.Text = (dr["UserName"].ToString());
                    UserName = (dr["UserName"].ToString());
                }
            }
            dr.Close();
            sqlcon.Close();
        }
    }
}
