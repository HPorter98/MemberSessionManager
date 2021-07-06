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
    public partial class AddMember : UserControl
    {
        private Member newMember = new Member();
        public AddMember()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ResetErrorHints();
            //Set new member values
            newMember.FirstName = txtFName.Text;
            newMember.LastName = txtLName.Text;
            newMember.Address = txtAddress.Text;
            newMember.PostCode = txtPostCode.Text;
            newMember.ContactNum = txtContactNum.Text;
            newMember.EmergencyNum = txtEmCon.Text;
            newMember.startYear = DateTime.Now;

            //Validate new member values
            PersonValidation validator = new PersonValidation();
            ValidationResult result = validator.Validate(newMember);

            //Check if result is valid
            if (result.IsValid == false)
            {
                foreach (ValidationFailure f in result.Errors)
                {//Set error messages where appropriate
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
                        lblEmgConError.Text = f.ErrorMessage;
                        lblEmgConError.Visible = true;
                        lblEmgConError.ForeColor = Color.Red;
                    }
                    
                }
            }
            else
            {//If vaild, add member to database and show message
                SaveMember();
                ResetValues();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ResetValues();
            ResetErrorHints();
        }

        private bool DataCheck()
        {
            //validate if all text boxes contain text
            if (txtFName.Text != string.Empty && txtLName.Text != string.Empty && txtAddress.Text != string.Empty && txtPostCode.Text != string.Empty && txtEmCon.Text != string.Empty && txtContactNum.Text != string.Empty)
            {
                if (txtContactNum.Text.Length < 11)
                {
                    MessageBox.Show("Contact Number not valid");
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }

        private void SaveMember()
        {
            //Prepare query
            string query = "INSERT INTO Members (LastName, FirstName, HomeAddress, PostCode, ContactNum, EmergencyContact, StartYear) " +
                "VALUES (@lName, @fName, @address, @postCode, @contact, @emg, @year);";
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
                        cmd.Parameters.Add("@lName", SqlDbType.VarChar).Value = newMember.LastName;
                        cmd.Parameters.Add("@fName", SqlDbType.VarChar).Value = newMember.FirstName;
                        cmd.Parameters.Add("@address", SqlDbType.VarChar).Value = newMember.Address;
                        cmd.Parameters.Add("@postCode", SqlDbType.VarChar).Value = newMember.PostCode;
                        cmd.Parameters.Add("@contact", SqlDbType.VarChar).Value = newMember.ContactNum;
                        cmd.Parameters.Add("@emg", SqlDbType.VarChar).Value = newMember.EmergencyNum;
                        cmd.Parameters.Add("@year", SqlDbType.VarChar).Value = newMember.startYear.ToString("yyyy-MM-dd");
                        
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
        }

        private void ResetValues()
        {
            //Reset all text values to empty
            txtFName.Text = string.Empty;
            txtLName.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtPostCode.Text = string.Empty;
            txtEmCon.Text = string.Empty;
            txtContactNum.Text = string.Empty;

        }

        private void ResetErrorHints()
        {
            //Hide all error hints
            lblfNameError.Visible = false;
            lbllNameError.Visible = false;
            lblAddressError.Visible = false;
            lblPostcodeError.Visible = false;
            lblContactError.Visible = false;
            lblEmgConError.Visible = false;
        }
    }
}
