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
            //Console.WriteLine(emp1.Password);
            //Console.WriteLine("Please enter new password");
            //emp1.NewPassword = Console.ReadLine();


            //Orders o = new Orders(12,"Mobile Phone",40000,1);
            //o.OrderNo = 13;
            //o.OrderDate = new DateTime(2021,04,29);
            //Console.WriteLine(o.OrderAmt);

            //Orders o1 = new Orders(12, "Mobile Phone", 50000, 1);
            //o.OrderNo = 14;
            //o.OrderDate = new DateTime(2021, 04, 29);
            //Console.WriteLine(o1.OrderAmt);

            //Orders o2 = new Orders();
            //Console.WriteLine(o2.OrderAmt);

            //Orders o4 = new Orders(123, "Hard disk",10000f);
            /* Polymorphism---- Overloading Constructors*/
            //Same  name but different number,type and sequence of arguments to the method--- function,void,constructor
            //Orders o = new Orders();

            //PropEmployee e1 = new PropEmployee(3, "Praj");
            //PropEmployee e2 = new PropEmployee(e1);
            //e2.ShowValues();

            //Employee emp = new Employee();
            //emp.CalculateSalary(20000,4.5);
            // CustomerPayment payment = new CustomerPayment();
            // Console.WriteLine("Enter Payment Mode");
            //PaymentMode p = (PaymentMode)Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("You have selected the payment mode  " + p);

            // switch (p)
            // {
            //     case PaymentMode.BhimUPi:
            //         long UPIid=234324; 
            //         double Amt=32444d;
            //         int UPIPin=3243; 
            //         int OTP=434;

            //         payment.Pay(UPIid, Amt, UPIPin, OTP);
            //         break;
            //     case PaymentMode.NetBanking:

            //         break;
            //     case PaymentMode.CardPayment:
            //         break;
            //     case PaymentMode.Paytm:
            //         break;
            //     case PaymentMode.COD:
            //         break;
            //     case PaymentMode.Gpay:
            //         break;
            //     case PaymentMode.QR:
            //         break;
            //     default:
            //         break;
            // }


            Student student = new Student();
            
            Console.Read();
        }
    }
}
