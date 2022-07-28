using MVCSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCSample.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers/Index
        public ActionResult Index()
        {
            var customers = GetCustomers();
            return View(customers);
        }
        // GET: Customers/Details/id
        public ActionResult Details(int id)
        {
            var customer = GetCustomers().SingleOrDefault(c => c.Id == id);
            if (customer == null)
                return View("Error");

            return View(customer);
        }


        private IEnumerable<Customers> GetCustomers()
        {
            return new List<Customers>
           {
               new Customers { Id = 1, Name = "David"},
               new Customers { Id = 2, Name = "Kumaru"}
           };
        }
    }

}