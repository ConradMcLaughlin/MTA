using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario_2_1
{
    public class Product
    {
        private string _name;
        private decimal _price = 0.00M;

        public string Name
        {
            get { return _name; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new Exception("Product Name cannot be empty");
                _name = value;
            }
        }

        public decimal Price
        {
            get { return _price; }
            set
            {
                if (value < 0.00M)
                    throw new Exception("Price cannot be negative");
                _price = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0} - £{1:N2}", Name, Price);
        }
    }
}
