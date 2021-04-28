
using System;

namespace CSharpBasics
{
    class Program
    {
        //Ctrl +K+ C--- Comment
        //Ctrl + K + U----Uncomment
        //How? static
        //    What is nameof the method-- Main
        //    What is return typeof the method= void
        //    Parameters --- string array-
        //    name of parameter====args


        /// <summary>
        /// static method which doesnot require calling it using a object of class
        /// </summary>
        /// <param name="i"></param>
        /// <param name="j"></param>
        static void Meth1(int i, int j)
        {
            int answer = i + j;
            Console.WriteLine(answer);

        }
        static double ShowSquareRoot(double i)
        {
            double answer = Math.Sqrt(i);
            return answer;

        }


        static long Multiply(int i, int j)
        {
            return Math.BigMul(i, j);

        }

        static int FindMinNumberFromSequence(int no1, int no2)
        {
            return Math.Min(no1, no2);

        }

        static int Division(int no, int dvisor,out int rem)
        {
            int quo;
            if (dvisor != 0)
            {
                //ans= no / dvisor;
                // rem = no % dvisor;
                 quo =Math.DivRem(no, dvisor, out rem);
            }
            else
            {
                quo = 0;
                rem = 0;
            }
            return rem;
        }


        //Math.Pow


        static void Main(string[] args)
        {
            //main--- entry point of Program
            //#region VariableDeclaration
            //int i;
            //i = 10;
            //Console.WriteLine(i);
            //float pi = 3.14f;
            //Console.WriteLine(pi);
            //DateTime dt = new DateTime(2021, 4, 29);
            //Console.WriteLine(dt);
            //string s = "hello";
            //Console.WriteLine(s);
            //char c = 'A';
            //Console.WriteLine(c);
            //Single t = 4.566f;
            //Int32 j = 89;
            //Char c1 = 'B';
            //String username = "World";
            //Int16 p = 2;
            //short p1 = 3;
            //long p2 = 234242;
            //Console.WriteLine("Enter the value for i");
            //i = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter username");
            //username = Console.ReadLine();
            //Console.WriteLine("enter value for p1");
            //p1 = Convert.ToInt16(Console.ReadLine());
            //Console.WriteLine(i);
            //Console.WriteLine(username);
            //Console.WriteLine(p1);
            //#endregion

            Program.Meth1(10, 20);
            double a=Program.ShowSquareRoot(100);
            Console.WriteLine(a);
            Console.WriteLine(Program.Multiply(100, 2000));
            Console.WriteLine(Program.FindMinNumberFromSequence(1000,8000));
            int r;
            Console.WriteLine("Division Answer= " +  Program.Division(10, 3,out r));
            Console.WriteLine("Remainder=" + r);

            Console.Read();

        }
    }
}
