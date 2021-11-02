using November01MVCApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace November01MVCApplication.Controllers
{
    public class FlipkartController : Controller
    {
        // GET: Flipkart
        public ActionResult Index()
        {
            List<Products> lstProducts = new List<Products>();
            lstProducts.Add(new Products { ProductId = "10001", ProductName = "Laptop", ProductCategory = "Electronics", Discount = "10%", ProductPrice = "800$", DiscountedPrice = "720$" });
            lstProducts.Add(new Products { ProductId = "10002", ProductName = "Keyboard", ProductCategory = "Electronics", Discount = "5%", ProductPrice = "10$", DiscountedPrice = "9.5$" });

            ViewData["Products"] = lstProducts;

            ViewBag.MyProducts = lstProducts;
            return View();
        }

        public ActionResult ViewProductsCat()
        {
            List<Products> lstProducts = new List<Products>();
            lstProducts.Add(new Products { ProductId = "10001", ProductName = "Laptop", ProductCategory = "Electronics", Discount = "10%", ProductPrice = "800$", DiscountedPrice = "720$" });
            lstProducts.Add(new Products { ProductId = "10002", ProductName = "Keyboard", ProductCategory = "Electronics", Discount = "5%", ProductPrice = "10$", DiscountedPrice = "9.5$" });

            List<Category> categories = new List<Category>();
            categories.Add(new Category { CatId = 101 , CategoryName ="Electronics" });

            ProductCategoryResponseModel productCategoryResponseModel = new ProductCategoryResponseModel()
            {
                Categories = categories,
                Products = lstProducts
            };
            return View(productCategoryResponseModel);
        }
    }
}