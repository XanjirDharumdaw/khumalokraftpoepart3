
using Microsoft.AspNetCore.Mvc;
using KhumaloCraft.Models;
using System.Collections.Generic;

namespace KhumaloCraft.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AboutUs()
        {
            return View();
        }

        public IActionResult ContactUs()
        {
            return View();
        }

        public IActionResult MyWork()
        {
            var products = new List<Product>
            {
                new Product { Id = 1, Name = "Product 1", Price = 100.0M, ImageUrl = "url1" },
                new Product { Id = 2, Name = "Product 2", Price = 200.0M, ImageUrl = "url2" },
                new Product { Id = 3, Name = "Product 3", Price = 300.0M, ImageUrl = "url3" }
            };
            return View(products);
        }
    }
}
