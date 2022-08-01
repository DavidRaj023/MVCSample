using MVCSample.Models;
using MVCSample.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCSample.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext _context;
        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult New()
        {
            var membershipTypes = _context.MembershipTypes.ToList();
            var viewModel = new CustomerFormViewModel
            {
                MembershipTypes = membershipTypes
            };
            return View("CustomerForm", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Customers customers)
        {
            /*if (!ModelState.IsValid)
            {
                var viewModel = new CustomerFormViewModel
                {
                    Customers = customers,
                    MembershipTypes = _context.MembershipTypes.ToList()
                };
                return View("CustomerForm", viewModel);
            }*/
            _context.Customers.Add(customers);
            _context.SaveChanges();
            
            return RedirectToAction("index", "Customers");
        }

        public ActionResult Edit(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);
            if (customer == null)
                return HttpNotFound();

            var viewModel = new CustomerFormViewModel
            {
                Customers = customer,
                MembershipTypes = _context.MembershipTypes.ToList()
            };
            return View("Update", viewModel);
        }
        public ActionResult Update(CustomerFormViewModel model)
        {
            var customerInDb = _context.Customers.Single(c => c.Id == model.Customers.Id);

            customerInDb.Name = model.Customers.Name;
            customerInDb.BirthDate = model.Customers.BirthDate;
            customerInDb.MembershipTypeId = model.Customers.MembershipTypeId;
            customerInDb.IsSubscribedToNewsletter = model.Customers.IsSubscribedToNewsletter;

            _context.SaveChanges();
            return RedirectToAction("index", "Customers");
        }

        // GET: Customers/Index
        public ActionResult Index()
        {
            var customers = _context.Customers.Include(c => c.MembershipType).ToList();
            return View(customers);
        }
        // GET: Customers/Details/id
        public ActionResult Details(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);
            if (customer == null)
                return View("Error");

            return View(customer);
        }

        
    }

}