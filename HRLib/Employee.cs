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
    }
}
