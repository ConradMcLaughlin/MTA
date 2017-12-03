using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario_1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new SimpleArithmeticLibrary().Divide(5, 2.5M));
        }
    }

    class SimpleArithmeticLibrary
    {
        public decimal Divide(decimal x, decimal y)
        {
            decimal result = 0;

            try
            {
                result = x / y;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error : " + ex.Message);
            }
            catch (ArithmeticException ex)
            {
                Console.WriteLine("Error : " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex.Message);
            }

            return result;
        }

    }
}
