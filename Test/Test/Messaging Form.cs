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
using System.Web;
using System.Net;
using System.Configuration;

using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

using Twilio.TwiML;
using Twilio.AspNet.Mvc;

namespace Test
{
    public partial class Messaging_Form : MetroFramework.Forms.MetroForm
    {
        public Messaging_Form()
        {
            InitializeComponent();
        }

        private void Messaging_Form_Load(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
            sqlcon.Open();
            string cmd = "SELECT ContactName FROM Messaging";
            SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
            SqlDataReader dr;
            dr = sqlcom.ExecuteReader();
            if (dr.HasRows)
            {
                while(dr.Read())
                {
                    cbxName.Items.Add((dr["ContactName"].ToString()));
                }
            }
            dr.Close();
            sqlcon.Close();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            Find_Messaging_Contact myform = new Find_Messaging_Contact();
            myform.ShowDialog();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Add_Messaging_Contact myform = new Add_Messaging_Contact();
            myform.ShowDialog();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            Update_Messaging_Contact myform = new Update_Messaging_Contact();
            myform.ShowDialog();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            Delete_Messaging_Contact myform = new Delete_Messaging_Contact();
            myform.ShowDialog();
        }

        private void cbxName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbxName_Click(object sender, EventArgs e)
        {
            cbxName.Items.Clear();
            SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
            sqlcon.Open();
            string cmd = "SELECT ContactName FROM Messaging";
            SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
            SqlDataReader dr;
            dr = sqlcom.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    cbxName.Items.Add((dr["ContactName"].ToString()));
                }
            }
            dr.Close();
            sqlcon.Close();
        }
        string number;
        private void btnSend_Click(object sender, EventArgs e)
        {
            //get SelectedNumber
            SqlConnection sqlcon = new SqlConnection(Globals_Class.ConnectionString);
            sqlcon.Open();
            string cmd = "SELECT ContactPhoneNumber FROM Messaging WHERE ContactName ='" + cbxName.SelectedItem.ToString() + "'";
            SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
            SqlDataReader r;
            r = sqlcom.ExecuteReader();
            if(r.HasRows)
            {
                while(r.Read())
                {
                    number = (r["ContactPhoneNumber"].ToString());
                }
            }
            r.Close();
            sqlcon.Close();
            try
            {
                var accountSid = "AC8fa1bc1de78fc64d323ea689da67346b";
                var authToken = "7ccbfd7b928baa200850a1c495ea075b";
                TwilioClient.Init(accountSid, authToken);

                var to = new PhoneNumber(number);
                var from = new PhoneNumber("+16314964159");

                var message = MessageResource.Create(
                    to: to,
                    from: from,
                    body: txtBody.Text);

                MetroFramework.MetroMessageBox.Show(this, "Message Sent Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                txtBody.Text = "";
                cbxName.Text = "";
            }
            catch
            {
                MetroFramework.MetroMessageBox.Show(this, "Message could not be Sent!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
