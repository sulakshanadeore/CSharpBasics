using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysDeno
{
    class Program
    {
        static void Main(string[] args)
        {

            //var i = 34;
            //var p = "sf";
            //i = 3444.33f;

            int[] arr = new int[] {3,32,344,222,44 };
            //int[] arr1 = new int[3];
            //arr1[0] = 100;
            //arr1[1] = 33;
            //arr1[2] = 3322;

            Array.Sort(arr);

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------------------");
            Array.Reverse(arr);
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            int[] arr1 = new int[arr.Length];

            //Array.Copy(arr, arr1, arr.Length);
            Array.Copy(arr,0,arr1,0,2);
            Console.WriteLine("Destination Array");
            foreach (var item in arr1)
            {
                Console.WriteLine(item);
            }
            Array.Clear(arr, 0, 3);
            Console.WriteLine("After clearing first 3 elements");
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Array element index");
           int idx =Array.IndexOf(arr, 3);
            Console.WriteLine(idx);

            Console.WriteLine("Using Create Instance of Array class ");
            int[] myvalues= new int[10];
            myvalues=Program.AssignValuesToArray();
            foreach (var item in myvalues)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Binary Search");
            int v1=Array.BinarySearch(myvalues, 30);
            Console.WriteLine(v1);
            myvalues[8] = 3;
            int indexofDemo=Array.IndexOf(myvalues, 30);
            Console.WriteLine(indexofDemo);


            
            


            //Console.WriteLine("Common in both");
            //int[] firstarr = new int[] { 1, 2, 3 };
            //int[] secondarr = new int[] { 1, 2, 3,34,33 };

            //IEnumerable<int> common=firstarr.Intersect(secondarr);
            //foreach (var item in common)
            //{
            //    Console.WriteLine(item);
            //}


            Console.ReadKey();



        }
        static int j = 2;
        static   int[]  AssignValuesToArray()
        {
            Array array = Array.CreateInstance(typeof(int), 11);
            int[] valuesArr = (int[])array;
            valuesArr[0] = 1;
            valuesArr[1] = 2;
             
            for (int i = 2; i < valuesArr.Length; i++)
            {
                j = j + 1;
                valuesArr[i] = j;
            }
            return valuesArr;

        }
    }
}
