using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemberSessionApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            searchMemberPanel.BringToFront();
            SessionPanel.Visible = false;
        }

        private void btnSession_Click(object sender, EventArgs e)
        {
            SessionPanel.BringToFront();
            SessionPanel.Visible = true;
            SessionPanel.UpdateTable();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            searchMemberPanel.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddMemberPanel.BringToFront();
            SessionPanel.Visible = false;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            sessionHistoryPanel.BringToFront();
            sessionHistoryPanel.UpdateTable();
        }   
    }
}
