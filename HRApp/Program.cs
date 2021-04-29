using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRLib;
namespace HRApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee emp = new Employee();
            //emp.AcceptData(12, "Jack", "Mumbai", "Developer", 50000f, 10);
            //emp.ShowData();

            //Default Constructor of the class
            PropEmployee emp1 = new PropEmployee();
          //  Console.WriteLine("Enter Employee Id");
          //emp1.EmployeeId = Convert.ToInt32(Console.ReadLine());

          //  Console.WriteLine("Enter employee Name");
          //  emp1.EmployeeName = Console.ReadLine();

          //  Console.WriteLine("Enter Deptno");
          //  emp1.DepartmentNo = Convert.ToInt32(Console.ReadLine());

          //  Console.WriteLine("Enter Salary");
          //  emp1.Salary = Convert.ToSingle(Console.ReadLine());

            //emp1.Password = "temp@345";
            //emp1.NetSalary = 3333;
            //emp1.EmployeeId = 110;//set


            //Console.WriteLine(emp1.EmployeeId);//get
            //Console.WriteLine(emp1.EmployeeName);
            //Console.WriteLine(emp1.DepartmentNo);
            //Console.WriteLine(emp1.Salary);
            //     Console.WriteLine(emp1.NetSalary);
            Console.WriteLine(emp1.Password);
            Console.WriteLine("Please enter new password");
            emp1.NewPassword = Console.ReadLine();
            
            



            Console.Read();
        }
    }
}
