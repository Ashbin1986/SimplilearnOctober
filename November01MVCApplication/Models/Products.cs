using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace November01MVCApplication.Models
{
    public class Products
    {
        [Required(ErrorMessage = "Id is required")]
        public string ProductId { get; set; }
        [Required]
        [StringLength(10,ErrorMessage = "Productname should not more than 10 chars!")]
        public string ProductName { get; set; }
        public string ProductCategory { get; set; }
        public string ProductPrice { get; set; }

        [Range(1,10,ErrorMessage = "Max discount is allowed upto 10%")]
        public string Discount { get; set; }
        public string DiscountedPrice { get; set; }
        public HttpPostedFileBase fileUpload { get; set; }
    }

    public class Category
    {
        public int CatId { get; set; }
        public string CategoryName { get; set; }
    }
    public class ProductCategoryResponseModel
    {
       public List<Category> Categories { get; set; }
        public List<Products> Products { get; set; }

    }
}