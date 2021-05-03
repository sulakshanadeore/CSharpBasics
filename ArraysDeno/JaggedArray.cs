using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysDeno
{
    class JaggedArray
    {
        static void Main(string[] args)
        {
            //Jagged/ragged Array-- rows fixed but elements in each row different

            int[][] jagged = new int[2][];
            jagged[0] = new int[4] { 1, 2, 3, 4 };
            jagged[1] = new int[5]{10,20,30,40,50 };

            for (int i = 0; i < jagged.Length; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < jagged[i].Length; j++)
                {
                    Console.Write(jagged[i][j] + "\t");
                }
            }

            Console.ReadLine();

        }
    }
}
