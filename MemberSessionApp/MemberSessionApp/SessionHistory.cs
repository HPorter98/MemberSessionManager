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
            try
            {
                string sessionID = cmbSession.SelectedItem + "/" + dateTimePicker.Value.ToString("yyyy-MM-dd");
                string query = $"SELECT SessionType, SessionDate, SessionID, SessionStartTime FROM SessionDetails WHERE SessionID = '{sessionID}'";
                //create new conneciton and execute query
                using (SqlConnection connection = new SqlConnection(Helper.ConVal("Members")))
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    connection.Open();

                    DataTable search = new DataTable();

                    //Fill the data grid table with data retrieve from database
                    adapter.Fill(search);
                    sessionGrid.DataSource = search;
                }

                FormatTable();

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

        private void FormatTable()
        {
            sessionGrid.RowHeadersVisible = false;
            sessionGrid.Columns[0].HeaderText = "Session";
            sessionGrid.Columns[1].HeaderText = "Date";
            sessionGrid.Columns[2].HeaderText = "Session ID";
            sessionGrid.Columns[3].Visible = false;

            sessionGrid.Columns[0].Width = sessionGrid.Width / 3;
            sessionGrid.Columns[1].Width = sessionGrid.Width / 3;
            sessionGrid.Columns[2].Width = sessionGrid.Width / 3;
            
        }

        private void OpenForm(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string sessionType = sessionGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                DateTime sessionDate = (DateTime)sessionGrid.Rows[e.RowIndex].Cells[1].Value;
                string sessionID = sessionGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
                string sessionTime = sessionGrid.Rows[e.RowIndex].Cells[3].Value.ToString();

                SessionForm sessionForm = new SessionForm();
                
                sessionForm.SessionID = sessionID;
                sessionForm.SessionType = sessionType;
                sessionForm.SessionDate = sessionDate;
                sessionForm.SessionTime = sessionTime;

                if (sessionForm.ShowDialog() == DialogResult.OK)
                {

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Cell has no value");
            }
        }
    }
}
