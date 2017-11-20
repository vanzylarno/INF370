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
    public partial class Update_Account_Information_Form : MetroFramework.Forms.MetroForm
    {

        SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
        string ImageLocation = "";

        public Update_Account_Information_Form()
        {
            InitializeComponent();
        }

        private void Update_Account_Information_Form_Load(object sender, EventArgs e)
        {

            btnUpdate.Enabled = false;
        }

        private void btnProfileImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JPG Files (*.jpg)|*.jpg| GIF Files (*.gif)|*.gif| All Files (*.*)|*.*";
            ofd.Title = "Select a Profile Image";
            if (ofd.ShowDialog() == DialogResult.OK)
            { 
                ImageLocation = ofd.FileName.ToString();
                pictureBox1.ImageLocation = ImageLocation;
                btnUpdate.Enabled = true;
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "An incorrect Image Tipe was Selected!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }




       
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "" || txtSecurityQuestion.Text == "" || txtSecurityQuestionAnswer.Text == "" || txtEmailAddress.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "Not All information Required was Provided!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    byte[] img = null;
                    FileStream fs = new FileStream(ImageLocation, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    img = br.ReadBytes((int)fs.Length);

                    string Query = "UPDATE Users SET UserName ='" + txtUsername.Text + "', UserPassword ='" + txtPassword.Text + "', UserSecurityQuestion ='" + txtSecurityQuestion.Text + "', UserSecurityQuestionAnswer ='" + txtSecurityQuestionAnswer.Text + "', UserEmailAddress ='" + txtEmailAddress.Text + "', UserImage =@img WHERE UserID ='" + Globals_Class.UserID + "'";
                    sqlcon.Open();
                    SqlCommand command = new SqlCommand(Query, sqlcon);
                    command.Parameters.Add(new SqlParameter("@img", img));
                    int x = command.ExecuteNonQuery();
                    sqlcon.Close();
                    DialogResult DR = MetroFramework.MetroMessageBox.Show(this, "The Account was Updated Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                    if (DR == DialogResult.OK)
                    {

                       Application.Restart();
                    }
                    else
                    {
                        Application.Restart();
                    }


                }
                catch
                {
                   DialogResult DR = MetroFramework.MetroMessageBox.Show(this, "The Account Could not be Updated at this time!", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                    if (DR == DialogResult.OK)
                    {
                        Application.Restart();
                    }
                    else
                    {
                        Application.Restart();
                    }
                    
                }
            }
        }
    }


    }

