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
            SearchPanel.BringToFront();
            //SessionPanel.SendToBack();
            MessageBox.Show("Works");
        }

        private void btnSession_Click(object sender, EventArgs e)
        {
            SessionPanel.BringToFront();
            //SearchPanel.SendToBack();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SearchPanel.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
