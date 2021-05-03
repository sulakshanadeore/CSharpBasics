using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRLib;
namespace CollectionsDemo
{
    class GenericsDemos
    {
        //Type safety

        static void Main(string[] args)
        {
            //Stack<float>
            //Stack<Employee> empstack = new Stack<Employee>();
            //empstack.Push();
            

            Queue<int> qint = new Queue<int>();
            qint.Enqueue(100);
            qint.Enqueue(34);
            var i = 445;
            qint.Enqueue(i);
            dynamic d1 = 23;
            //var j = 3454.44f;
            qint.Enqueue(d1);

            foreach (var item in qint)
            {
                Console.WriteLine(item);
            }

            List<string> names = new List<string>();
            //names.Add()

            //Dictionary<int, string> keyValuePairs = new Dictionary<int, string>();
            //keyValuePairs.Add()
            SortedList<int, Employee> emplist = new SortedList<int, Employee>();
            SortedSet<int> sortedints = new SortedSet<int>();
            sortedints.Add(123);
            sortedints.Add(1);
            sortedints.Add(10);
            sortedints.Add(23);

            Console.WriteLine("Sorted Ints");
            foreach (var item in sortedints)
            {
                Console.WriteLine(item);
            }

            SortedDictionary<int, string> sd = new SortedDictionary<int, string>();






            Console.ReadKey();
        }
    }
}
