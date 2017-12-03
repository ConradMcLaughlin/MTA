using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Factorial 2 = " + new MathFunctions().Factorial(2).ToString());
            Console.WriteLine("Factorial 3 = " + new MathFunctions().Factorial(3).ToString());
            Console.WriteLine("Factorial 4 = " + new MathFunctions().Factorial(4).ToString());
            Console.WriteLine("Factorial 5 = " + new MathFunctions().Factorial(5).ToString());
        }
    }

    public class MathFunctions
    {
        int fact = 1;

        public int Factorial(int n)
        {
            if (n > 1)
            {
                fact = fact * n;
                n = n - 1;
                Factorial(n);
            }

            return fact;
        }

    }
}
