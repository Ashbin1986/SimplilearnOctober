using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ECommerceWebAPI.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
    }

    public class ProductResponse
    {
        public List<Product> Products { get; set; }
        public decimal TotalProductPrice { get; set; }

        public bool IsSuccess { get; set; }
        public ErrorResponse Error { get; set; }
    }
}