using System;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{
    public class About : Controller
    {
        public IActionResult Index()
        {
            return Content("This is the About controller's Index action");
            
        }
        public IActionResult History()
        {
            return Content("This is the About controller's history");
            
        }
        public IActionResult Location()
        {
            return Content("This is the About controller's location");
            
        }

    }
}