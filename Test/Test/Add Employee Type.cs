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
    public partial class Add_Employee_Type : MetroFramework.Forms.MetroForm
    {
        public Add_Employee_Type()
        {
            InitializeComponent();
        }

        private void Add_Employee_Type_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (metroTextBox1.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "Not All inforamtion required has been provided!", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                try
                {
                    string EmployeeTypeDescription = metroTextBox1.Text;
                    SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
                    sqlcon.Open();
                    string cmd = "INSERT INTO EmployeeType(EmployeeTypeDescription) VALUES(@EmployeeTypeDescription)";
                    SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
                    sqlcom.Parameters.Add(new SqlParameter("@EmployeeTypeDescription", EmployeeTypeDescription));
                    sqlcom.ExecuteNonQuery();
                    sqlcon.Close();

                    MetroFramework.MetroMessageBox.Show(this, "New Employee type added Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                    metroTextBox1.Text = "";
                }
                catch
                {
                    MetroFramework.MetroMessageBox.Show(this, "A Connection to the Database could not be made!", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
        }
    }
}
