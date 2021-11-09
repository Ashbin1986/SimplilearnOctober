using ECommerceWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ECommerceWebAPI.Controllers
{
    [RoutePrefix("api/products")]
    public class ProductController : ApiController
    {
        [HttpGet]
        [Route("details")]
        public HttpResponseMessage GetProducts()
        {
            //CustomerOrderRequest customerOrderRequest = new CustomerOrderRequest();
            //customerOrderRequest.InvoiceNumber = Guid.NewGuid().ToString();
            //customerOrderRequest.ProductId = 101;
            //customerOrderRequest.CustomerId = 101;

            //var str = Newtonsoft.Json.JsonConvert.SerializeObject(customerOrderRequest);

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
            catch (Exception ex)
            {
                productResponse.IsSuccess = false;
                productResponse.Error = new ErrorResponse();
                productResponse.Error.ErrorDescription = ex.StackTrace;
                return Request.CreateResponse<ProductResponse>(HttpStatusCode.InternalServerError, productResponse);
            }
        }

        [HttpPost]
        [Route("order")]
        public HttpResponseMessage SaveCustomerOrder(CustomerOrderRequest customerOrderRequest)
        {
            if(customerOrderRequest == null)
            {
                return Request.CreateResponse<string>(HttpStatusCode.BadRequest, "CustomerOrderRequest is null ");
            }
            CustomerOrderReponse customerOrderReponse = new CustomerOrderReponse();
            try
            {
                using (ECommerceDBEntities context = new ECommerceDBEntities())
                {

                    var productInformation = context.Products.Where(c => c.ProductId == customerOrderRequest.ProductId).FirstOrDefault();

                    if (productInformation != null)
                    {
                        var discountPrice = productInformation.Price * productInformation.Discount / 100;

                        var order = context.Orders.Add(new Order
                        {
                            CustomerId = customerOrderRequest.CustomerId,
                            InvoiceNumber = Guid.NewGuid().ToString(),
                            OrderedDate = DateTime.Now,
                            CreatedDate = DateTime.Now,
                            OrderPrice = productInformation.Price - discountPrice,
                            ProductId = customerOrderRequest.ProductId

                        });
                        context.SaveChanges();

                        customerOrderReponse.IsSuccess = true;
                        customerOrderReponse.OrderId = order.OrderId;
                    }
                }
                return Request.CreateResponse<CustomerOrderReponse>(HttpStatusCode.OK, customerOrderReponse);
            }
            catch (Exception ex)
            {
                customerOrderReponse.IsSuccess = false;
                return Request.CreateResponse<CustomerOrderReponse>(HttpStatusCode.InternalServerError, customerOrderReponse);
            }
        }

        [HttpPost]
        [Route("customerorders")]
        public HttpResponseMessage GetCustomerOrders(CustomerRequest customerOrderRequest)
        {
            CustomerOrdersList customerOrders = new CustomerOrdersList();
            try
            {
                using (ECommerceDBEntities context = new ECommerceDBEntities())
                {
                    var customer = context.Customers.Where(c => c.CustomerId == customerOrderRequest.Customerid).FirstOrDefault();

                    if (customer != null)
                    {
                        customerOrders.CustomerAddress = customer.CustomerAddress;
                        customerOrders.CustomerEmail = customer.CustomerEmail;
                        customerOrders.CustomerName = customer.CustomerName;
                        customerOrders.Orders = new List<CustomerOrders>();

                        var orders = context.Orders.Where(c => c.CustomerId == customerOrderRequest.Customerid).ToList();

                        if (orders != null && orders.Count > 0)
                        {
                            foreach (var o in orders)
                            {
                                var customerProduct = context.Products.Where(c => c.ProductId == o.ProductId).FirstOrDefault();

                                customerOrders.Orders.Add(new CustomerOrders
                                {
                                     
                                    InvoiceNumber = o.InvoiceNumber,
                                    OrderdPrice = o.OrderPrice,
                                    OrderedDate = o.OrderedDate,
                                    ProductName = customerProduct.ProductName,
                                    CategoryName = context.Categories.Where(c=>c.CategoryId == customerProduct.Product_CategoryId).FirstOrDefault().CategoryName,
                                     

                                });
                            }
                        }

                    }

                    customerOrders.IsSuccess = true;

                }
                return Request.CreateResponse<CustomerOrdersList>(HttpStatusCode.OK, customerOrders);
            }
            catch (Exception ex)
            {
                customerOrders.IsSuccess = false;
                return Request.CreateResponse<CustomerOrdersList>(HttpStatusCode.InternalServerError, customerOrders);
            }
        }
        [HttpGet]
        [Route("{empid:int:min(1):max(100)}")]
        public HttpResponseMessage GetEmployeeDetails(int empid)
        {
            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer { CustomerName = "Ashbin Kumar" });
            customers.Add(new Customer { CustomerName = "Ashbin Kumar" });
            return Request.CreateResponse<List<Customer>>(HttpStatusCode.OK, customers);
        }

    }
}