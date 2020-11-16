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
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DashBoard dashBoard = Session.DashBoard == null ? new DashBoard() : Session.DashBoard;
            dashBoard.ShowDialog();
        }

        private User admin;
        private void AdminPanel_Load(object sender, EventArgs e)
        {
            admin = Session.User;
            groupBox2.Text += " " + admin.Email;

        }

      

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Session.Form1.Show();
            Hide();
        }

        private void AdminPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            Session.Form1.Close();
        }

        private void linkLabel2_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Log_List_Form log_list_form = Session.Log_List_Form == null ? new Log_List_Form() : Session.Log_List_Form;
            Session.AdminPanel = this;
            log_list_form.ShowDialog();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            User_List_Form user_list_form = Session.User_List_Form == null ? new User_List_Form() : Session.User_List_Form;
            Session.AdminPanel = this;
            user_list_form.ShowDialog();
        }
    }
}
