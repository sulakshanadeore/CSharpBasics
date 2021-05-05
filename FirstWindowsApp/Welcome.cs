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
    public partial class frmWelcome : Form
    {
        public frmWelcome()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Form Loaded ......");
        }

        private void frmWelcome_MouseMove(object sender, MouseEventArgs e)
        {
            //MessageBox.Show("Mouse moved ......");
        }

        private void frmWelcome_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Clicked ...");
            
            //this.BackColor = Color.CornflowerBlue;
        }

        private void binaryFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBinary b = new frmBinary();
            b.Show();
        }

        private void textFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmText t = new frmText();
            t.Show();
        }

        private void xMLFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmXML x = new frmXML();
            x.Show();
        }

        private void generalMethodsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGeneral g = new frmGeneral();
            g.Show();
                 
        }

        private void filesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void directoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void drivesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DriveInfo info = new DriveInfo("C");
            DirectoryInfo dirinfo=info.RootDirectory;
            MessageBox.Show(dirinfo.ToString());
            string driveformat=info.DriveFormat;
            MessageBox.Show(driveformat);
            MessageBox.Show(info.AvailableFreeSpace.ToString());

            MessageBox.Show(info.TotalFreeSpace.ToString());

        }

        private void binaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BinarySerDemo bs = new BinarySerDemo();
            bs.Show();
        }

        private void xMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XMLSer xs = new XMLSer();
            xs.Show();
        }

        private void jSONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JSonSer jdemo = new JSonSer();
            jdemo.Show();
        }
    }
}
