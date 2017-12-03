using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithDataSet
{
    class Program
    {
        static void Main(string[] args)
        {
            WorkingWithDataSet();
        }

        static void WorkingWithDataSet()
        {
            try
            {
                //Set connection string and adapters
                string cString = @"Persist Security Info=False;Integrated Security=true;Initial Catalog=Northwind;server=(localdb)\MSSQLLocalDB";
                SqlConnection northwindConnection = new SqlConnection(cString);

                string customerCommandText = "SELECT * FROM Customers";
                SqlDataAdapter customerAdapter = new SqlDataAdapter(customerCommandText, northwindConnection);

                string ordersCommandText = "SELECT * FROM Orders";
                SqlDataAdapter ordersAdapter = new SqlDataAdapter(ordersCommandText, northwindConnection);

                //Fill DataSet and define DataRelation
                DataSet customerOrders = new DataSet();
                customerAdapter.Fill(customerOrders, "Customers");
                ordersAdapter.Fill(customerOrders, "Orders");

                DataRelation relation = customerOrders.Relations.Add("CustomerOrders",
                    customerOrders.Tables["Customers"].Columns["CustomerID"],
                    customerOrders.Tables["Orders"].Columns["CustomerID"]);

                //Display Customer Orders
                foreach (DataRow customerRow in customerOrders.Tables["Customers"].Rows)
                {
                    Console.WriteLine(customerRow["CustomerID"]);
                    foreach (DataRow orderRow in customerRow.GetChildRows(relation))
                    {
                        Console.WriteLine("\t" + orderRow["OrderID"]);
                    }
                }

                Console.WriteLine("Press any key to continue . . .");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
