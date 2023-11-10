using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DatabaseFirstApproach.Models;

namespace DatabaseFirstApproach.Controllers
{
    public class CustomersController : Controller
    {
        public NorthwindEntities db = new NorthwindEntities(); 
        // GET: Customers
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CustomersGermany()
        {
            var cust = db.Customers.Where(g => g.Country == "Germany");
            return View(cust);
        }
        public ActionResult CustomersOrderID()
        {
            var customerId = db.Orders
           .Where(ord => ord.OrderID == 10248)
           .Select(ord => ord.CustomerID)
           .FirstOrDefault();

            var customerDetails = db.Customers
            .Where(cus => cus.CustomerID == customerId)
            .FirstOrDefault();

            return View(customerDetails);
        }
    }
}