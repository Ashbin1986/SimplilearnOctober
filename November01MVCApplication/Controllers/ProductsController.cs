using November01MVCApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace November01MVCApplication.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AddProduct()
        {
            Products product = new Products();
            return View(product);
        }

        public ActionResult SaveProductItem(Products item)
        {
            if (ModelState.IsValid)
            {
                // Error Meesage
            }
            Products product = new Products();
            return View("AddProduct", product);

        }
    }
}