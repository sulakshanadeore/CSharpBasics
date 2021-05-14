using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BAL;
using System.Data.SqlClient;
namespace DAL
{
    public class ProductsDAL
    {

       public Products FindProduct(int productid)
        {
            SqlConnection cn = new SqlConnection("server=spd\\sqlexpress;Integrated Security=true;database=northwind");
            //SqlCommand cmd = new SqlCommand("select * from products where productid=" +productid);
            
            SqlCommand cmd = new SqlCommand("select * from [dbo].[FindProduct](@productid)", cn);
            cmd.Parameters.AddWithValue("@productid", productid);
            cn.Open();
            Products p = new Products();
            try
            {
                SqlDataReader dr = cmd.ExecuteReader();
                //readonly, fwdonly stream of data
                dr.Read();
                p.ProductID = Convert.ToInt32(dr["productid"]);
                p.ProductName = dr[1].ToString();
                p.UnitPrice = Convert.ToInt32(dr["UnitPrice"]);
                p.QtyPerUnit = dr[3].ToString();
                p.CategoryID = Convert.ToInt32(dr["CategoryID"]);
                p.SupplierID = Convert.ToInt32(dr["SupplierID"]);
            }
            catch (Exception)
            {

                throw;
            }

            cn.Close();


            
            return p;

        }

    }
}
