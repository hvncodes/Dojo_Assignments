using System;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using DojoSurvey.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http; // to use Session

namespace DojoSurvey
{
    public class SurveyController : Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            DateTime dt = DateTime.Now;
            ViewBag.dt = dt;
            return View("Index");
        }

        [HttpPost("survey")]
        public IActionResult Submission(Survey yourSurvey)
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("Result", yourSurvey);
            }
            else
            {
                DateTime dt = DateTime.Now;
                ViewBag.dt = dt;
                return View("Index");
            }
        }

        [HttpGet("result")]
        public ViewResult Result(Survey yourSurvey)
        {
            return View("Result", yourSurvey);
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