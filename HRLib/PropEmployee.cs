using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLib
{
   public class PropEmployee
    {
        //smart methods---- properties
        //Variables are always private
        public PropEmployee()
        {

        }

        public PropEmployee(int empid,string ename)
        {
            this.EmployeeId = empid;
            this.EmployeeName = ename;
        }

        public PropEmployee(PropEmployee mycopy)
        {
            this._empid = mycopy.EmployeeId;
            this._ename = mycopy.EmployeeName;
                
        }
        public void ShowValues()
        {
            Console.WriteLine(this._empid);
            Console.WriteLine(this._ename);
        }


        private int _empid;
        public int EmployeeId
        {
            set {
                _empid = value;

            
            }//Assigning value to variable
            get { return _empid; }//Returning value of the variable
        }

        //ReadWrite Property
        private string _ename;
        public string EmployeeName
        {
            get { return _ename; }
            set { _ename = value; }
        }

        //Read only property--- if no setter
        private string _password="demo@123";

        public string Password
        {
            get { return _password; }
            private set { _password = value; }
        }


        //no getter---- writeonly
        string _pwd;
        public string NewPassword
        {
            set 
            {
                _pwd = value;
                if (Password==_pwd)
                {
                    Console.WriteLine("Please change password.. U can't use this as your password");
                }
                else
                {
                    Password =_pwd;
                    Console.WriteLine("Your new password  = " + Password);
                }
            }
        }




        //private setter property
        private  double _netsal;

        public  double NetSalary
        {
            get { return _netsal; }
          private  set { _netsal = value; }
        }

        private float _salary;

        public float Salary
        {
            get { return _salary; }
            set {
                _salary = value;
                if (_salary >0 && _salary<=10000)
                {
                    NetSalary = _salary + (_salary * .10);
                }
                else if (_salary > 10001 && _salary < 20000)
                {
                    NetSalary = _salary + (_salary * .5);
                }
                else
                {

                    NetSalary = _salary;
                }
            }
        }


        private int _deptno;

        public int DepartmentNo
        {
            get { return _deptno; }
            set { _deptno = value; }
        }



    }
}
