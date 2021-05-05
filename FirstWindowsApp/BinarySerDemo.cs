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
using System.Runtime.Serialization.Formatters.Binary;

namespace FirstWindowsApp
{
    public partial class BinarySerDemo : Form
    {
        public BinarySerDemo()
        {
            InitializeComponent();
        }
        string path = @"C:\Users\deore\Desktop\189-Mphasis\C#Demos\FirstWindowsApp\Demos\CustbinarySer.bin";
        private void btnSerialize_Click(object sender, EventArgs e)
        {
            Customer c = new Customer();
            c.Custid = Convert.ToInt32(txtcustid.Text);
            c.Custname = txtcustname.Text.Trim();
            //c.CardNo = txtcardno.Text;
            c.Amt = Convert.ToInt32(txtamt.Text);
            c.CustomerPoints(c.Amt);
            txtPoints.Text = c.Points.ToString();


            FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);
            BinaryFormatter b = new BinaryFormatter();
            b.Serialize(fs, c);
            
            fs.Close();
            fs.Dispose();





        }

        private void btnDeser_Click(object sender, EventArgs e)
        {
            

            
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            BinaryFormatter b = new BinaryFormatter();
            Customer c=(Customer)b.Deserialize(fs);
            textBox5.Text = c.Custid.ToString();
            textBox4.Text = c.Custname;
            //textBox3.Text = c.CardNo.ToString();
            textBox2.Text= c.Amt.ToString();
            textBox1.Text = c.Points.ToString();
                fs.Close();
            
            
        }
    }
}
