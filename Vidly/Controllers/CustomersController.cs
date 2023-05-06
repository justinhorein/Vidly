using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
 
        // GET: Customers
        public ActionResult Index()
        {
            var customers = GetCustomers();

            return View(customers);
        }

        [Route("Customers/Details/{id}")]
        public ActionResult Details(int Id)
        {
            var customers = GetCustomers();

            foreach (Customer custy in customers) 
            {
                if (custy.Id == Id)
                    return View(custy);
            }

            return HttpNotFound();
        }

        private List<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer { Name = "John Smith", Id = 1 },
                new Customer { Name = "Mary Williams", Id = 2 }
            };
        }
    }
}