using System;
using Microsoft.AspNetCore.Mvc;

namespace ASPIntro
{
    public class HomeController : Controller
    {
        // Requests
        // localhost:5000/
        [HttpGet("")]
        public ViewResult Index()
        {
            // Views/Home/Index.cshtml
            // Views/Shared/Index.cshtml
            // return View();
            // return View("Index");
            ViewBag.Example = "Hello World!";
            return View("Index");
        }

        // localhost:5000/hello
        [HttpGet("hello")]
        public string Hello()
        {
            return "Hi again";
        }

        // localhost:5000/projects
        [HttpGet("projects")]
        public string Projects()
        {
            return "These are my projects!";
        }

        // localhost:5000/contact
        [HttpGet("contact")]
        public string Contact()
        {
            return "This is my Contact!";
        }

        // localhost:5000/user/Bob/Seattle/25
        [HttpGet("user/{name}/{location}/{age}")]
        public string UserInfo(string name, string location, int age)
        {
            return $"{name}, aged {age}, is from {location}";
        }

        [HttpPost("other/process")]
        public RedirectToActionResult Method() //IActionResult
        {
            // The anonymous object consists of keys and values
            // The keys should match the parameter names of the method being redirected to
            return RedirectToAction("OtherMethod", new { Food = "sandwiches", Quantity = 5 });
        }
        
        [HttpGet("other/{Food}/{Quantity}")]
        public ViewResult OtherMethod(string Food, int Quantity)
        {
            Console.WriteLine($"I ate {Quantity} {Food}.");
            // Writes "I ate 5 sandwiches."
            return View("Index");
        }
    }
}