using System;
using FluentValidation;
using FluentValidation.Results;
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
        public MemberForm()
        {
            InitializeComponent();
        }

        public Member Member
        {
            get { return selectedMember; }
            set { selectedMember = value; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FillValues();
            ToggleEdit();
        }

        private void MemberForm_Load(object sender, EventArgs e)
        {
            FillValues();
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

                btnSave.Visible = true;
                btnDelete.Visible = true;

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

                btnSave.Visible = false;
                btnDelete.Visible = false;

                btnEdit.Text = "Edit";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Retrieve todays date
            string dateString = DateTime.Now.ToString("yyyy-MM-dd");

            if (cmboSession.SelectedIndex < 0)
            {
                MessageBox.Show("Select Session Type!");
            }
            else
            {
                string sessionID = cmboSession.SelectedItem.ToString() + "/" + dateString;
                
                //Prepare query
                string query = "Select SessionID from SessionDetails WHERE SessionID = @sessionID;";
                try
                {
                    bool result;
                    //connect to database
                    using (SqlConnection connection = new SqlConnection(Helper.ConVal("Members")))
                    {
                        connection.Open();

                        SqlCommand cmd = new SqlCommand(query, connection);
                        cmd.Parameters.Add("@sessionID", SqlDbType.VarChar).Value = sessionID;
                        SqlDataReader reader = cmd.ExecuteReader();
                        result = reader.HasRows;
                        reader.Close();


                        if (result)
                        {
                            //Add member to a session
                            AddMemberToSession(connection, sessionID);
                            this.DialogResult = DialogResult.OK;
                            this.Dispose();
                        }
                        else
                        {
                            //Create new session and add member to new session
                            CreateSession(connection, sessionID, dateString);
                            AddMemberToSession(connection, sessionID);
                            this.DialogResult = DialogResult.OK;
                            this.Dispose();
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Can not connect to database");
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Reset error hints
            ResetHints();

            //Update the selected members values
            selectedMember.FirstName = txtFirstName.Text;
            selectedMember.LastName = txtLastName.Text;
            selectedMember.Address = txtAddress.Text;
            selectedMember.PostCode = txtPostcode.Text;
            selectedMember.ContactNum = txtContact.Text;
            selectedMember.EmergencyNum = txtEmgContact.Text;

            //Validate the selected members new values
            PersonValidation validator = new PersonValidation();
            ValidationResult result = validator.Validate(selectedMember);

            //Check if results are valid
            if (!result.IsValid)
            {
                foreach (ValidationFailure f in result.Errors)
                {
                    if (f.PropertyName == "FirstName")
                    {
                        lblfNameError.Text = f.ErrorMessage;
                        lblfNameError.Visible = true;
                        lblfNameError.ForeColor = Color.Red;
                    }
                    if (f.PropertyName == "LastName")
                    {
                        lbllNameError.Text = f.ErrorMessage;
                        lbllNameError.Visible = true;
                        lbllNameError.ForeColor = Color.Red;
                    }
                    if (f.PropertyName == "Address")
                    {
                        lblAddressError.Text = f.ErrorMessage;
                        lblAddressError.Visible = true;
                        lblAddressError.ForeColor = Color.Red;
                    }
                    if (f.PropertyName == "PostCode")
                    {
                        lblPostcodeError.Text = f.ErrorMessage;
                        lblPostcodeError.Visible = true;
                        lblPostcodeError.ForeColor = Color.Red;
                    }
                    if (f.PropertyName == "ContactNum")
                    {
                        lblContactError.Text = f.ErrorMessage;
                        lblContactError.Visible = true;
                        lblContactError.ForeColor = Color.Red;
                    }
                    if (f.PropertyName == "EmergencyNum")
                    {
                        lblEmgError.Text = f.ErrorMessage;
                        lblEmgError.Visible = true;
                        lblEmgError.ForeColor = Color.Red;
                    }
                }
            }
            else
            {
                UpdateMember();               
            }

        }

        private void UpdateMember()
        {
            //Prepare query
            string query = "UPDATE Members SET LastName = @lName, FirstName = @fName, HomeAddress = @address," +
                            " PostCode = @postCode, ContactNum = @contact, EmergencyContact = @emg WHERE PersonID = @id";
            try
            {
                //connect to database
                using (SqlConnection connection = new SqlConnection(Helper.ConVal("Members")))
                {
                    connection.Open();
                    //Execute insert query
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        //bind parameters to the query string
                        cmd.Parameters.Add("@lName", SqlDbType.VarChar).Value = txtLastName.Text;
                        cmd.Parameters.Add("@fName", SqlDbType.VarChar).Value = txtFirstName.Text;
                        cmd.Parameters.Add("@address", SqlDbType.VarChar).Value = txtAddress.Text;
                        cmd.Parameters.Add("@postCode", SqlDbType.VarChar).Value = txtPostcode.Text;
                        cmd.Parameters.Add("@contact", SqlDbType.VarChar).Value = txtContact.Text;
                        cmd.Parameters.Add("@emg", SqlDbType.VarChar).Value = txtEmgContact.Text;
                        cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = txtID.Text;
                        //cmd.Parameters.Add("@year", SqlDbType.VarChar).Value = dateString;

                        int rowsAdded = cmd.ExecuteNonQuery();
                        //Check if any rows have been added
                        if (rowsAdded > 0)
                        {
                            MessageBox.Show("Member updated");
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
        }

        private void ResetHints()
        {
            lblfNameError.Visible = false;
            lbllNameError.Visible = false;
            lblAddressError.Visible = false;
            lblPostcodeError.Visible = false;
            lblContactError.Visible = false;
            lblEmgError.Visible = false;
        }

        private void FillValues()
        {
            txtID.Text = selectedMember.ID.ToString();
            txtFirstName.Text = selectedMember.FirstName;
            txtLastName.Text = selectedMember.LastName;
            txtAddress.Text = selectedMember.Address;
            txtPostcode.Text = selectedMember.PostCode;
            txtContact.Text = selectedMember.ContactNum;
            txtEmgContact.Text = selectedMember.EmergencyNum;
            dateStartYear.Value = selectedMember.startYear;
        }
    
        private void AddMemberToSession(SqlConnection connection, string sessionID)
        {
            string query = "INSERT INTO MemberSession(SessionID, PersonID, FirstName, LastName) VALUES (@id, @memberID, @fName, @lName);";
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                //Bind parameters to query
                cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = sessionID;
                cmd.Parameters.Add("@memberID", SqlDbType.Int).Value = int.Parse(txtID.Text);
                cmd.Parameters.Add("@fName", SqlDbType.VarChar).Value = txtFirstName.Text;
                cmd.Parameters.Add("@lName", SqlDbType.VarChar).Value = txtLastName.Text;

                //Store and check if any rows were effected
                int rowsAdded = cmd.ExecuteNonQuery();
                if (rowsAdded > 0)
                {
                    MessageBox.Show("Member added to session");
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private void CreateSession(SqlConnection connection, string sessionID, string dateString)
        {
            string query = "INSERT INTO SessionDetails (SessionID, SessionStartTime, SessionEndTime, SessionDate, SessionType) VALUES (@id, @start, @end, @date, @type);";
            using (SqlCommand createSession = new SqlCommand(query, connection))
            {
                //Bind parameters to query
                createSession.Parameters.Add("@id", SqlDbType.VarChar).Value = sessionID;
                createSession.Parameters.Add("@start", SqlDbType.VarChar).Value = DateTime.Now.ToShortTimeString();
                createSession.Parameters.Add("@end", SqlDbType.VarChar).Value = DateTime.Now.AddHours(2).ToShortTimeString();
                createSession.Parameters.Add("@date", SqlDbType.VarChar).Value = dateString;
                createSession.Parameters.Add("@type", SqlDbType.VarChar).Value = cmboSession.SelectedItem.ToString();

                //Store number of rows affected by the query
                int rowsAdded = createSession.ExecuteNonQuery();

                if (rowsAdded > 0)
                {//If rows effected is greater than 0
                    MessageBox.Show("Session created");
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(txtID.Text);
            //int sum = int.Parse(txtID.Text) + 7;
            //MessageBox.Show(sum.ToString());

            //Does not delete cause it is a primary key. Conflicts with member session
            string query = $"DELETE FROM Members WHERE PersonID = {int.Parse(txtID.Text)}";
            using (SqlConnection connection = new SqlConnection(Helper.ConVal("Members")))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();

                int rowsDeleted = command.ExecuteNonQuery();

                if (rowsDeleted > 0)
                {
                    MessageBox.Show("Member removed");
                    this.DialogResult = DialogResult.OK;
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
        }
    }
}
