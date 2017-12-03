using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            HighestValueInArray();
        }

        public static void HighestValueInArray()
        {
            const int rows = 4;
            const int columns = 5;

            int[,] a = new int[rows, columns] {  { 1, 3, 40, 5, 6 },
                                        { 10, 3, 46, 5, 6 },
                                        { 1, 3, 40, 500, 6 },
                                        { 1, 3, 4, 5, 666 }};

            int temp = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (a[i, j] > temp)
                        temp = a[i, j];
                }
                Console.WriteLine(string.Format("The highest value in row {0} is {1}", i, temp));
                temp = 0;
            }

        }

    }
}
