using System;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using DojoSurvey.Models;
using System.Collections.Generic;

namespace DojoSurvey
{
    public class SurveyController : Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            DateTime dt = DateTime.Now;
            ViewBag.dt = dt;
            string header = "The current time and date:";
            return View("Index", header);
        }

        [HttpPost("process")]
        public IActionResult Result(string Name, string Location, string Language, string Comment)
        {
            ViewBag.Name = Name;
            ViewBag.Location = Location;
            ViewBag.Language = Language;
            ViewBag.Comment = Comment;
            return View("Result");
        }

        [HttpGet("numbers")]
        public ViewResult Numbers()
        {
            int[] numbers = new int[]
            {
                1, 2, 3, 10, 43, 5
            };
            return View("Numbers", numbers);
        }

        [HttpGet("user")]
        public IActionResult SoleUser()
        {
            User someUser = new User()
            {
                LastName = "Ever",
                FirstName = "Greatest"
            };
            return View("User", someUser);
        }

        [HttpGet("users")]
        public IActionResult Users()
        {
            User someUser = new User()
            {
                FirstName = "Thomas",
                LastName = "Anderson"
            };
            User otherUser = new User()
            {
                FirstName = "Agent",
                LastName = "Smith"
            };
            User anotherUser = new User()
            {
                FirstName = "Morpheus"
            };
            List<User> users = new List<User>()
            {
                someUser, otherUser, anotherUser
            };
            return View("Users", users);
        }
    }
}