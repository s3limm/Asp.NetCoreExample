using Asp.NetCore_Example.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Asp.NetCore_Example.Controllers
{
    public class UserController : Controller
    {
        List<User> users = new List<User>() //Method 3
            {
                new User() {FirstName = "Yavuz",LastName = "Emrem"},
                new User() {FirstName = "İnci",LastName = "Emrem"},
                new User() {FirstName = "Kayra",LastName = "Şahin"},
                new User() {FirstName = "Jale",LastName = "Emrem"},
            };

        public IActionResult UseViewData()
        {

            ViewBag.User = "Yavuz"; //Method 1 

            User user = new User(); //Method 2
            user.FirstName = "Yavuz";
            user.LastName = "Emrem";
            ViewBag.UserName = user;

            ViewData["Users"] = users;        

            return View();
        }


        public IActionResult UseTempData()
        {
            TempData["name"] = "yavuz";
            return RedirectToAction("TempDatatest");
        }

        public IActionResult TempDataTest()
        {
            TempData.Keep("name");
            return View();
        }
    }
}
