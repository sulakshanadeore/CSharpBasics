using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace FirstWindowsApp
{
    public partial class frmText : Form
    {
        public frmText()
        {
            InitializeComponent();
        }
        string path = @"C:\Users\deore\Desktop\189-Mphasis\C#Demos\FirstWindowsApp\Demos\";

        private void button1_Click(object sender, EventArgs e)
        {
            //string fname = path + textBox1.Text;
            string fname = string.Concat(path, textBox1.Text);
            FileStream fs = new FileStream(fname,FileMode.Create,FileAccess.Write);
            //TextReader--- abstract class
            //TextWriter
            //StreamReader ---inherits from --- TextReader
            //  StreamWriter ---inherits from--- TextWriter

            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(textBox2.Text);
            sw.Flush();
            sw.Close();
            fs.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string fname = string.Concat(path, textBox1.Text);
            FileStream fs = new FileStream(fname,FileMode.Open,FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
           richTextBox1.Text =sr.ReadToEnd();
        }
    }
}
