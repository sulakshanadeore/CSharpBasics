using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsDelegatesDemo
{
    public delegate void DoAllCalculations(int bs);

    public class Employee
    {

        public double GrossSalary { get; set; }
        public double NetSalary { get; set; }
        public int TA { get; set; }
        public int DA { get; set; }
        public double PF { get; set; }

        public void CalculateGrossSalary(int basicSalary)
        {
            GrossSalary = basicSalary + (basicSalary * .10);
        
        }


        public void CalculateNetSalary(int basicSalary)
        {
            PF = basicSalary * .10;
            TA = Convert.ToInt32(basicSalary * .01);
            DA=Convert.ToInt32(basicSalary * .01);
            NetSalary = GrossSalary + TA + DA + PF;
           
        
        }
    }
}
