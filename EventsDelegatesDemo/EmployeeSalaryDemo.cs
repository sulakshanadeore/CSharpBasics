using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsDelegatesDemo
{
    class EmployeeSalaryDemo
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
           
            DoAllCalculations obj1 = new DoAllCalculations(emp.CalculateGrossSalary);

            DoAllCalculations obj2 = new DoAllCalculations(emp.CalculateNetSalary);

            DoAllCalculations cal=(DoAllCalculations)MulticastDelegate.Combine(obj1, obj2);
            Console.WriteLine("enter basic salary");
            int bs = Convert.ToInt32(Console.ReadLine());
            cal(bs);
            Console.WriteLine("Gross Salary" + emp.GrossSalary);
            Console.WriteLine("Net Salary" + emp.NetSalary);

            Console.ReadLine();


        }
    }
}
