using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ECommerceWebAPI.Models
{
    public class CustomerRequest
    {
        public int Customerid { get; set; }

        public string CustomerEmail { get; set; }
    }

    public class CustomerOrdersList
    {
        //public int Customerid { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerAddress { get; set; }

        public List<CustomerOrders> Orders { get; set; }
        public bool IsSuccess { get; set; }
        public ErrorResponse Error { get; set; }
    }
}