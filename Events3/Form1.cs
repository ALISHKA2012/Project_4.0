using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Events3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Click += Button1_Click;
            this.MouseHover += Form1_MouseHover;
        }

        private void Form1_MouseHover(object sender, EventArgs e)
        {
            this.Text = sender.GetType().Name;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Text = sender.GetType().FullName;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
