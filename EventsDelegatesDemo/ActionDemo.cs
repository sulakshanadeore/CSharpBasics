using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsDelegatesDemo
{
    class ActionDemo
    {
        static void Main(string[] args)
        {
            //any method that takes one parameter of any type & return void
            //Action<int> a = new Action<int>(PrintNos);
            //a(10);   

            List<int> intlist = new List<int>() { 22, 11, 34, 2, 35, 2234 };
            intlist.ForEach(i => Console.WriteLine(i));

            string s;
            List<int> intlist2 = new List<int>() {1,2,3,4,5 };

            List<int> oddnos=intlist2.Where(n => n % 2 == 1).ToList();

            Console.WriteLine("----Odd nos----");
            foreach (var item in oddnos)
            {
                Console.WriteLine(item);
            }
            


            //ActionDemo.PrintNos(10);
            Console.Read();
        }


        public static void PrintNos(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(i);
            }
        
        }

    }
}
