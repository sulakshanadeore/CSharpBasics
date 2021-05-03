using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRLib;
namespace ArraysDeno
{
    class ClassArrayDemo
    {
        static void Main(string[] args)
        {
            PropEmployee[] emp = new PropEmployee[5];
            for (int i = 0; i < emp.Length; i++)
            {
                emp[i] = new PropEmployee();
                Console.WriteLine("Enter employeedid");
                emp[i].EmployeeId = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Employee Name");
                emp[i].EmployeeName = Console.ReadLine().Trim();
                Console.WriteLine("Enter Salary ");
                emp[i].Salary = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("Enter Deptno");
                emp[i].DepartmentNo= Convert.ToInt32(Console.ReadLine());
             }

            
            Console.WriteLine("Printing");
            foreach (var item in emp)
            {
                Console.WriteLine(item.EmployeeId);
                Console.WriteLine(item.EmployeeName);
                Console.WriteLine(item.Salary);
                Console.WriteLine(item.NetSalary);
                Console.WriteLine(item.DepartmentNo);
                Console.WriteLine("-------------------");
            }

            Console.WriteLine("");
            int cnt=emp.Count();
            Console.WriteLine("count of employees " + cnt);
           

            Console.ReadKey();


        }
    }
}
