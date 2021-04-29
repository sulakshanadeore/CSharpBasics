using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLib
{
public  class Orders
    {
        //Auto implemented - automatically implemented
        public int OrderNo { get; set; }
        public DateTime OrderDate { get; set; }
        public double OrderAmt { get; set; }

        public Orders()
        {
            Console.WriteLine("Enter Productid");
            int prodID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Productname");
            string prodname = Console.ReadLine();
            Console.WriteLine("Enter Product Qty");
            int Qty = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Product Price");
            double price = Convert.ToDouble(Console.ReadLine());
            double amt = Qty * price;
            OrderAmt = amt;



        }
        int prodid;
        public Orders(int prodid)
        {
            this.prodid = prodid;
        }

        string pname;
        public Orders(int prodid,string pname):this(prodid)
        {
            this.pname = pname;
            //this.prodid = prodid;
            Console.WriteLine(this.prodid);
            Console.WriteLine(this.pname);
        }

        float price;
        public Orders(int prodid,string pname,float price):this(prodid,pname)
        {
            this.price = price;
            Console.WriteLine(this.price);
        }




        //int,string,double,int
        //change sequence,change type
        // int,int,string,double
        //   double,int,int,string

        public Orders(int prodid,int qty,string name,double price)
        {

        }

        public Orders(int prodid,string name,double price,int qty)
        {
            double amt=price* qty;
            OrderAmt += amt;

        }



    }
}
