using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;


namespace Project_4._0
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {






        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_register_Click(object sender, EventArgs e)
        {


        }




        private void grbx_register_Enter(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            (groupBox1.Visible, grbx_register.Visible) = (false, true);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txbx_surname_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                string
            name = txbx_name2.Text,
            surname = txbx_surname2.Text,
            email = txbx_email2.Text,
            password = txbx_password2.Text,
                age = txbx_age2.Text;

                Validation.Validate(name, surname, age, email, password);
                sbyte converAge = Validation.IsAgeValueValid(age, 0);
                Validation.IsEmailValid(txbx_email2.Text);
                Validation.IsPasswordValid(txbx_password2.Text);

                if (!Users.HasUser(email, password))
                {
                    User user = new User(name, surname, converAge, email, password)
                    {
                        UserRole = UserRole.User
                    };
                    Session.User = user;
                    AccountManager.DisplayConfirmationForm += AccountManager_DisplayConfirmationForm;
                    AccountManager.SendMail(email);
                    Session.User = user;
            
                    if (user.IzEmailConfirmed)
                    {
                        Users.AddUser(user);
                        MessageBox.Show("You registered successefully!");
                    }
                    else
                    {
                        MessageBox.Show("You did not confirm your email!");

                    }
                }
                else
                {
                    MessageBox.Show("this ");
                }
            }
            catch (ArgumentNullException exp)
            {
                MessageBox.Show(exp.Message);
            }
            catch (FormatException exp)
            {
                MessageBox.Show(exp.Message);
            }
            catch (InvalidAgeValueException exp)
            {
                MessageBox.Show(exp.Message);
            }
            catch (InvalidEmailException exp)
            {
                MessageBox.Show(exp.Message);

            }
            catch (InvalidPasswordException exp)
            {
                MessageBox.Show(exp.Message);

            }
            finally
            {
                EmptyTextboxes(txbx_email2, txbx_age2, txbx_name2, txbx_password2, txbx_surname2);
            }
        }

        private void AccountManager_DisplayConfirmationForm()
        {
            Session.Code = AccountManager.ConfirmationCode;
            new CodeConfimationForm().ShowDialog();
            //MessageBox.Show("dgfgdfgdf");

        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            (groupBox3.Visible, groupBox4.Visible) = (false, true);
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            (groupBox3.Visible, groupBox4.Visible) = (true, false);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                string
email = textBox9.Text,
password = textBox8.Text;
                if (Users.HasUser(email, password))
                {
                    Hide();
                    User user = Users.GetUser(email, password);
                    Session.User = user;
                    Session.Form1 = this;
                    if (user.UserRole == UserRole.Admin)
                    {
                        AdminPanel adminPanel = Session.AdminPanel == null ? new AdminPanel() : Session.AdminPanel;
                        adminPanel.ShowDialog();
                    }
                    if (user.UserRole == UserRole.User)

                    {
                        DashBoard dashBoard = Session.DashBoard == null ? new DashBoard() : Session.DashBoard;
                        dashBoard.ShowDialog();
                    }


                }
            }
            catch (ArgumentNullException exp)
            {
                MessageBox.Show(exp.Message);
             
            }
            catch (InvalidEmailException exp)
            {
                MessageBox.Show(exp.Message);

            }
            catch (InvalidPasswordException exp)
            {
                MessageBox.Show(exp.Message);

            }
            finally
            {
                EmptyTextboxes(textBox9, textBox8);
            }

        }
        private void EmptyTextboxes(params TextBox[] textboxes)
        {
            if (textboxes == null)
                throw new ArgumentNullException();
            foreach (var txbx in textboxes)
            {
                txbx.Text = string.Empty;

}

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            (l.Visible, img.Visible) = (true, true);


        }

        private void button3_Click(object sender, EventArgs e)
        {
            (richTextBox2.Visible, button.Visible) = (true, true);
        }

        private void button_Click(object sender, EventArgs e)
        {
            (richTextBox2.Visible, button.Visible) = (false, false);
        }
    }
    }
