using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAL;
using DAL;
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAcceptData_Click(object sender, EventArgs e)
        {
          
            Products p = new Products();
            try
            {
                p.ProductID = Convert.ToInt32(txtprodid.Text);
                p.ProductName = txtprodname.Text;
                p.UnitPrice = Convert.ToDouble(txtprodprice.Text);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            ProductsDAL dal = new ProductsDAL();
            int productid= Convert.ToInt32(txtprodid.Text);
            Products found = new Products();
            found=dal.FindProduct(productid);
            txtprodid.Text = found.ProductID.ToString();
            txtprodname.Text = found.ProductName;
            txtprodprice.Text = found.UnitPrice.ToString();
            txtunit.Text = found.QtyPerUnit;
            txtcatid.Text = found.CategoryID.ToString();
            txtsuppid.Text = found.SupplierID.ToString();

        }
    }
}
