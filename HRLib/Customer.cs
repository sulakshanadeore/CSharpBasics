using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLib
{
public class Customer
    {
        public Customer()
        {
            Console.WriteLine("default cosntructor of Customer");
        }

        public Customer(int  custid):this()
        {
            Console.WriteLine("Custid cosntructor of Customer");
        }
        public Customer(int custid, string cname)
        {

            Console.WriteLine("custid, cname cosntructor of Customer");
        }
    }


   public class InternationalCsutomer:Customer
    {
        public InternationalCsutomer()
        {
            Console.WriteLine("default cosntructor of InternationalCsutomer");
        }

        public InternationalCsutomer(int cid)
        {
            Console.WriteLine("cid cosntructor of InternationalCsutomer");
        }
    }
}
