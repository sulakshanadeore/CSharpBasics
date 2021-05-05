using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{



    [Serializable]
    public class EmployeeNotFoundException : Exception
    {
        public EmployeeNotFoundException() { }
        public EmployeeNotFoundException(string message) : base(message) { }
        public EmployeeNotFoundException(string message, Exception inner) : base(message, inner) { }
        protected EmployeeNotFoundException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
 public   class Employee
    {
        public static List<Employee> emplist = new List<Employee>();

        public int Empid { get; set; }

        public string Ename { get; set; }

        public void EmployeeList()
        {
            
            emplist.Add(new Employee {Empid=1,Ename="Ria" });
            emplist.Add(new Employee { Empid = 2, Ename = "Sia" });
            emplist.Add(new Employee { Empid = 3, Ename = "Priya" });
            emplist.Add(new Employee { Empid = 4, Ename = "Tina" });


        }

        public void FindEmployee(int empidToFind)
        {
            Employee empfound=emplist.Find(p => p.Empid == empidToFind);
            bool found;
            if (empfound==null)
            {
                //found=false;
                throw new EmployeeNotFoundException("this empid not found");
            }
            else
            {
                found= true;
            }

            //return found;
        }
    }
}
