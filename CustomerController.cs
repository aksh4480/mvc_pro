using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace first__MVC.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            var customers = new List<string>()
            {
                "Rishabh",
                "Arjun",
                "Himan",
                "Krish"

            };
            ViewBag.customers = customers;
            return View();
        }
    }
}