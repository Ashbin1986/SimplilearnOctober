using ECommerceWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ECommerceWebAPI.Controllers
{
    public class ProductController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage GetProducts()
        {
            ProductResponse productResponse = new ProductResponse();
            productResponse.Products = new List<Models.Product>();
            try
            {
                using (ECommerceDBEntities context = new ECommerceDBEntities())
                {
                    var prods = context.Products.ToList();
                    foreach (var item in prods)
                    {
                        productResponse.Products.Add(new Models.Product
                        { ProductId = item.ProductId, ProductName = item.ProductName, Price = Convert.ToDecimal(item.Price) });
                    }
                    productResponse.TotalProductPrice = productResponse.Products.Sum(c => c.Price);
                    productResponse.IsSuccess = true;
                    return Request.CreateResponse<ProductResponse>(HttpStatusCode.OK, productResponse);
                }
            }
            catch(Exception ex)
            {
                productResponse.IsSuccess = false;
                productResponse.Error = new ErrorResponse();
                productResponse.Error.ErrorDescription = ex.StackTrace;
                return Request.CreateResponse<ProductResponse>(HttpStatusCode.InternalServerError, productResponse);

            }
        }
    }
}