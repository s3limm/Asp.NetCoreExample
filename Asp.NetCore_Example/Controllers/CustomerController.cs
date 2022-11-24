using Asp.NetCore_Example.Models;
using Asp.NetCore_Example.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Asp.NetCore_Example.Controllers
{
    public class CustomerController : Controller
    {
        List<Customer> customer = new List<Customer>()
        {
            new Customer(){FirstName="Yavuz" , LastName="Emrem"},
            new Customer(){FirstName="Kayra" , LastName="Şahin"},
            new Customer(){FirstName="Yasin" , LastName="Kaya"}
        };

        public IActionResult UseViewModel()
        {
            Product product = new Product();
            product.name = "Telefon";
            product.category = "Elektronik";
            product.price = 1000;

            string date = DateTime.Now.ToString();

            CustomerAndProductVM cap = new CustomerAndProductVM();
            cap.customers = customer;
            cap.products = product;
            cap.date = date;

            return View(cap);
        }
    }
}
