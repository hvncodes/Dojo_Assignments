using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RandomPasscode.Models;
using Microsoft.AspNetCore.Http;

namespace RandomPasscode.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            if (HttpContext.Session.GetInt32("Count") == null)
            {
                HttpContext.Session.SetInt32("Count", 0);
                Generate();
            }

            return View();
        }

        public IActionResult Generate()
        {
            int? current = HttpContext.Session.GetInt32("Count");
            HttpContext.Session.SetInt32("Count", (int)current + 1);
            string alphanumeral = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            Random rng = new Random(); //rng.Next(alphanumeral.Length);
            char[] passcode = new char[14];
            for (int i = 0; i < passcode.Length; i++)
            {
                int idxRngAlphaNum = rng.Next(alphanumeral.Length);
                // Console.WriteLine(idxRngAlphaNum);
                // Console.WriteLine(alphanumeral[idxRngAlphaNum]);
                // Console.WriteLine("----------------------");
                passcode[i] = alphanumeral[idxRngAlphaNum];
            }
            // Console.WriteLine(passcode);
            // Console.WriteLine(new string(passcode));
            HttpContext.Session.SetString("Passcode", new string(passcode));
            return RedirectToAction("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet("reset")]
        public RedirectToActionResult Reset()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }
    }
}
