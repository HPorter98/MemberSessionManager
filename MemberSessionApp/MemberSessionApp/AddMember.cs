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
    public partial class AddMember : UserControl
    {
        //string dataString = "";
        public AddMember()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //If data is valid, add member to the database
            if (DataCheck())
            {
                MessageBox.Show("Accepted");
                SaveMember();
                ResetValues();
            }
            else
            {
                MessageBox.Show("Invalid");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ResetValues();
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
            //Retrieve todays date
            string dateString = DateTime.Now.ToString("yyyy-MM-dd");
            //Prepare query
            string query = "INSERT INTO Members (LastName, FirstName, HomeAddress, PostCode, ContactNum, EmergencyContact, StartYear) " +
                "VALUES (@lName, @fName, @address, @postCode, @contact, @emg, @year);";
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
                        cmd.Parameters.Add("@lName", SqlDbType.VarChar).Value = txtLName.Text;
                        cmd.Parameters.Add("@fName", SqlDbType.VarChar).Value = txtFName.Text;
                        cmd.Parameters.Add("@address", SqlDbType.VarChar).Value = txtAddress.Text;
                        cmd.Parameters.Add("@postCode", SqlDbType.VarChar).Value = txtPostCode.Text;
                        cmd.Parameters.Add("@contact", SqlDbType.VarChar).Value = txtContactNum.Text;
                        cmd.Parameters.Add("@emg", SqlDbType.VarChar).Value = txtEmCon.Text;
                        cmd.Parameters.Add("@year", SqlDbType.VarChar).Value = dateString;
                        
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
    }
}
