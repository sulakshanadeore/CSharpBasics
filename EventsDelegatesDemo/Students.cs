using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsDelegatesDemo
{
    public delegate int MarksCalculation(int s1, int s2, int s3);

    public delegate void DoCalculatePercentage(int s1, int s2, int s3);

    public class Students
    {

        public int TotalMarks { get;  set; }


        public int AverageMarks { get; set; }


        public float Percentage { get; set; }

        public int calculateMarks(int s1, int s2, int s3)
        {
            return s1 + s2 + s3;

        }

        public void CalculateTotal(int m1, int m2, int m3)
        {
            this.TotalMarks = m1 + m2 + m3;
            

        }

        public void CalculateAverage(int m1, int m2, int m3)
        {
            AverageMarks = TotalMarks / 3;

        }


        public void CalculatePercentage(int m1, int m2, int m3)
        {
        
            Percentage = (TotalMarks * 100 / 300);

        
        }



    }
}
