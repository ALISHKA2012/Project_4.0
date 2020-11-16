using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_4._0
{
    public partial class Log_List_Form : Form
    {
        public Log_List_Form()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Session.AdminPanel.Show();
            Session.Log_List_Form = this;
            Hide();
        }

        private void Log_List_Form_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = FileManager.GetLogs(FileManager.GetPath("Logs", "logs.txt"));
         
     
        }

        private void Log_List_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Session.AdminPanel.Close();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
