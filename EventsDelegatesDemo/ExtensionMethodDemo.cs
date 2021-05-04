using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EventsDelegatesDemo
{
//Extension methods are methods are written to extend the functionality of existing class,struct,etc
//Whatever u want to extend the functionality of, that shud be the first parameter in the static method of a static class with a "this" keyword
    static class customMethods
    {
   public   static int IsGreaterThan(this int i, int value)
        {
            int s;
            if (i>value)
            {
                s = i;
            }
            else
            {
                s = 0;
            }
            return s;
            //return i > value;
        
        }
    }
    class ExtensionMethodDemo
    {
        static void Main(string[] args)
        {

            int number = 10000;

            int res = number.IsGreaterThan(2000);
            Console.WriteLine(res);

            Console.WriteLine("--------Is the lsit empty-------");
            List<int> intlist = new List<int>();
            //{ 1, 2, 3, 4, 5 };
            bool isempty=intlist.Any();
            Console.WriteLine(isempty);


            Console.ReadKey();

        }



    }
}
