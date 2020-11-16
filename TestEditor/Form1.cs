using System;
using System.IO;
using System.Windows.Forms;

namespace TestEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DirectoryInfo directory = Directory.GetParent(Directory.GetCurrentDirectory());

            string path = $@"{directory}/text.txt";

            //string path = "C:/text.txt";
            string content = richTextBox1.Text;

            MessageBox.Show(path);
            File.WriteAllText(path, content);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
