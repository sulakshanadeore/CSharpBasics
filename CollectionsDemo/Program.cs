﻿using HRLib;
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

            //AddElementToList(10000);
            //PrintArrayList();
            //Console.WriteLine(alist.Capacity);
            //bool HasFalseValue = alist.Contains(true);
            //Console.WriteLine(HasFalseValue);
            //object[] objarr = new object[15];
            //alist.CopyTo(objarr);
            //int idx = alist.IndexOf(10000);
            //Console.WriteLine(idx);
            //int[] i1 = new int[] { 400, 500, 600 };
            //alist.InsertRange(1, i1);
            //PrintArrayList();
            //alist.LastIndexOf()
            //ArrayList secondlist = alist.GetRange(1, 3);
            //Console.WriteLine("Get Range");
            //foreach (var item in secondlist)
            //{
            //    Console.WriteLine(item);
            //}
            //alist.SetRange();
            //alist.ToArray();
            //string s = "Hello";

            //char[] chararray = s.ToCharArray();
            //foreach (var item in chararray)
            //{
            //    Console.WriteLine(item);
            //}
            //dotnetperls


            Hashtable t = new Hashtable();

            PropEmployee emp = new PropEmployee() 
            { EmployeeId = 1,
         EmployeeName = "Ash",
            DepartmentNo = 10,
            Salary = 34345
        };

            t.Add(1, emp);
            t.Add("1", "One");
            t.Add(1.1f, 1);
            // t.Add("1", "1");
            //t.Add("1", 1);


            //t.Contains();
            //t.ContainsKey();
            //t.ContainsValue();

            //ICollection values=t.Values;

            //foreach (var item in values)
            //{
            //    Console.WriteLine(item);

            //}

            //ICollection keys=t.Keys;
            //foreach (var item in keys)
            //{
            //    Console.WriteLine(item);
            //}

            //IDictionaryEnumerator ie=t.GetEnumerator();
            //while (ie.MoveNext())
            //{
            //    DictionaryEntry de=ie.Entry;
            //    Console.WriteLine(de.Key);
            //    Console.WriteLine(de.Value);
            //    //object obj=ie.Current;
            //    //Console.WriteLine(obj);

            //}
            //while (ie.MoveNext())
            //{
            //    Console.WriteLine(ie.Key + " "  + ie.Value);
            //}
            //foreach (var item in t)
            //{
            //    Console.WriteLine(t);
            //}
            //Stack s = new Stack();
            //s.Push(11);
            //s.Push(13);
            //s.Pop();//13
            //s.Push(300);
            //s.Peek();//300

            //Stack s1 = new Stack();
            //s1.Push(100);
            //s1.Push(200);
            //    s1.Push(300);
            //s1.Push(400);
            //Stack o1=(Stack)s1.Clone();

            //s1.Pop();
            //Console.WriteLine("Original Stack s1");
            //foreach (var item in s1)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("Cloned stack o1");
            //foreach (object item in o1)
            // {
            //    Console.WriteLine(item);
            //}


            Queue q = new Queue();
            q.Enqueue(1000); 
            q.Enqueue(2000);
            q.Enqueue(3000);
            q.Enqueue(4000);
            q.Enqueue(5000);
            q.Enqueue(6000);

            q.Dequeue();//1000
            q.Peek();//2000


            SortedList sl = new SortedList();
            

            Console.ReadLine();
        }

    }
}
