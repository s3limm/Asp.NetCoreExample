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
                new Product() { category = "Electronic", name = "Television", price = 7000 },
                new Product() { category = "Electronic", name = "Phone", price = 5000 },
                new Product() { category = "Fornuture", name = "Chair", price = 1000 },
                new Product() { category = "Food", name = "Meat", price = 500 }
            };
            return View(products);
        }
    }
}
