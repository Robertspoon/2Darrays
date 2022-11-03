using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] Array2D = new int[4, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 10, 11, 12 } };

            Console.WriteLine(Array2D[0, 2]);
            Console.WriteLine(Array2D[3, 2]);
            Console.WriteLine(Array2D[2, 0]);
            Console.WriteLine(Array2D[1, 2]);


            Console.ReadKey(true);
        }
    }
}
