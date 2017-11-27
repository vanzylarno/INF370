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
    public partial class Update_a_User : MetroFramework.Forms.MetroForm
    {
        public Update_a_User()
        {
            InitializeComponent();
        }
        string FileLocation;
        int ChosenUserID;

        private void Update_a_User_Load(object sender, EventArgs e)
        {
            btnUpdate.Enabled = false;
            panel1.Hide();
            SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
            sqlcon.Open();
            string CMD = "SELECT UserName FROM Users";
            SqlCommand sqlcom = new SqlCommand(CMD, sqlcon);
            SqlDataReader Reader;
            Reader = sqlcom.ExecuteReader();

            if (Reader.HasRows)
            {
                while (Reader.Read())
                {
                    listBox1.Items.Add(Reader["UserName"].ToString());
                }
            }
            Reader.Close();
            sqlcon.Close();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
            sqlcon.Open();
            string CMD = "SELECT UserName FROM Users WHERE UserEmailAddress LIKE '" + txtFilter.Text + "%'";
            SqlCommand sqlcom = new SqlCommand(CMD, sqlcon);
            SqlDataReader Reader;
            Reader = sqlcom.ExecuteReader();

            if (Reader.HasRows)
            {
                while (Reader.Read())
                {
                    listBox1.Items.Add(Reader["UserName"].ToString());
                }
            }
            Reader.Close();
            sqlcon.Close();
        }

        private void txtFilter_Click(object sender, EventArgs e)
        {

        }


        private void listBox1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to update this User?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                panel1.Show();
                listBox1.Enabled = false;
                txtFilter.Enabled = false;
                SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
                sqlcon.Open();
                string cmd = "SELECT UserID From Users WHERE UserName ='" + listBox1.Text.ToString() + "'";
                SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
                SqlDataReader Reader;
                Reader = sqlcom.ExecuteReader();

                if (Reader.HasRows)
                {
                    while (Reader.Read())
                    {
                        ChosenUserID = Convert.ToInt32((Reader["UserID"]));
                    }
                }
            }
        }
        private void metroButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileLocation = ofd.FileName;
                pictureBox1.Image = Image.FromFile(FileLocation);
                btnUpdate.Enabled = true;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "" || txtPassword.Text == "" || txtSecurityQ.Text == "" || txtSecurityQuestionAnswer.Text == "" || txtEmailAddress.Text == "" || FileLocation == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "Not All required Information was Provided!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    string Username = txtUserName.Text;
                    string password = txtPassword.Text;
                    string SQ = txtSecurityQ.Text;
                    string SQA = txtSecurityQuestionAnswer.Text;
                    string Email = txtEmailAddress.Text;
                    byte[] image = null;

                    FileStream fs = new FileStream(FileLocation, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    image = br.ReadBytes((int)fs.Length);

                    SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
                    sqlcon.Open();
                    string Command = "UPDATE Users SET UserName =@UserName, UserPassword =@UserPassword, UserSecurityQuestion =@UserSecurityQuestion, UserSecurityQuestionAnswer = @UserSecurityQuestionAnswer, UserEmailAddress = @UserEmailAddress, UserImage = @UserImage WHERE UserID ='" + ChosenUserID + "'";
                    SqlCommand sqlcom = new SqlCommand(Command, sqlcon);
                    sqlcom.Parameters.Add(new SqlParameter("@UserName", Username));
                    sqlcom.Parameters.Add(new SqlParameter("@UserPassword", password));
                    sqlcom.Parameters.Add(new SqlParameter("@UserSecurityQuestion", SQ));
                    sqlcom.Parameters.Add(new SqlParameter("@UserSecurityQuestionAnswer", SQA));
                    sqlcom.Parameters.Add(new SqlParameter("@UserEmailAddress", Email));
                    sqlcom.Parameters.Add(new SqlParameter("@UserImage", image));

                    sqlcom.ExecuteNonQuery();
                    MetroFramework.MetroMessageBox.Show(this, "The User Instance was Updated Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    txtUserName.Text = "";
                    txtSecurityQuestionAnswer.Text = "";
                    txtSecurityQ.Text = "";
                    txtPassword.Text = "";
                    txtEmailAddress.Text = "";
                    FileLocation = "";
                    ChosenUserID = 0;
                    pictureBox1.Image = null;
                    btnUpdate.Enabled = false;
                    panel1.Hide();
                    listBox1.Enabled = true;
                    txtFilter.Enabled = true;
                    listBox1.Items.Clear();

                   
                    SqlConnection sqlcon1 = new SqlConnection(Globals_Class.ConnectionString);
                    sqlcon1.Open();
                    string CMD1 = "SELECT UserName FROM Users";
                    SqlCommand sqlcom1 = new SqlCommand(CMD1, sqlcon1);
                    SqlDataReader Reader1;
                    Reader1 = sqlcom1.ExecuteReader();

                    if (Reader1.HasRows)
                    {
                        while (Reader1.Read())
                        {
                            listBox1.Items.Add(Reader1["UserName"].ToString());
                        }
                    }
                    Reader1.Close();
                    sqlcon1.Close();


                }
                catch
                {
                    MetroFramework.MetroMessageBox.Show(this, "An Error Occurred Whilst Updating The User!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
