using Asp.NetCore_Example.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Asp.NetCore_Example.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult GetItemsList()
        {

            List<Product> products = new List<Product>()
            {
                new Product() { Category = "Electronic", productName = "Television", price = 7000 },
                new Product() { Category = "Electronic", productName = "Phone", price = 5000 },
                new Product() { Category = "Fornuture", productName = "Chair", price = 1000 },
                new Product() { Category = "Food", productName = "Meat", price = 500 }
            };
            return View(products);
        }
    }
}
