using System;
using Microsoft.AspNetCore.Mvc;

namespace Portfolio2
{
    public class ProfileController : Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            return View("Index");
        }

        [HttpGet("projects")]
        public ViewResult Projects()
        {
            return View("Projects");
        }

        [HttpGet("contact")]
        public ViewResult Contact()
        {
            return View("Contact");
        }
    }
}