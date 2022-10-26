using Asp.NetCore_Example.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Asp.NetCore_Example.Controllers
{
    public class UserController : Controller
    {
        public IActionResult UseViewBag()
        {

            ViewBag.User = "Yavuz"; //Method 1 

            User user = new User(); //Method 2
            user.FirstName = "Yavuz";
            user.LastName = "Emrem";
            ViewBag.UserName = user;



            List<User> users = new List<User>() //Method 3
            {
                new User() {FirstName = "Yavuz",LastName = "Emrem"},
                new User() {FirstName = "İnci",LastName = "Emrem"},
                new User() {FirstName = "Kayra",LastName = "Şahin"},
                new User() {FirstName = "Jale",LastName = "Emrem"},
            };
            ViewBag.Users = users;

            return View();
        }
    }
}
