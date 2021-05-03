using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsDelegatesDemo
{
    class Program
    {
        static event MarksCalculation CalculateStudentMarks;
        static void Main(string[] args)
        {
            //1) type safety
            // 2) Sync & aysc calls to methods
            //3) Multiple methods in a single call-- chain of calls to the methods
            //4) it is used heavily in multi-threading---
            //Linq--- query mechanism
            // events
            //no type errors
            //int-- int,short 

            //Students manoj = new Students();
            //MarksCalculation marks = new MarksCalculation(manoj.calculateMarks);//Pointing to function

            //int totalmarks = marks(10, 30, 50);//Invoking/calling the delegate
            //Console.WriteLine(totalmarks);
            //-----------------------------------------
            //Students manoj = new Students();
            //MarksCalculation marks = new MarksCalculation(manoj.calculateMarks);
            //int totalmarks=marks.Invoke(10, 20, 30);
            //Console.WriteLine(totalmarks);
            Students manoj = new Students();
            MarksCalculation marks = new MarksCalculation(manoj.calculateMarks);
            CalculateStudentMarks += marks;
            int totalmarks = CalculateStudentMarks(10, 30, 34);
            Console.WriteLine(totalmarks);
            



        }
    }
}
