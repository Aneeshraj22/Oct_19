using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit;
using NUnit.Framework;
using System.Configuration;
using System.ComponentModel.Design;
using CustomerOrderService;

namespace CustomerOrderService.Tests
{
    public class class1
    {
        [TestCase]
        public void When_Gold_20percent()
        {
            Customer c = new Customer();
            c.CustId = 101;
            c.CustName = "Anee";
            c.CustomerType = CustomerType.Gold;
            Order order = new Order();
            order.OrderId = 1;
            order.ProductId = 2;
            order.Qty = 5;
            order.Amount = 100;

            CustomerOrder co = new CustomerOrder();
            co.Discount(c, order);
            Assert.AreEqual(order.Amount, 80);

        }
        public void Get_customer_list()
        {
            SqlConnection cn= new SqlConnection(ConfigurationManager.ConnectionStrings["Mycontext"].ConnectionString);
            cn.Open();
            SqlCommand cmd=new SqlCommand("Select * from Customers",cn);
            List<Customer> custList1 = new List<Customer>();


            SqlDataReader dr =cmd.ExecuteReader();
            while (dr.Read())
            {
                Customer cust = new Customer();
                cust.CustName = dr["Name"].ToString();
                cust.CustId = dr[0].GetHashCode();
                

            }


        }
    }
}
