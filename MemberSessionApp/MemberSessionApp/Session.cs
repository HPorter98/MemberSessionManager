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
    public partial class Session : UserControl
    {
        public Session()
        {
            InitializeComponent();
        }

        private void Session_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToShortDateString();
            comboBox1.SelectedIndex = 0;
        }

        public void UpdateTable()
        {
            string sessionID = comboBox1.SelectedItem + "/" + DateTime.Now.ToString("yyyy-MM-dd");
            string query = "select [Members].[PersonID], [Members].FirstName, [Members].LastName, [SessionDetails].SessionEndTime from Members " +
                           "inner join MemberSession on [Members].PersonID = [MemberSession].PersonID " +
                           "inner join SessionDetails on[SessionDetails].SessionID = [MemberSession].SessionID " +
                           $"where[MemberSession].SessionID = @sessionID;";
            
            try
            {
                //create new conneciton and execute query
                using (SqlConnection connection = new SqlConnection(Helper.ConVal("Members")))
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    connection.Open();

                    
                    DataTable search = new DataTable();

                    //Fill the data grid table with data retrieve from database
                    adapter.SelectCommand.Parameters.Add("@sessionID", SqlDbType.VarChar).Value = sessionID;
                    adapter.Fill(search);
                    gridSession.DataSource = search;
                    FormatTable();
                }
            }
            catch
            {
                MessageBox.Show("Can not connect to database");
            }
        }

        public void FormatTable()
        {
            gridSession.RowHeadersVisible = false;

            gridSession.Columns[0].HeaderText = "ID";
            gridSession.Columns[1].HeaderText = "Last Name";
            gridSession.Columns[2].HeaderText = "First Name";
            gridSession.Columns[3].HeaderText = "Session Finish";

            gridSession.Columns[0].Width = gridSession.Width / 4;
            gridSession.Columns[1].Width = gridSession.Width / 4;
            gridSession.Columns[2].Width = gridSession.Width / 4;
            gridSession.Columns[3].Width = gridSession.Width / 4;

        }

        private void StartTable(object sender, EventArgs e)
        {
            UpdateTable();
        }
    }
}
