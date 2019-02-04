using System;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{
    public class About : Controller
    {
        public IActionResult Index()
        {
            return View("About Page");
            
        }
        public IActionResult History()
        {
           return View("About Page");
            
        }
        public IActionResult Location()
        {
           return View("About Page");
        }

    }
}