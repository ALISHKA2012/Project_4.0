using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Events2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btn1.Click += Btn1Click;

        }

        private void Btn1Click(object sender, EventArgs e)
        {
            this.Text = sender.GetType().FullName;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
