using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsDelegatesDemo
{
    public delegate void Stringlength(string s1, string s2);
    class AnonymousDemo
    {
        static void Main(string[] args)
        {
            Stringlength len = delegate (string s, string g) {
                int l = s.Length;
                int p = g.Length;
                int t = l + p;
                Console.WriteLine(t);

            };

            len("Hello", "Priya");
            Console.WriteLine("---------------------------");





            Console.WriteLine("enter basic salary");
            int bs = Convert.ToInt32(Console.ReadLine());
            Employee emp = new Employee();
            DoAllCalculations dac = delegate (int basicSal)
              {

                  emp.CalculateGrossSalary(bs);
                  emp.CalculateNetSalary(bs);

                  Console.WriteLine("Gross Salary= " + emp.GrossSalary);
                  Console.WriteLine("Net Salary= " + emp.NetSalary);

              };
            dac(bs);

            Console.ReadLine();
        }
    }
}
