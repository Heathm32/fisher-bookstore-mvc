using System;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{
    public class Authors : Controller
    {
        public IActionResult Index()
        {
            return Content("Hello World");

           
        }
        public IActionResult Featured()
        {
            return Content("Hello World");
            
        }
        
    }
}