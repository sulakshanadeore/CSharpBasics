using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysDeno
{
    class MultiDimensionalArrayDemo
    {

        static void Main(string[] args)
        {


            //MultiDimensional-- Rectangular--- first row,second column

            int[,] multiD = new int[3, 4] {
        { 10,20,30,40 },/*initialization for 0th row*/
        {100,200,300,400 },//first row
        {1000,2000,3000,4000 }//second row
        
        };

            int val = multiD[2, 3];
            Console.WriteLine(val);

            //foreach (var item in multiD)
            //{
            //    Console.WriteLine(item);

            //}

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine();
                for (int j= 0; j < 4; j++)
                {
                    Console.Write(multiD[i,j] + "\t");
                }
            }

            Console.ReadKey();
        }
    }


}
