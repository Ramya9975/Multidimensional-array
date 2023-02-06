using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multidimensional_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int rowsum;
            int[,] multiArray = new int[2, 5]
            {
                {2,2,2,2,2},
                 {3,3,3,3,3}
            };
            for(int row = 0; row<2; row++)
            {
                rowsum = 0;
                for(int col = 0; col < 5; col++) 
                {
                    Console.Write("{0}\t", multiArray[row, col]);
                rowsum = rowsum+ multiArray[row, col];
                }
                sum = sum + rowsum;
                Console.Write(" = {0}", rowsum);
                Console.WriteLine();

            }
            Console.WriteLine("The sum of the array is:{0}", sum);
            Console.ReadLine();
        }
    }
}
