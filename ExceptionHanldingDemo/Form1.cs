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
using ClassLibrary2;
namespace ExceptionHanldingDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

           

        }

        private void BtnClick_Click(object sender, EventArgs e)
        {
            try
            {
                            
            Employee emp = new Employee();
            emp.EmployeeList();
           /* bool ans = */
                emp.FindEmployee(5);
            //MessageBox.Show(ans.ToString());
                //MessageBox.Show("Emp found");
                //MessageBox.Show(efound.Empid);
                //MessageBox.Show(efound.Ename);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
