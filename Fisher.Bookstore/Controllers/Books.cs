using System;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{
    public class Books : Controller
    {
        public IActionResult Index()
        {
            return Content("Hello World");

           
        }
        public IActionResult New()
        {
            return Content("Hello World");
            
        }
        
        public IActionResult Best()
        {
            return Content("Hello World");
            
        }
    }
}