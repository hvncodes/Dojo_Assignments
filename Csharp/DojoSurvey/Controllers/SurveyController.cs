using System;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;

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

        [HttpPost("process")]
        public IActionResult Method(string Name, string Location, string Language, string Comment)
        {
            ViewBag.Name = Name;
            ViewBag.Location = Location;
            ViewBag.Language = Language;
            ViewBag.Comment = Comment;
            return View("Result");
        }


    }
}