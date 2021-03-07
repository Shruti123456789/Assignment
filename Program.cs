using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderLibrary;
namespace Order
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderDetails o = new OrderDetails();
            OrderDetails o1 = new OrderDetails(1);
            Console.WriteLine("Order Id=" + o1.OrderId);
            OrderDetails o2 = new OrderDetails(2, 2);
            Console.WriteLine("Order Id=" + o2.OrderId);
            Console.WriteLine("Consumer Id=" + o2.CustomerId);
            Console.WriteLine("Product Quantity=" + o2.ProductQuantity);
            Console.WriteLine("price of commodity=" + o2.Price);
            Console.WriteLine("Total Expense=" + o2.CalculateExpense());
            OrderDetails o3 = new OrderDetails(3, 3, 8);
            Console.WriteLine("Order Id=" + o3.OrderId);
            Console.WriteLine("Consumer Id=" + o3.CustomerId);
            Console.WriteLine("Product Quantity=" + o3.ProductQuantity);
            Console.WriteLine("price of commodity=" + o3.Price);
            Console.WriteLine("Total Expense=" + o3.CalculateExpense());
            OrderDetails o4 = new OrderDetails(4,2,10,10000);
            Console.WriteLine("Order Id="+ o4.OrderId);
            Console.WriteLine("Consumer Id="+ o4.CustomerId);
            Console.WriteLine("Product Quantity="+o4.ProductQuantity);
            Console.WriteLine("price of commodity="+o4.Price);
            Console.WriteLine("Total Expense="+o4.CalculateExpense());
            Console.Read();


        }
    }
}
