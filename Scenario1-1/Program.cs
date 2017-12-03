using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Discount for 75 items is " + InvoiceTool.CalculateDiscount(75).ToString());
            Console.WriteLine("Discount for 3 items is " + InvoiceTool.CalculateDiscount(3).ToString());
            Console.WriteLine("Discount for 40 items is " + InvoiceTool.CalculateDiscount(40).ToString());
            Console.WriteLine("Discount for 300 items is " + InvoiceTool.CalculateDiscount(300).ToString());
        }
    }


    public static class InvoiceTool
    {
        public static int CalculateDiscount(int quantity)
        {
            if (quantity < 10)
            {
                return 5;
            }

            if (quantity < 50)
            {
                return 10;
            }

            if (quantity < 100)
            {
                return 15;
            }

            return 20;
        }
    }
}
