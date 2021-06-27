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
        //public List<Member> memberList = new List<Member>();
        public Session()
        {
            InitializeComponent();
        }

        private void Session_Load(object sender, EventArgs e)
        {
            //UpdateTable();
            lblDate.Text = DateTime.Now.ToShortDateString();
        }

        public void UpdateTable()
        {
            string query = "select [Members].[PersonID], FirstName, [Members].LastName , [mSessions].SessionType, " +
                           "[mSessions].SessionTime from Members inner join mSessions on [Members].PersonID = [mSessions].MemberID " +
                           "where [mSessions].sessionType like '%" + comboBox1.SelectedItem + "%'" +
                           "and where [mSessions].sessionDate like '%" + DateTime.Now.ToString("yyyy-MM-dd") + "%';";
            
            try
            {
                //create new conneciton and execute query
                using (SqlConnection connection = new SqlConnection(Helper.ConVal("Members")))
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    connection.Open();

                    DataTable search = new DataTable();

                    //Fill the data grid table with data retrieve from database
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
            gridSession.Columns[0].HeaderText = "ID";
            gridSession.Columns[1].HeaderText = "Last Name";
            gridSession.Columns[2].HeaderText = "First Name";
            gridSession.Columns[3].HeaderText = "Session Type";
            gridSession.Columns[4].HeaderText = "Session Time";
        }

        private void StartTable(object sender, EventArgs e)
        {
            UpdateTable();
        }
    }
}
