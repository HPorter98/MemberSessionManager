using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MemberSessionApp
{
    public partial class SearchMember : UserControl
    {
        public List<Member> memberList = new List<Member>();
        public SearchMember()
        {
            InitializeComponent();
        }

        public void UpdateTable()
        {
            string value = txtSearch.Text;
            try
            {
                //create new conneciton and execute query
                using (SqlConnection connection = new SqlConnection(Helper.ConVal("Members")))
                using (SqlDataAdapter adapter = new SqlDataAdapter("Select PersonID, LastName, " +
                    "FirstName FROM members WHERE LastName LIKE '%" + value + "%';", connection))
                {
                    connection.Open();

                    DataTable search = new DataTable();

                    //Fill the data grid table with data retrieve from database
                    adapter.Fill(search);
                    SearchTable.DataSource = search;
                    FormatTable();
                }

                if (value == string.Empty)
                {
                    SearchTable.DataSource = null;
                }
            }
            catch
            {
                MessageBox.Show("Can not connect to database");
            }
        }

        private void StartTable(object sender, EventArgs e)
        {
            UpdateTable();
        }

        public void FormatTable()
        {
            SearchTable.Columns[0].HeaderText = "ID";
            SearchTable.Columns[1].HeaderText = "Last Name";
            SearchTable.Columns[2].HeaderText = "First Name";
        }

        private void OpenMemberForm(object sender, DataGridViewCellEventArgs e)
        {
            //Retrieve member ID from data grid
            try
            {
                int i = (int)SearchTable.Rows[e.RowIndex].Cells[0].Value;
                //Retrieve and set that member from the database
                Member member = GetMemberByID(i);

                //Initialise a new member form and pass the selected member
                MemberForm mF = new MemberForm();
                mF.Member = member;
                if (mF.ShowDialog() == DialogResult.OK)
                {
                    member = mF.Member;
                    memberList.Add(member);
                }
            }
            catch
            {
                MessageBox.Show("Cell does not contain value");
            }
        }

        private Member GetMemberByID(int id)
        {
            Member m = new Member();
            string query = "SELECT * FROM Members WHERE PersonID = @id"; 

            try
            {
                using (SqlConnection connection = new SqlConnection(Helper.ConVal("Members")))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(query, connection)) //open new connection
                    {
                        cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = id; //bind parameter
                        using (SqlDataReader reader = (cmd.ExecuteReader())) 
                        {
                            while (reader.Read()) //read the query results
                            {
                                //Add result values to a member object.
                                //This block of code retrieves data for each column
                                //Within the database table.
                                m.ID = reader.GetInt32("PersonID");
                                m.LastName = reader.GetString("LastName");
                                m.FirstName = reader.GetString("FirstName");
                                m.Address = reader.GetString("HomeAddress");
                                m.PostCode = reader.GetString("PostCode");
                                m.ContactNum = reader.GetString("ContactNum");
                                m.EmergencyNum = reader.GetString("EmergencyContact");
                                m.startYear = reader.GetDateTime("StartYear");
                            }
                        }
                    }
                }
                return m;
            }
            catch
            {
                MessageBox.Show("Can not connect");
                return null;
            }
        }
    }
}
