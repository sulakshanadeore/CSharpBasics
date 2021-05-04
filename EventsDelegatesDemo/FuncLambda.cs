using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsDelegatesDemo
{
    class FuncLambda
    {
        static int sum(int i, int j)
        {
            int ans = i + j;
            return ans;
        }

        static int randomNumberGen()
        {
            Random r = new Random();
            int no = r.Next(1, 100);
            return no;

        }


        static void Main(string[] args)
        {
            Func<int, int, int> f = sum;
            int  res=f(10, 20);
            Console.WriteLine(res);
            //Func take upto 0-16 parameters out of which one of the parameters is reserved for output and 15 u can pass values.
            //Last parameter is output type
            Console.WriteLine("------");


            Func<int> getNos;

            getNos = randomNumberGen;
            int rno = getNos();
            Console.WriteLine(rno);

            //Using Anonymous method
            //getNos = delegate ()
            //{
            //    Random r = new Random();
            //    int no = r.Next(1, 100);
            //    return no;

            //};

            //int rno=getNos();
            //Console.WriteLine(rno);

            //Hello
            //   Func<string s,int i,char c> getchar;
            Func <string,int,char> getchar;

            getchar = delegate (string s, int i)
            {
                char[] c1 = s.ToCharArray();
                char c2 = c1[i];
                return c2;
            };
            Console.WriteLine("Printing char at 1");
            char p=getchar("Hello", 4);
            Console.WriteLine(p);


            List<int> intlist = new List<int>() { 1,2,3,4,5 };
            int c = intlist.Count;
            Console.WriteLine("--------Average------");
               
            decimal dec = intlist.Average(b =>
            {
                decimal d1 = b / c;
                return d1;
            });
            Console.WriteLine(dec);

            Employee emp = new Employee();
            emp.Empid = 1;
            emp.Empname = "rina";

            Employee emp1 = new Employee();
            emp1.Empid = 2;
            emp1.Empname = "tina";

            Employee emp2 = new Employee();
            emp2.Empid = 1;
            emp2.Empname = "mina";

            Console.WriteLine("Name in the list");

            List<Employee> emplist = new List<Employee>();
            emplist.Add(emp);
            emplist.Add(emp1);
            emplist.Add(emp2);

            //string ename=emplist.Select(edata => edata.Empname).Last();
            //Console.WriteLine("Employee Name="  +ename);

            //Employee found=emplist.Find(edata => edata.Empid == 1);

            //Console.WriteLine(found.Empid);
            //Console.WriteLine(found.Empname);


            Employee found=emplist.FindAll(edata => edata.Empid == 1).LastOrDefault();
            Console.WriteLine(found.Empid);
            Console.WriteLine(found.Empname);

            Console.Read();


        }
    }
}
