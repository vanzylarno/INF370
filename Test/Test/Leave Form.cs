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
    public partial class Leave_Form : MetroFramework.Forms.MetroForm
    {
        public Leave_Form()
        {
            InitializeComponent();
        }

        int IsOnLeave;

        private void Leave_Form_Load(object sender, EventArgs e)
        {
            txtStart.Enabled = false;
            txtEnd.Enabled = false;
            panel1.Enabled = false;
            btnReturn.Enabled = false;

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

        private void listBox1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
                sqlcon.Open();
                string Select = "SELECT isOnLeave, LeaveStart, LeaveEnd FROM Employees WHERE EmployeeName ='" + listBox1.Text.ToString() + "'";
                SqlCommand sqlcom = new SqlCommand(Select, sqlcon);
                SqlDataReader r;
                r = sqlcom.ExecuteReader();
                if (r.HasRows)
                {
                    while (r.Read())
                    {
                        IsOnLeave = Convert.ToInt32((r["isOnLeave"]));
                        txtStart.Text = (r["LeaveStart"].ToString());
                        txtEnd.Text = (r["LeaveEnd"].ToString());

                        if (IsOnLeave == 1)
                        {
                            panel1.Enabled = false;
                            pictureBox1.Image = imageList1.Images[0];
                            btnReturn.Enabled = true;
                        }
                        else
                        {
                            panel1.Enabled = true;
                            pictureBox1.Image = imageList1.Images[1];
                            btnReturn.Enabled = false;
                        }
                    }
                }
                r.Close();
                sqlcon.Close();
            }
            catch
            {

            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            //Variables
            int GoingOnLeave = 1;
            string Start = dtpStart.Text;
            string End = dtpEnd.Text;

            SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
            sqlcon.Open();
            string Command = "Update Employees SET isOnLeave = @isOnLeave, LeaveStart = @LeaveStart, LeaveEnd = @LeaveEnd WHERE EmployeeName ='" + listBox1.Text.ToString() + "'";
            SqlCommand sqlcom = new SqlCommand(Command, sqlcon);
            sqlcom.Parameters.Add(new SqlParameter("@isOnLeave", GoingOnLeave));
            sqlcom.Parameters.Add(new SqlParameter("@LeaveStart", Start));
            sqlcom.Parameters.Add(new SqlParameter("@LeaveEnd", End));
            sqlcom.ExecuteNonQuery();
            sqlcon.Close();

            MetroFramework.MetroMessageBox.Show(this, "Employee Leave Scheduled Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);

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
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            int GoingOnLeave = 0;
            string Start = "";
            string End = "";

            SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
            sqlcon.Open();
            string Command = "Update Employees SET isOnLeave = @isOnLeave, LeaveStart = @LeaveStart, LeaveEnd = @LeaveEnd WHERE EmployeeName ='" + listBox1.Text.ToString() + "'";
            SqlCommand sqlcom = new SqlCommand(Command, sqlcon);
            sqlcom.Parameters.Add(new SqlParameter("@isOnLeave", GoingOnLeave));
            sqlcom.Parameters.Add(new SqlParameter("@LeaveStart", Start));
            sqlcom.Parameters.Add(new SqlParameter("@LeaveEnd", End));
            sqlcom.ExecuteNonQuery();
            sqlcon.Close();

            MetroFramework.MetroMessageBox.Show(this, "Employee Returned Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);

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
        }
    }
}
