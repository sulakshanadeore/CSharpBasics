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

            //Event Invocation
            //Students manoj = new Students();
            //MarksCalculation marks = new MarksCalculation(manoj.calculateMarks);
            //CalculateStudentMarks += marks;

            // //Delegates are used for event handling,
            // //delegates are also called as event handlers
            //int totalmarks = CalculateStudentMarks(10, 30, 34);
            //Console.WriteLine(totalmarks);


            //Call Multiple methods on the delegate

            Students s = new Students();
            DoCalculatePercentage[] delarr = new DoCalculatePercentage[3]{s.CalculateTotal,s.CalculateAverage,s.CalculatePercentage };

            //Multicast Delegate is a class in System namespace.
            //this class is used to combine or remove one or more/all elements from the array of delegates
            //MulticateDelegate.Combine() method to combine the array elements of the delegates.//it concatenates the invocation list of the delegates
            //Combine method returns Delegate type, our delegate type must be casted for use in our code.

            DoCalculatePercentage del=(DoCalculatePercentage)MulticastDelegate.Combine(delarr);

            del(60, 70, 80);
            Console.WriteLine("Total marks= " + s.TotalMarks);
            Console.WriteLine("Average marks= " + s.AverageMarks);
            Console.WriteLine("PErcentage=" + s.Percentage);

            Console.WriteLine("----------------");

            Students s1 = new Students();

            DoCalculatePercentage[] delarr1 = new DoCalculatePercentage[3] { s1.CalculateTotal, s1.CalculateAverage, s1.CalculatePercentage };
             del = (DoCalculatePercentage)MulticastDelegate.Combine(delarr1);


            DoCalculatePercentage totalAndPerc =(DoCalculatePercentage)MulticastDelegate.Remove(del, delarr1[1]);

            totalAndPerc(78, 43, 55);

            Console.WriteLine("Total marks= " + s1.TotalMarks);

            if (s1.AverageMarks==0)
            {
                Console.WriteLine("Average not calculated this time");
            }
            else
            {
                Console.WriteLine("Average marks= " + s1.AverageMarks);
            }
            

            Console.WriteLine("PErcentage=" + s1.Percentage);

            Console.ReadLine();
        }
    }
}
