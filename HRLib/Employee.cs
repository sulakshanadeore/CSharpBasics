using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLib
{
    public class Employee
     {
        int empid, deptno;
        double salary;
        string empname, city, postion;


        public void AcceptData(int eid,string ename,string City,string pos,float sal,int deptno)
        {
            this.empid = eid;
            this.empname = ename;
            this.city = City;
            this.postion = pos;
            this.salary = sal;
            this.deptno = deptno;

        
        }



        public void ShowData()
        {
            Console.WriteLine("empId=" + empid);
            Console.WriteLine("empName=" + empname);
            Console.WriteLine("emp Salary=" + salary);
            this.salary = salary + (salary * .10);
            Console.WriteLine("emp Salary=" + salary);
            Console.WriteLine("Designation=" + postion);
            Console.WriteLine("Deptno=" + deptno);
            Console.WriteLine("City=" + city );



        }
        //Overloading--- 
        // Multiple Methods in a single scope/class with same name different number,type and sequence of arguments/parameters , return type not considered.
        public int BasicSalary { get; set; }

        const float RatePerHour = 1000;
        public void CalculateSalary()
        {
            Console.WriteLine(BasicSalary);
        
        
        }
        public int CalculateSalary(int bs)
        {
            return bs;

        }
        public void CalculateSalary(int bs,int Hrs)
        {

            Console.WriteLine(bs+(Hrs* RatePerHour));

        }
        public void CalculateSalary(int bs,float hrs)
        {
            Console.WriteLine(bs + (hrs * RatePerHour));

        }
        public double CalculateSalary(int bs, string loc,int hrs)
        {
            double sal;
            if (loc == "Chennai")
            {
                float r = 2000;
                sal = bs + (hrs * r);
            }
            else if (loc == "Bangalore")
            {
                float r= 1500;
                sal = bs + (hrs * r);
            }
            else if (loc == "Tamil Nadu")
            {
                float r = 1000;
                sal = bs + (hrs * r);
            }
            else
            {
                float r = 1700;
                sal = bs + (hrs * r);
            }
            return sal;
        }








    }
}
