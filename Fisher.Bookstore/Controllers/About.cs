using System;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{
    public class About : Controller
    {
        public IActionResult Index()
        {
            return View("About");
            
        }
        public IActionResult History()
        {
           return View("About");
            
        }
        public IActionResult Location()
        {
           return View("About");
        }

    }
}