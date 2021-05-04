using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsDelegatesDemo
{
    class LambdaDemo
    {
        // 3 types : Function/Action/Predicate
                      //Func/Action/bool
                      // =>
        static void Main(string[] args)
        {
            List<int> intlist = new List<int>() { 22, 11, 34, 2, 35, 2234 };
            //intlist.Add(112);
           List<int> evenNos =intlist.FindAll(i => (i % 2) == 0);
            foreach (var item in evenNos)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----find whether number 22 exists----");
            int j = 22;
            int num=intlist.Find(i => (i == j));
            bool ans;
            if (num==j)
            {
                ans = true;
                if (ans)
                {
                    Console.WriteLine("Number exists");
                }
                
                
            }
            else
            {
                
                    Console.WriteLine("Number doesnot exists");
                
            }

            Console.WriteLine("--------------Index---------");
             j = 22;
            int index = intlist.FindLastIndex(i => i == j);
            Console.WriteLine(index);
            Console.WriteLine("---- Is every numebr >0 -----");
            bool ans1=intlist.TrueForAll(i => i > 0);
            Console.WriteLine(ans1);
            Console.ReadKey();
        }
    }
}
