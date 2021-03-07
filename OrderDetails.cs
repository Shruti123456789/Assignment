using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderLibrary
{
    public class OrderDetails
    {
        private int orderId;
        public int OrderId
        {
            get { return orderId; }
            set { orderId = value; }
        }

        int customerId;
        public int CustomerId
        {
            get { return customerId; }
            set { customerId = value; }
        }

        int productQuantity;
        public int ProductQuantity
        {
            get { return productQuantity; }
            set { productQuantity = value; }
        }
        float price;
        public float Price 
        {
            get { return price; }
            set { price = value; }
        }
        public OrderDetails()
        {
            Console.WriteLine("Inside Default Constructor");
        }
        public OrderDetails(int id) 
        {
            OrderId = id;
        }
        public OrderDetails(int id,int cid):this(id)
        {
            CustomerId = cid;
        }
        public OrderDetails(int id, int cid,int quant):this(id,cid)
        {
            ProductQuantity = quant;
        }
        public OrderDetails(int id, int cid, int quant,float price) : this(id, cid,quant)
        {
            Price = price;
        }
        static OrderDetails()
        {
            Console.WriteLine("Inside Static Constructor.I will be executed first");
        }
        public float CalculateExpense()
        {
            float ans = Price * ProductQuantity;
            return ans;

        }




    }
}
