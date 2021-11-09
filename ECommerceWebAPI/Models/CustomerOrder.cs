using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ECommerceWebAPI.Models
{
    public class CustomerOrderRequest
    {
        public int OrderId { get; set; }
        public string InvoiceNumber { get; set; }
        public Nullable<int> ProductId { get; set; }
        public Nullable<System.DateTime> OrderedDate { get; set; }
        
        [Required]
        public Nullable<int> CustomerId { get; set; }
        public Nullable<decimal> OrderPrice { get; set; }
    }

    public class CustomerOrderReponse
    {
        public int OrderId { get; set; }
        public bool IsSuccess { get; set; }
        public ErrorResponse Error { get; set; }
    }

    public class CustomerOrders
    {
        public string InvoiceNumber { get; set; }
        public string ProductName { get; set; }
        public string CategoryName { get; set; }
        public Nullable<decimal> OrderdPrice { get; set; }
        public Nullable<System.DateTime> OrderedDate { get; set; }
    
    }
}