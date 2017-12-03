using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RecursiveFactorial(5).ToString());
    
        }

        public static int RecursiveFactorial(int n)
        {
            if (n == 0)
            {
                return 1; //base case
            }
            else
            {
                return n * RecursiveFactorial(n - 1); //recursive case
            }
        }
    }
}
