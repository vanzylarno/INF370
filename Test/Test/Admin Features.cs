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
    public partial class Admin_Features : MetroFramework.Forms.MetroForm
    {
        public Admin_Features()
        {
            InitializeComponent();
        }

        private void Admin_Features_Load(object sender, EventArgs e)
        {

        }

        private void dgvSelected_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnViewUsers_Click(object sender, EventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(Globals_Class.ConnectionString);
            sqlCon.Open();
            string Command = "SELECT * FROM Users";
            SqlCommand sqlCom = new SqlCommand(Command, sqlCon);
            SqlDataAdapter sda = new SqlDataAdapter(Command, sqlCon);

            SqlCommandBuilder commanBuilder = new SqlCommandBuilder(sda);
            DataSet DS = new DataSet();
            sda.Fill(DS);
            dgvSelected.ReadOnly = true;
            dgvSelected.DataSource = DS.Tables[0];


        }

        private void btnCreateNewUSer_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtUserPassword.Text == "" || txtUserSecurityQuestion.Text == "" || txtUserSecurityQuestionAnswer.Text == "" || txtUserEmailAddress.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "Not all fields provided have been filled out!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtUsername.Text == "admin" || txtUserPassword.Text == "admin")
            {
                MetroFramework.MetroMessageBox.Show(this, "Invalid Information was Given!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Text = "";
                txtUserPassword.Text = "";
                txtUserSecurityQuestion.Text = "";
                txtUserSecurityQuestionAnswer.Text = "";
                txtUserEmailAddress.Text = "";
            }
            else
            {
                try
                {
                    string Username = txtUsername.Text;
                    string Password = txtUserPassword.Text;
                    string SecurityQuestion = txtUserSecurityQuestion.Text;
                    string SecurityQuestionAnswer = txtUserSecurityQuestionAnswer.Text;
                    string EmailAddress = txtUserEmailAddress.Text;

                    SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
                    string InsertQuery = "INSERT INTO Users(Username, UserPassword, UserSecurityQuestion, UserSecurityQuestionAnswer, UserEmailAddress) VALUES(@Username, @UserPassword, @UserSecurityQuestion, @UserSecurityQuestionAnswer, @UserEmailAddress)";
                    SqlCommand sqlCom = new SqlCommand(InsertQuery, sqlcon);
                    sqlCom.Parameters.AddWithValue("@Username", Username);
                    sqlCom.Parameters.AddWithValue("@UserPassword", Password);
                    sqlCom.Parameters.AddWithValue("@UserSecurityQuestion", SecurityQuestion);
                    sqlCom.Parameters.AddWithValue("@UserSecurityQuestionAnswer", SecurityQuestionAnswer);
                    sqlCom.Parameters.AddWithValue("@UserEmailAddress", EmailAddress);

                    sqlcon.Open();
                    sqlCom.ExecuteNonQuery();
                    sqlcon.Close();

                    MetroFramework.MetroMessageBox.Show(this, "The new Account was Created Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);


                    //Refresh

                    SqlConnection sqlCon1 = new SqlConnection(Globals_Class.ConnectionString);
                    sqlCon1.Open();
                    string Command1 = "SELECT * FROM Users";
                    SqlCommand sqlCom1 = new SqlCommand(Command1, sqlCon1);
                    SqlDataAdapter sda1 = new SqlDataAdapter(Command1, sqlCon1);

                    SqlCommandBuilder commanBuilder1 = new SqlCommandBuilder(sda1);
                    DataSet DS1 = new DataSet();
                    sda1.Fill(DS1);
                    dgvSelected.ReadOnly = true;
                    dgvSelected.DataSource = DS1.Tables[0];

                    txtUsername.Text = "";
                    txtUserPassword.Text = "";
                    txtUserSecurityQuestion.Text = "";
                    txtUserSecurityQuestionAnswer.Text = "";
                    txtUserEmailAddress.Text = "";

                }
                catch
                {
                    MetroFramework.MetroMessageBox.Show(this, "An Error has occurred while Creating a New Account!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    txtUsername.Text = "";
                    txtUserPassword.Text = "";
                    txtUserSecurityQuestion.Text = "";
                    txtUserSecurityQuestionAnswer.Text = "";
                    txtUserEmailAddress.Text = "";
                }

            }
        }
        int indexRow;
        string UserID;
        
        private void dgvSelected_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            indexRow = e.RowIndex; // get the selected Row Index
            DataGridViewRow row = dgvSelected.Rows[indexRow];
            UserID = row.Cells[0].Value.ToString();
           
        }
       

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            int isAdmin = Convert.ToInt32(UserID);

            if (txtUsername.Text == "" || txtUserPassword.Text == "" || txtUserSecurityQuestion.Text == "" || txtUserSecurityQuestionAnswer.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "Not All Information Required for Update has been provided!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (isAdmin == 1)
            {
                MetroFramework.MetroMessageBox.Show(this, "The Admin Account Cannot be Updated!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult dialogueResult = MetroFramework.MetroMessageBox.Show(this, "The Selected User Instance Will be Updated to the New Information, Are you sure of this Action?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogueResult == DialogResult.Yes)
                {
                    try
                    {
                        SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
                        sqlcon.Open();

                        string Query = "UPDATE Users SET UserName ='" + txtUsername.Text + "', UserPassword ='" + txtUserPassword.Text + "', UserSecurityQuestion ='" + txtUserSecurityQuestion.Text + "', UserSecurityQuestionAnswer ='" + txtUserSecurityQuestionAnswer.Text + "', UserEmailAddress ='" + txtUserEmailAddress.Text + "' WHERE UserID ='" + Convert.ToInt32(UserID) + "'";
                        SqlCommand sqlcmd = new SqlCommand(Query, sqlcon);
                        sqlcmd.ExecuteNonQuery();
                        sqlcon.Close();

                        MetroFramework.MetroMessageBox.Show(this, "The User Information was Updated Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        //Refresh

                        SqlConnection sqlCon1 = new SqlConnection(Globals_Class.ConnectionString);
                        sqlCon1.Open();
                        string Command1 = "SELECT * FROM Users";
                        SqlCommand sqlCom1 = new SqlCommand(Command1, sqlCon1);
                        SqlDataAdapter sda1 = new SqlDataAdapter(Command1, sqlCon1);

                        SqlCommandBuilder commanBuilder1 = new SqlCommandBuilder(sda1);
                        DataSet DS1 = new DataSet();
                        sda1.Fill(DS1);
                        dgvSelected.ReadOnly = true;
                        dgvSelected.DataSource = DS1.Tables[0];

                        txtUsername.Text = "";
                        txtUserPassword.Text = "";
                        txtUserSecurityQuestion.Text = "";
                        txtUserSecurityQuestionAnswer.Text = "";
                        txtUserEmailAddress.Text = "";
                    }
                    catch
                    {
                        MetroFramework.MetroMessageBox.Show(this, "An Error Occurred Whilst Updating the User Information!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        txtUsername.Text = "";
                        txtUserPassword.Text = "";
                        txtUserSecurityQuestion.Text = "";
                        txtUserSecurityQuestionAnswer.Text = "";
                        txtUserEmailAddress.Text = "";
                    }
                }
                else
                {

                }

            }
        }

        private void btnCreateNewUSer_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            int isAdmin = Convert.ToInt32(UserID);

            if (isAdmin == 1)
            {
                MetroFramework.MetroMessageBox.Show(this, "The Admin Account Cannot be Deleted!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult dialogueResult = MetroFramework.MetroMessageBox.Show(this, "The User selected will be Deleted from the system, are you sure of this action?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogueResult == DialogResult.Yes)
                {
                    try
                    {
                        SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
                        sqlcon.Open();

                        string Query = "DELETE FROM Users WHERE UserID ='" + Convert.ToInt32(UserID) + "'";
                        SqlCommand sqlcmd = new SqlCommand(Query, sqlcon);
                        sqlcmd.ExecuteNonQuery();
                        sqlcon.Close();

                        MetroFramework.MetroMessageBox.Show(this, "The User Information has been Deleted Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        //Refresh

                        SqlConnection sqlCon1 = new SqlConnection(Globals_Class.ConnectionString);
                        sqlCon1.Open();
                        string Command1 = "SELECT * FROM Users";
                        SqlCommand sqlCom1 = new SqlCommand(Command1, sqlCon1);
                        SqlDataAdapter sda1 = new SqlDataAdapter(Command1, sqlCon1);

                        SqlCommandBuilder commanBuilder1 = new SqlCommandBuilder(sda1);
                        DataSet DS1 = new DataSet();
                        sda1.Fill(DS1);
                        dgvSelected.ReadOnly = true;
                        dgvSelected.DataSource = DS1.Tables[0];

                        txtUsername.Text = "";
                        txtUserPassword.Text = "";
                        txtUserSecurityQuestion.Text = "";
                        txtUserSecurityQuestionAnswer.Text = "";
                        txtUserEmailAddress.Text = "";
                    }
                    catch
                    {
                        MetroFramework.MetroMessageBox.Show(this, "An Error has occurred while Deleting the User!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        txtUsername.Text = "";
                        txtUserPassword.Text = "";
                        txtUserSecurityQuestion.Text = "";
                        txtUserSecurityQuestionAnswer.Text = "";
                        txtUserEmailAddress.Text = "";
                    }
                }
                else
                {

                }
            }
        }

        private void btnCreateDatabaseBackup_Click(object sender, EventArgs e)
        {
            Database_Backup_Form myform = new Database_Backup_Form();
            myform.ShowDialog();

        }

        private void btnRestoreDatabase_Click(object sender, EventArgs e)
        {
            Restore_Database_Form myform = new Restore_Database_Form();
            myform.ShowDialog();
        }



    }
}

