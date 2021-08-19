using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ChefsAndDishes.Models;
// using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace ChefsAndDishes.Controllers
{
    public class HomeController : Controller
    {
        private ChefsAndDishesContext db;
        public HomeController(ChefsAndDishesContext context)
        {
            db = context;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            List<Chef> Chefs = db.Chefs
            .Include(chef => chef.Dishes)
            .ToList();
            DateTime dt = DateTime.Now;
            ViewBag.dt = dt;
            return View("Index", Chefs);
        }

        [HttpGet("/new")]
        public IActionResult New()
        {
            return View("New");
        }

        [HttpPost("/new")]
        public IActionResult Create(Chef newChef)
        {
            if (ModelState.IsValid == false)
            {
                return View("New");
            }
            if (newChef.DateOfBirth >= DateTime.Now)
            {
                ModelState.AddModelError("DateOfBirth", "must be a past date.");
                return View("New");
            }
            if (DateTime.Now.Year - newChef.DateOfBirth.Year < 18)
            {
                ModelState.AddModelError("DateOfBirth", "must be 18 y/o or older");
                return View("New");
            }
            db.Add(newChef);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet("/dish")]
        public IActionResult Dish()
        {
            List<Dish> AllDishes = db.Dishes
            .Include(d => d.Author)
            .ToList();
            return View("Dishes", AllDishes);
        }

        [HttpGet("/dish/new")]
        public IActionResult NewDish()
        {
            List<Chef> AllChefs = db.Chefs
            .ToList();
            ViewBag.AllChefs = AllChefs;
            return View("NewDish");
        }

        [HttpPost("/dish/new/")]
        public IActionResult CreateDish(Dish newDish)
        {
            if (ModelState.IsValid == false)
            {
                List<Chef> AllChefs = db.Chefs
                .ToList();
                ViewBag.AllChefs = AllChefs;
                return View("NewDish");
            }
            
            db.Add(newDish);
            db.SaveChanges();
            return RedirectToAction("Dish");
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
    }
}
