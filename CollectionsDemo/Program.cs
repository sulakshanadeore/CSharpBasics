using System;
//using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{

    class Demo
    {
        public int d1 { get; set; }
    }
    class Program
    {
        public static ArrayList alist = new ArrayList(2);

        static void RemoveElementfromList(dynamic i)
        {
            alist.Remove(i);
            //alist.RemoveAt(index)
            //alist.RemoveRange()
            //alist.Insert()
            alist.Sort();
            alist.Reverse();
            alist.Clear();
            
        }

        static void AddElementToList(dynamic i)
        {
            alist.Add(i);
        }

        static  void PrintArrayList()
        {
            //1. can have duplicate element
            //2. growable list
            //3. storage of null values
            //4. it is used when getting is more than adding or removing
            //int[] iarr = new int[2] { null, null };

        
            alist.Add(12);
            alist.Add(45.6f);
            alist.Add(34535.344d);
            alist.Add(true);
            alist.Add(new DateTime(2021, 04, 01));
            Demo dobj = new Demo();
            alist.Add(dobj);
            alist.Add(null);

            //object o;
            ////dynamic d1=100;
            ////int i = 10;


            foreach (var item in alist)
            {
                Console.WriteLine(item);
            }





        }



        static void Main(string[] args)
        {
            //BitArray bitArray = new BitArray(2);
            //bitArray.Set(0, true);
            //bitArray.Set(1, false);
            //bool a=bitArray.Get(0);

            AddElementToList(10000);
            PrintArrayList();
            Console.WriteLine(alist.Capacity);
            bool HasFalseValue=alist.Contains(true);
            Console.WriteLine(HasFalseValue);
            object[] objarr = new object[15];
            alist.CopyTo(objarr);
            int idx=alist.IndexOf(10000);
            Console.WriteLine(idx);
            int[] i1 = new int[] { 400, 500, 600 };
            alist.InsertRange(1, i1);
            PrintArrayList();
            //alist.LastIndexOf()
            ArrayList secondlist=alist.GetRange(1, 3);
            Console.WriteLine("Get Range");
            foreach (var item in secondlist)
            {
                Console.WriteLine(item);
            }
            //alist.SetRange();
            //alist.ToArray();
            string s = "Hello";

            char[] chararray=s.ToCharArray();
            foreach (var item in chararray)
            {
                Console.WriteLine(item);
            }
            //dotnetperls



            

            Console.ReadLine();
        }

    }
}
