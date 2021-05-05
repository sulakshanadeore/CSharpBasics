using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;

using System.IO;
namespace FirstWindowsApp
{
    public partial class frmGeneral : Form
    {
        public frmGeneral()
        {
            InitializeComponent();
        }

        private void frmGeneral_Load(object sender, EventArgs e)
        {

        }

        private void btnCreateDir_Click(object sender, EventArgs e)
        {
            string dirname = txtdirname.Text;
            Directory.CreateDirectory(@"C:\Users\deore\Desktop\189-Mphasis\C#Demos\FirstWindowsApp\" + dirname);
            MessageBox.Show("Directory Created..");
        }

        private void button2_Click(object sender, EventArgs e)
        {

            FileSystem.RenameDirectory(@"C:\Users\deore\Desktop\189-Mphasis\C#Demos\FirstWindowsApp\" + txtoldname.Text, txtnewname.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            File.Create(@"C:\Users\deore\Desktop\189-Mphasis\C#Demos\FirstWindowsApp\Demos\" + "demo1.txt");
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string[] contents = new string[] { "Hello from All.... ABCEDEFGHIJNLSDFSDFSF" };
            string cnts = "Welcome to Files";
            //File.WriteAllText(@"C:\Users\deore\Desktop\189 - Mphasis\C#Demos\FirstWindowsApp\Demos\" + "demo1.txt", contents);
            //File.WriteAllLines(@"C:\Users\deore\Desktop\189-Mphasis\C#Demos\FirstWindowsApp\Demos\" + "demo1.txt", cnts);

            File.AppendAllText(@"C:\Users\deore\Desktop\189-Mphasis\C#Demos\FirstWindowsApp\Demos\" + "demo1.txt", cnts);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text=File.ReadAllText(@"C:\Users\deore\Desktop\189-Mphasis\C#Demos\FirstWindowsApp\Demos\" + "demo1.txt");



            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string source = @"C:\Users\deore\Desktop\189-Mphasis\C#Demos\FirstWindowsApp\Demos\demo1.txt";
            string dest= @"C:\Users\deore\Desktop\189-Mphasis\C#Demos\FirstWindowsApp\Demos\copiedFile.txt";
            File.Copy(source, dest);
            MessageBox.Show("Done");
        }

        private void button8_Click(object sender, EventArgs e)
        {

            string src = @"C:\Users\deore\Desktop\189-Mphasis\C#Demos\FirstWindowsApp\Demos\copiedFile.txt";
            string dest = @"C:\Users\deore\Desktop\189-Mphasis\C#Demos\FirstWindowsApp\movedfile.txt";
            File.Move(src, dest);
            MessageBox.Show("Moved....");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string dest = @"C:\Users\deore\Desktop\189-Mphasis\C#Demos\FirstWindowsApp\movedfile.txt";
            File.Delete(dest);
            MessageBox.Show("Deleted");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            string dest = @"C:\Users\deore\Desktop\189-Mphasis\C#Demos\FirstWindowsApp\movedfile.txt";
            bool ans=File.Exists(dest);
            MessageBox.Show(ans.ToString());
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string p = @"C:\Users\deore\Desktop\189-Mphasis\C#Demos\FirstWindowsApp\";
            string[] dirs = Directory.GetDirectories(p);
            foreach (var item in dirs)
            {
                listBox1.Items.Add(item);
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            string p = @"C:\Users\deore\Desktop\189-Mphasis\C#Demos\FirstWindowsApp\";
            DirectoryInfo di = new DirectoryInfo(p);
            MessageBox.Show(di.CreationTime.ToString());
            MessageBox.Show(di.FullName);
            FileInfo[] fi=di.GetFiles();
            foreach (var item in fi)
            {
                MessageBox.Show(item.FullName);
                MessageBox.Show(item.Extension);


            }
        }
    }
}
