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
    public partial class Add_Employee : MetroFramework.Forms.MetroForm
    {
        public Add_Employee()
        {
            InitializeComponent();
        }

        string UserName;
        string FileLocation;
        string SelectedEmployeeType;
        

        private void Add_Employee_Load(object sender, EventArgs e)
        {
            btnAddEmployee.Enabled = false;
            txtUserName.Enabled = false;
            SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
            sqlcon.Open();
            string cmd = "SELECT EmployeeTypeDescription FROM EmployeeType";
            SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
            SqlDataReader reader;
            reader = sqlcom.ExecuteReader();
                if (reader.HasRows)
            {
                while(reader.Read())
                {
                    cbxEmployeeType.Items.Add(reader["EmployeeTypeDescription"]);
                }
            }
            reader.Close();
            sqlcon.Close();
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
                    txtUserName.Text = (dr["UserName"].ToString());
                    UserName = (dr["UserName"].ToString());
                }
            }
            dr.Close();
            sqlcon.Close();
        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileLocation = ofd.FileName;
                pictureBox1.Image = Image.FromFile(FileLocation);
                
                btnAddEmployee.Enabled = true;
            }
        }
        private void cbxEmployeeType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void cbxEmployeeType_TabIndexChanged(object sender, EventArgs e)
        {

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
            if (txtEmployeeName.Text == "" || txtEmployeeSurname.Text == "" || txtEmployeeEmailAddress.Text == "" || txtEmployeePhoneNumber.Text == "" || dtpDOB.Text == "" || txtUserName.Text == "" || cbxEmployeeType.SelectedItem.ToString() == "" )
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
                    string UserName = txtUserName.Text;
                    string EmployeeType = cbxEmployeeType.SelectedItem.ToString();
                    int onLeave = 0;
                    string LeaveStart = "";
                    string LeaveEnd = "";

                    byte[] image = null;
                    FileStream fs = new FileStream(FileLocation, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    image = br.ReadBytes((int)fs.Length);
            
                    
                    SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
                    sqlcon.Open();
                    string cmd = "INSERT INTO Employees(EmployeeType, EmployeeName, EmployeeSurname, EmployeeEmailAddress, EmployeePhoneNumber, EmployeeDateOfBirth, EmployeeImage, UserName, isOnLeave, LeaveStart, LeaveEnd) VALUES(@EmployeeType, @EmployeeName, @EmployeeSurname, @EmployeeEmailAddress, @EmployeePhoneNumber, @EmployeeDateOfBirth, @EmployeeImage, @UserName, @isOnLeave, @LeaveStart, @LeaveEnd)";
                    SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
                    sqlcom.Parameters.Add(new SqlParameter("@EmployeeType", EmployeeType));
                    sqlcom.Parameters.Add(new SqlParameter("@EmployeeName", EmployeeName));
                    sqlcom.Parameters.Add(new SqlParameter("@EmployeeSurname", EmployeeSurname));
                    sqlcom.Parameters.Add(new SqlParameter("@EmployeeEmailAddress", EmployeeEmailAddress));
                    sqlcom.Parameters.Add(new SqlParameter("@EmployeePhoneNumber", EmployeePhoneNumber));
                    sqlcom.Parameters.Add(new SqlParameter("@EmployeeDateOfBirth", EmployeeDOB));
                    sqlcom.Parameters.Add(new SqlParameter("@EmployeeImage", image));
                    sqlcom.Parameters.Add(new SqlParameter("@UserName", UserName));
                    sqlcom.Parameters.Add(new SqlParameter("@isOnLeave", onLeave));
                    sqlcom.Parameters.Add(new SqlParameter("@LeaveStart", LeaveStart));
                    sqlcom.Parameters.Add(new SqlParameter("@LeaveEnd", LeaveEnd));
                    sqlcom.ExecuteNonQuery();
                    sqlcon.Close();

                    MetroFramework.MetroMessageBox.Show(this, "New Employee Added Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);

                    cbxEmployeeType.Text = "";
                    txtEmployeeName.Text = "";
                    txtEmployeeSurname.Text = "";
                    txtEmployeeEmailAddress.Text = "";
                    txtEmployeePhoneNumber.Text = "";
                    dtpDOB.Text = "";
                    txtUserName.Text = "";
                    pictureBox1.Image = null;
                }
                catch
                {
                    MetroFramework.MetroMessageBox.Show(this, "A Connection to the Database could not be Made!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void lblHelp_Click(object sender, EventArgs e)
        {
            Add_Employee_Type myform = new Add_Employee_Type();
            myform.ShowDialog();
        }

        private void txtEmployeeEmailAddress_Click(object sender, EventArgs e)
        {

        }
    }
}
