using CustomerApplication_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomerApplication_MVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ViewResult CustomerInput()
        {
            return View();
        }
        [HttpPost]
        public ViewResult CustomerInput(Customer c1)
        {
            if (ModelState.IsValid)
            { return View("CustomerDisplay", c1); }
            else
            { 
                return View();
            }
        }
    }

}
