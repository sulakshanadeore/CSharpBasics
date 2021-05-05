using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Json;
//using System.Runtime.Serialization.Formatters.Soap;



namespace FirstWindowsApp
{
    public partial class JSonSer : Form
    {
        public JSonSer()
        {
            InitializeComponent();
        }
        string path = @"C:\Users\deore\Desktop\189-Mphasis\C#Demos\FirstWindowsApp\Demos\CustJsonSer.json";
        private void JSonSer_Load(object sender, EventArgs e)
        {

        }

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
            //1. JavaScriptSerializer,2. DataContractJsonSerializer,3.JSON.Net Library


            DataContractJsonSerializer dc = new DataContractJsonSerializer(typeof(Customer));
            dc.WriteObject(fs, c);
            fs.Close();
            fs.Dispose();



        }

        private void btnDeser_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            DataContractJsonSerializer dc = new DataContractJsonSerializer(typeof(Customer));
            Customer c=(Customer)dc.ReadObject(fs);
            textBox5.Text = c.Custid.ToString();
            textBox4.Text = c.Custname;
            //textBox3.Text = c.CardNo.ToString();
            textBox2.Text = c.Amt.ToString();
            textBox1.Text = c.Points.ToString();
        }
    }
}
