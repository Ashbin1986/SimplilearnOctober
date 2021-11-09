using ECommerceWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Routing;

namespace ECommerceWebAPI.Controllers
{
    public class CustomerServiceController : ApiController
    {
        //[HttpGet]
        //public List<Customer> GetCustomers()
        //{
        //    List<Customer> customers = new List<Customer>();
        //    customers.Add(new Customer { CustomerName = "Ashbin Kumar" });
        //    customers.Add(new Customer { CustomerName = "Ashbin Kumar" });
        //    return customers;
        //}

        [HttpGet]
        public HttpResponseMessage GetCustomers()
        {
            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer { CustomerName = "Ashbin Kumar" });
            customers.Add(new Customer { CustomerName = "Ashbin Kumar" });
            return Request.CreateResponse<List<Customer>>(HttpStatusCode.OK, customers);
        }

        [HttpPost]
        public HttpResponseMessage AddCustomers([FromBody] Customer customer)
        {
            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer { CustomerName = "Ashbin Kumar" });
            customers.Add(new Customer { CustomerName = "Ashbin Kumar" });
            return Request.CreateResponse<List<Customer>>(HttpStatusCode.OK, customers);
        }

      


        [HttpDelete]
        public HttpResponseMessage DeleteCustomer([FromUri] int customerId)
        {
            using (ECommerceDBEntities context = new ECommerceDBEntities())
            {
                var customer = context.Customers.Where(c => c.CustomerId == customerId).FirstOrDefault();
                context.Customers.Remove(customer);
                context.SaveChanges();
            }
            return Request.CreateResponse<string>(HttpStatusCode.OK, "Record deleted successfully");
        }

        [HttpPut]
        public HttpResponseMessage UpdateCustomer([FromUri] int customerId , CustomerRequest customer)
        {
            using (ECommerceDBEntities context = new ECommerceDBEntities())
            {
                var customerInformation = context.Customers.Where(c => c.CustomerId == customerId).FirstOrDefault();
                
                if(customerInformation !=null)
                {
                    customerInformation.CustomerEmail = customer.CustomerEmail;
                }
                context.SaveChanges();
            }

            return Request.CreateResponse<string>(HttpStatusCode.OK, "Record updated successfully");
        }

        [HttpPatch]
        public HttpResponseMessage UpdateGetCustomer(Customer customer)
        {

            // upadte record in DB
            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer { CustomerName = "Ashbin Kumar" });
            customers.Add(new Customer { CustomerName = "Ashbin Kumar" });
            return Request.CreateResponse<List<Customer>>(HttpStatusCode.OK, customers);

        }
    }
}