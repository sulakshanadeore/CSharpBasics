﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        //Instance methods/members of the class
        public  int staticVar = 100;
        public  void Meth1(int i, int j)
        {

            int answer = i + j;
            Console.WriteLine(answer);
            staticVar += 10;
            Console.WriteLine(staticVar);

        }
        public  double ShowSquareRoot(double i)
        {
            double answer = Math.Sqrt(i);
            return answer;

        }


        public  long Multiply(int i, int j)
        {
            return Math.BigMul(i, j);

        }

        public int FindMinNumberFromSequence(int no1, int no2)
        {
            return Math.Min(no1, no2);

        }

        public  int Division(int no, int dvisor, out int rem)
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
