using MRent.Models;
using MRent.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MRent.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {

            var customers = new List<Customer>()
            {
                //new Customer{Id = 1, Name = "Pranaya Shrestha" },
                //new Customer{Id = 2, Name = "Alexis Graham" },
                //new Customer{Id = 3, Name = "John Doe" }
            };

            var viewModel = new CustomerViewModel { Customers = customers };

            return View(viewModel);
        }

        public ActionResult Details(int Id)
        {
            var customers = new List<Customer>()
            {
                new Customer{Id = 1, Name = "Pranaya Shrestha" },
                new Customer{Id = 2, Name = "Alexis Graham" },
                new Customer{Id = 3, Name = "John Doe" }
            };

            foreach (var customer in customers)
            {
                if (customer.Id == Id)
                {
                    return View(customer);
                }
            }
            return HttpNotFound();
        }
    }
}