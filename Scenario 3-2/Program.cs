using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            UsingQueues();
        }

        private static void UsingQueues()
        {
            Queue<int> q1 = new Queue<int>(new int[] { 1, 2, 3, 4, 5 });
            Queue<int> q2 = new Queue<int>(new int[] { 5, 10, 15, 20, 25 });

            foreach (int x in q1)
            {
                Console.WriteLine(x);
            }

            foreach (int x in q2)
            {
                Console.WriteLine(x);
            }
        }
    }
}
