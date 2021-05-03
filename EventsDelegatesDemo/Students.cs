using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsDelegatesDemo
{
    public delegate int MarksCalculation(int s1, int s2, int s3);
    
    public class Students
    {
        

        public int calculateMarks(int s1, int s2, int s3)
        {
            return s1 + s2+s3;
        
        }

    }
}
