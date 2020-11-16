using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_4._0
{
    public partial class User_List_Form : Form
    {
        public User_List_Form()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void User_List_Form_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Users.GetUsers();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Session.AdminPanel.Show();
            Session.User_List_Form = this;
            Hide();
        }

        private void User_List_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Session.AdminPanel.Close();
        }
    }
}
