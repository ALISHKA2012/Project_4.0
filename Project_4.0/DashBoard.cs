using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Project_4._0
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private User _user = null;
        private string Logpath = FileManager.GetPath("Logs", "logs.txt");




        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void DashBoard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Session.Form1.Close();
        }
        private void DisplayUserInfo(User user)
        {
            label3.Text += " " + user.Name;
            label4.Text += " " + user.Surname;
            label5.Text += " " + user.Age;
            label2.Text += " " + user.Email;
        }
     


        private void DashBoard_Load(object sender, EventArgs e)
        {


         
                _user = Session.User;
                DisplayUserInfo(_user);


                if (!string.IsNullOrEmpty(_user.ProfilePicturePath))
                {
                    FileManager.ShowMyImage(_user.ProfilePicturePath, pictureBox2, 250, 190);
                }
                FileManager.WriteLogs(Logpath, _user.Email, LogStatus.LogIn);
            
       

        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
  


          

            Session.Form1.Show();
            Hide();
            FileManager.WriteLogs(Logpath, _user.Email, LogStatus.LogOut);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           var result = FileDialog.ShowDialog();
            
            if (result == DialogResult.OK)
            {
                string fileName = FileDialog.FileName;
                _user.ProfilePicturePath = fileName;
                FileManager.ShowMyImage(_user.ProfilePicturePath, pictureBox2, 250, 190);



            }
        }

        private void FileDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdminPanel adminPanel = Session.AdminPanel == null ? new AdminPanel() : Session.AdminPanel;
            adminPanel.ShowDialog();
        }

        private void linkLabel3_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            (groupBox4.Visible) = (true);
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
    }
}
