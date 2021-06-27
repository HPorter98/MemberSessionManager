using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MemberSessionApp
{
    public partial class MemberForm : Form
    {
        Member selectedMember;
        Session selectedSession;
        public MemberForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ToggleEdit();
        }

        private void MemberForm_Load(object sender, EventArgs e)
        {
            txtID.Text = selectedMember.ID.ToString();
            txtFirstName.Text = selectedMember.FirstName;
            txtLastName.Text = selectedMember.LastName;
            txtAddress.Text = selectedMember.Address;
            txtPostcode.Text = selectedMember.PostCode;
            txtContact.Text = selectedMember.ContactNum;
            txtEmgContact.Text = selectedMember.EmergencyNum;
            txtDay.Text = selectedMember.startYear.Day.ToString();
            txtMonth.Text = selectedMember.startYear.Month.ToString();
            txtYear.Text = selectedMember.startYear.Year.ToString();
        }

        private void ToggleEdit()
        {
            //Toggle all text boxes to allow their value to be changed
            if (txtFirstName.Enabled == false && txtLastName.Enabled == false && txtAddress.Enabled == false
                && txtPostcode.Enabled == false && txtContact.Enabled == false && txtEmgContact.Enabled == false
                && btnSave.Visible == false)
            {
                txtFirstName.Enabled = true;
                txtLastName.Enabled = true;
                txtAddress.Enabled = true;
                txtPostcode.Enabled = true;
                txtContact.Enabled = true;
                txtEmgContact.Enabled = true;
                txtDay.Enabled = true;
                txtMonth.Enabled = true;
                txtYear.Enabled = true;
                btnSave.Visible = true;
                btnEdit.Text = "Cancel";
            }
            else
            {
                txtFirstName.Enabled = false;
                txtLastName.Enabled = false;
                txtAddress.Enabled = false;
                txtPostcode.Enabled = false;
                txtContact.Enabled = false;
                txtEmgContact.Enabled = false;
                txtDay.Enabled = false;
                txtMonth.Enabled = false;
                txtYear.Enabled = false;
                btnSave.Visible = false;
                btnEdit.Text = "Edit";
            }
        }

        public Member Member
        {
            get { return selectedMember; }
            set { selectedMember = value; }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Retrieve todays date
            string dateString = DateTime.Now.ToString("yyyy-MM-dd");
            //Prepare query

            string query = "insert into mSessions(sessionID, sessionType, sessionDate, sessionTime, memberID) " +
                           "values (@sessionID, @sessionType, @date, @time, @memberID);";
            try
            {
                //connect to database
                using (SqlConnection connection = new SqlConnection(Helper.ConVal("Members")))
                {
                    connection.Open();
                    MessageBox.Show("Connected");
                    //Execute insert query
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        //bind parameters to the query string
                        cmd.Parameters.Add("@sessionID", SqlDbType.VarChar).Value = cmboSession.SelectedItem.ToString() +"/"+ dateString;
                        cmd.Parameters.Add("@sessionType", SqlDbType.VarChar).Value = cmboSession.SelectedItem.ToString();
                        cmd.Parameters.Add("@date", SqlDbType.VarChar).Value = dateString;
                        cmd.Parameters.Add("@time", SqlDbType.VarChar).Value = DateTime.Now.ToShortTimeString();
                        cmd.Parameters.Add("@memberID", SqlDbType.Int).Value = int.Parse(txtID.Text);

                        int rowsAdded = cmd.ExecuteNonQuery();
                        //Check if any rows have been added
                        if (rowsAdded > 0)
                        {
                            MessageBox.Show("Member added");
                        }
                        else
                        {
                            MessageBox.Show("Error");
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Can not connect to database");
            }





            //selectedMember.sessionStart = DateTime.Now;
            //this.DialogResult = DialogResult.OK;
            //this.Close();
        }

        
    }
}
