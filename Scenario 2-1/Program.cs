using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product house = new Product();
            house.Name = "16 Damherst Piece";
            house.Price = 225000.50M;
            Console.WriteLine(house.ToString());
        }
    }
}
