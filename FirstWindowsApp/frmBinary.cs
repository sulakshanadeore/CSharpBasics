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
    public partial class frmBinary : Form
    {
        public frmBinary()
        {
            InitializeComponent();
        }
        string path = @"C:\Users\deore\Desktop\189-Mphasis\C#Demos\FirstWindowsApp\Demos\";

        private void button1_Click(object sender, EventArgs e)
        {
            string fname = string.Concat(path, textBox1.Text);
            FileStream fs = new FileStream(fname, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs, Encoding.Default);
            bw.Write(Convert.ToInt32(textBox2.Text));
            bw.Flush();
            bw.Close();
            fs.Close();
            fs.Dispose();

        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            string fname = string.Concat(path, textBox1.Text);
            FileStream fs = new FileStream(fname, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            richTextBox1.Text = br.ReadInt32().ToString();
            br.Close();
            fs.Close();
            fs.Dispose();


        }

        private void frmBinary_Load(object sender, EventArgs e)
        {

        }
    }
}
