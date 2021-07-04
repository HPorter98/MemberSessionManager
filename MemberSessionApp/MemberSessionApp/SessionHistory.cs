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
    public partial class SessionHistory : UserControl
    {
        public SessionHistory()
        {
            InitializeComponent();
        }

        public void UpdateTable()
        {
            //string value = txtSearch.Text;
            try
            {
                //"Select PersonID, LastName, " +
                //"FirstName FROM members WHERE LastName LIKE '%" + value + "%';", connection
                string sessionID = cmbSession.SelectedItem + "/" + dateTimePicker.Value.ToString("yyyy-MM-dd");
                string query = $"SELECT SessionType, SessionDate, SessionID FROM SessionDetails WHERE SessionID = '{sessionID}'";
                //create new conneciton and execute query
                using (SqlConnection connection = new SqlConnection(Helper.ConVal("Members")))
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    connection.Open();

                    DataTable search = new DataTable();

                    //Fill the data grid table with data retrieve from database
                    adapter.Fill(search);
                    sessionGrid.DataSource = search;
                    //FormatTable();
                }

                if (cmbSession.SelectedIndex < 0)
                {
                    sessionGrid.DataSource = null;
                }
            }
            catch
            {
                MessageBox.Show("Can not connect to database");
            }
        }

        private void SelectionChange(object sender, EventArgs e)
        {
            UpdateTable();
        }
    }
}
