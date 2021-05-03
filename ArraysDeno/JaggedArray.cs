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
<<<<<<< HEAD
            //Jagged/ragged Array-- rows fixed but elements in each row different-- array of arrays
=======
            //Jagged/ragged Array-- rows fixed but elements in each row different
>>>>>>> a752de9ed154892bd5088711cf51e6e190f0be60

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
