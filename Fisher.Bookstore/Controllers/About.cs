using System;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{
    public class About : Controller
    {
        public IActionResult Index()
        {
            return View();
            
        }
        public IActionResult History()
        {
           return View();
            
        }
        public IActionResult Location()
        {
           return View();
        }

    }
}