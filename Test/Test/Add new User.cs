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
    public partial class Add_new_User : MetroFramework.Forms.MetroForm
    {
        string FileLocation;
        public Add_new_User()
        {
            InitializeComponent();
        }

        private void Add_new_User_Load(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileLocation = ofd.FileName;
                pictureBox1.Image = Image.FromFile(FileLocation);
                btnAdd.Enabled = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "" || txtEmailAddress.Text == "" || txtSecurityQuestion.Text == "" || txtSecurityQuestionAnswer.Text == "" || FileLocation == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "Not all inforamtion required has been provided!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    string UserName = txtUsername.Text;
                    string Password = txtPassword.Text;
                    string SQ = txtSecurityQuestion.Text;
                    string SQA = txtSecurityQuestionAnswer.Text;
                    string Email = txtEmailAddress.Text;
                    byte[] image = null;

                    FileStream fs = new FileStream(FileLocation, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    image = br.ReadBytes((int)fs.Length);

                    SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
                    sqlcon.Open();
                    string CMD = "INSERT INTO Users(UserName, UserPassword, UserSecurityQuestion, UserSecurityQuestionAnswer, UserEmailAddress, UserImage) VALUES(@UserName, @UserPassword, @UserSecurityQuestion, @UserSecurityQuestionAnswer, @UserEmailAddress, @UserImage)";
                    SqlCommand sqlcom = new SqlCommand(CMD, sqlcon);
                    sqlcom.Parameters.Add(new SqlParameter("@UserName", UserName));
                    sqlcom.Parameters.Add(new SqlParameter("@UserPassword", Password));
                    sqlcom.Parameters.Add(new SqlParameter("@UserSecurityQuestion", SQ));
                    sqlcom.Parameters.Add(new SqlParameter("@UserSecurityQuestionAnswer", SQA));
                    sqlcom.Parameters.Add(new SqlParameter("@UserEmailAddress", Email));
                    sqlcom.Parameters.Add(new SqlParameter("@UserImage", image));
                    sqlcom.ExecuteNonQuery();

                    MetroFramework.MetroMessageBox.Show(this, "The New User Instance was Added Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    txtSecurityQuestion.Text = "";
                    txtSecurityQuestionAnswer.Text = "";
                    txtEmailAddress.Text = "";
                    FileLocation = "";
                    pictureBox1.Image = null;
                    btnAdd.Enabled = false;


                }
                catch
                {
                    MetroFramework.MetroMessageBox.Show(this, "An Error Occurred whilst Adding the New User Instance!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            
        }
    }
}
