using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace WorkingWithXMLReader
{
    class Program
    {
        static void Main(string[] args)
        {
            using (XmlReader reader = XmlReader.Create("Customers.xml"))
            {
                while (reader.Read())
                {
                    if (reader.IsStartElement())
                    {
                        switch (reader.Name)
                        {
                            case "CompanyName":
                                if (reader.Read())
                                {
                                    Console.Write("Company Name: {0},", reader.Value);
                                }
                                break;
                            case "Phone":
                                if (reader.Read())
                                {
                                    Console.Write("Phone: {0},", reader.Value);
                                }
                                break;
                        }
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
