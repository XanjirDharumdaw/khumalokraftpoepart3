using KhumaloCraft.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace KhumaloCraft.Controllers
{
    public class MyWorkController : Controller
    {
        public IActionResult Index()
        {
            var products = GetProductsFromDatabase();

            return View(products);
        }

        private List<Product> GetProductsFromDatabase()
        {
            var rand = new Random();
            var products = new List<Product>
            {
                new Product { Id = 1, Name = "Product 1", Price = Math.Round(Convert.ToDecimal(rand.NextDouble() * 5000), 2), ImageUrl = "/images(4)/product1.jpg" },
                new Product { Id = 2, Name = "Product 2", Price = Math.Round(Convert.ToDecimal(rand.NextDouble() * 5000), 2), ImageUrl = "/images(4)/product2.jpg" },
                new Product { Id = 3, Name = "Product 3", Price = Math.Round(Convert.ToDecimal(rand.NextDouble() * 5000), 2), ImageUrl = "/images(4)/product3.jpg" }
            };
            return products;
        }
    }
}
