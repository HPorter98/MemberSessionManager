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
    public partial class SessionForm : Form
    {
        string sessionID = "";
        string type = "";
        string time = "";
        DateTime date;
        public SessionForm()
        {
            InitializeComponent();
        }

        public string SessionID 
        {
            get { return sessionID; }
            set { sessionID = value; }
        }

        public string SessionType
        {
            get { return type; }
            set { type = value; }
        }

        public DateTime SessionDate
        {
            get { return date; }
            set { date = value; }
        }

        public string SessionTime
        {
            get { return time; }
            set { time = value; }
        }



        private void SessionForm_Load(object sender, EventArgs e)
        {
            LoadMembers();
            lblSession.Text = type;
            lblTime.Text = time;
            lblDate.Text = date.ToShortDateString();

           
        }

        private void LoadMembers()
        {

            string query = $"SELECT PersonID, FirstName, LastName FROM MemberSession WHERE SessionID = @sessionID;";

            using (SqlConnection connection = new SqlConnection(Helper.ConVal("Members")))
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
            {
                connection.Open();

                DataTable result = new DataTable();

                adapter.SelectCommand.Parameters.Add("@sessionID", SqlDbType.VarChar).Value = sessionID;
                adapter.Fill(result);
                memberGrid.DataSource = result;
                FormatTable();
            }
        }

        private void FormatTable()
        {
            memberGrid.RowHeadersVisible = false;

            memberGrid.Columns[0].HeaderText = "ID";
            memberGrid.Columns[1].HeaderText = "First Name";
            memberGrid.Columns[2].HeaderText = "Last Name";

            memberGrid.Columns[0].Width = memberGrid.Width / 3;
            memberGrid.Columns[1].Width = memberGrid.Width / 3;
            memberGrid.Columns[2].Width = memberGrid.Width / 3;
        }
    }
}
