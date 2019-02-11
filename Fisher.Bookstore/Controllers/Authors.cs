using System;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{
    public class Authors : Controller
    {
        public IActionResult Index()
        {
            return View();

           
        }
        public IActionResult Featured()
        {
            // we would normally get this from a database

            var featuredAuthor = new Models.Author(){
                AuthorId =1,
                Name = "J.K. Rowling"
            };

            return View(featuredAuthor);
            
        }
        
    }
}