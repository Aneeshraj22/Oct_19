using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerOrderService
{
    public enum CustomerType
    {
        Basic, Premimum, Gold
    }
    public class Customer
    {
        public int CustId { get; set; }

        public string CustName { get; set; }

        public CustomerType CustomerType { get; set; }

    }

    public class Order
    {
        public int OrderId { get; set; }

        public int ProductId { get; set; }

        public int Qty { get; set; }

        public double Amount { get; set; }
    }

    public class CustomerOrder
    {
        public void Discount(Customer c, Order o)
        {
            if (c.CustomerType == CustomerType.Premimum)
            {
                o.Amount = o.Amount - (o.Amount * 10 / 100);
            }
            else if (c.CustomerType == CustomerType.Gold)
            {
                o.Amount = o.Amount - (o.Amount * 20 / 100);
            }
        }
    }
}