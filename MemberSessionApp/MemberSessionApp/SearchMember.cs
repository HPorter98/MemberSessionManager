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
        public SearchMember()
        {
            InitializeComponent();
        }

        public void UpdateTable()
        {
            string value = txtSearch.Text;
            try
            {
                using (SqlConnection connection = new SqlConnection(Helper.ConVal("Members")))
                using (SqlDataAdapter adapter = new SqlDataAdapter("Select LastName, FirstName FROM members WHERE LastName LIKE '%" + value + "%';", connection))
                {
                    connection.Open();

                    DataTable search = new DataTable();

                    adapter.Fill(search);
                    SearchTable.DataSource = search;
                    FormatTable();
                }

                if (value == "")
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
            SearchTable.Columns[0].HeaderText = "Last Name";
            SearchTable.Columns[1].HeaderText = "First Name";
        }
    }
}
