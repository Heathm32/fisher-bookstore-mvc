using System;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{
    [Route("books")]
    public class Books : Controller
    {
        [Route("")]
        [Route("index")]
        public IActionResult Index()
        {
            return View("Books");

           
        }
        [Route("new")]
        public IActionResult New()
        {
            return View("Books");
            
        }
        [Route("best-sellers")]
        public IActionResult Best()
        {
            return View("Books/best-sellers Page");
            
        }
    }
}