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
using System.Xml;
namespace FirstWindowsApp
{
    public partial class frmXML : Form
    {
        public frmXML()
        {
            InitializeComponent();
        }
        string path = @"C:\Users\deore\Desktop\189-Mphasis\C#Demos\FirstWindowsApp\Demos\";

        private void frmXML_Load(object sender, EventArgs e)
        {
           


        }

        private void button2_Click(object sender, EventArgs e)
        {
            string fname = string.Concat(path, textBox1.Text);
            FileStream fs = new FileStream(fname, FileMode.Open, FileAccess.Read);
            XmlReader xr=XmlReader.Create(fs);
            while (xr.Read())
            {
                switch (xr.NodeType)
                {
                    case XmlNodeType.None:
    richTextBox1.Text += xr.Value;
                        break;
                    case XmlNodeType.Element:
                        richTextBox1.Text += xr.Value;
                        break;
                    case XmlNodeType.Attribute:
                        richTextBox1.Text += xr.Value;
                        break;
                    case XmlNodeType.Text:
                        richTextBox1.Text += xr.Value;
                        break;
                    case XmlNodeType.CDATA:
                        richTextBox1.Text += xr.Value;
                        break;
                    case XmlNodeType.EntityReference:
                        richTextBox1.Text += xr.Value;
                        break;
                    case XmlNodeType.Entity:
                        richTextBox1.Text += xr.Value;
                        break;
                    case XmlNodeType.ProcessingInstruction:
                        richTextBox1.Text += xr.Value;
                        break;
                    case XmlNodeType.Comment:
                        richTextBox1.Text += xr.Value;
                        break;
                    case XmlNodeType.Document:
                        richTextBox1.Text += xr.Value;
                        break;
                    case XmlNodeType.DocumentType:
                        richTextBox1.Text += xr.Value;
                        break;
                    case XmlNodeType.DocumentFragment:
                        richTextBox1.Text += xr.Value;
                        break;
                    case XmlNodeType.Notation:
                        richTextBox1.Text += xr.Value;
                        break;
                    case XmlNodeType.Whitespace:
                        richTextBox1.Text += xr.Value;
                        break;
                    case XmlNodeType.SignificantWhitespace:
                        richTextBox1.Text += xr.Value;
                        break;
                    case XmlNodeType.EndElement:
                        richTextBox1.Text += xr.Value;
                        break;
                    case XmlNodeType.EndEntity:
                        richTextBox1.Text += xr.Value;
                        break;
                    case XmlNodeType.XmlDeclaration:
                        richTextBox1.Text += xr.Value;
                        break;
                    default:
                        break;
                }
            }
            xr.Close();
            fs.Close();
            fs.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fname = string.Concat(path, textBox1.Text);
            FileStream fs = new FileStream(fname, FileMode.Create, FileAccess.Write);
            XmlWriter xw = XmlWriter.Create(fs);
            xw.WriteStartElement("book");
            xw.WriteElementString("title", "C# Basics");
            xw.WriteElementString("price", "123");
            xw.WriteElementString("year", "2021");
            xw.WriteComment("this is a good book");

            xw.WriteEndElement();
            xw.Flush();
            xw.Close();
            fs.Close();
        }
    }
}
