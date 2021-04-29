using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
   class SecondProgram
    {
       public static int staticVar = 100;
        public static void Meth1(int i, int j)
        {
         
            int answer = i + j;
            Console.WriteLine(answer);
            staticVar += 10;
            Console.WriteLine(staticVar);

        }
        public static double ShowSquareRoot(double i)
        {
            double answer = Math.Sqrt(i);
            return answer;

        }


        public static long Multiply(int i, int j)
        {
            return Math.BigMul(i, j);

        }

        public static int FindMinNumberFromSequence(int no1, int no2)
        {
            return Math.Min(no1, no2);

        }

        public static int Division(int no, int dvisor, out int rem)
        {
            int quo;
            if (dvisor != 0)
            {
                //ans= no / dvisor;
                // rem = no % dvisor;
                quo = Math.DivRem(no, dvisor, out rem);
            }
            else
            {
                quo = 0;
                rem = 0;
            }
            return rem;
        }


    }
}
