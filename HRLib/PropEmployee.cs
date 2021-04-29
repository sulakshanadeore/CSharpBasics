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
        private int _empid;
        public int EmployeeId
        {
            set { _empid = value; }//Assigning value to variable
            get { return _empid; }//Returning value of the variable
        }

        private string _ename;
        public string EmployeeName
        {
            get { return _ename; }
            set { _ename = value; }
        }

        private float _salary;

        public float Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }


        private int _deptno;

        public int DepartmentNo
        {
            get { return _deptno; }
            set { _deptno = value; }
        }



    }
}
