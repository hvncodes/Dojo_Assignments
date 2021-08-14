using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CRUDelicious.Models;
using Microsoft.AspNetCore.Http;

namespace CRUDelicious.Controllers
{
    public class HomeController : Controller
    {
        private MyContext _context;

        // here we can "inject" our context service into the constructor
        public HomeController(MyContext context)
        {
            _context = context;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            // List<Dish> AllDishes = _context.Dishes.ToList();
            // return View("Index", AllDishes);
            // HttpContext.Session.SetInt32("userID", 1);
            // Console.WriteLine();
            List<Dish> RecentFiveDishes = _context.Dishes
                .OrderByDescending(d => d.CreatedAt)
                .Take(5)
                .ToList();
            return View("Index", RecentFiveDishes);
        }

        [HttpGet("dishes/{dishId}")]
        public IActionResult OneDish(int dishId)
        {
            Dish OneDish = _context.Dishes.SingleOrDefault(d => d.DishId == dishId);;
            return View("OneDish", OneDish);
        }

        [HttpGet("dishes/new")]
        public IActionResult New()
        {
            return View("New");
        }

        [HttpPost("dishes/process")]
        public IActionResult Create(Dish newDish)
        {
            if (ModelState.IsValid)
            {
                _context.Add(newDish);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("New");
        }

        [HttpGet("dishes/{dishId}/edit")]
        public IActionResult Edit(int dishId)
        {
            Dish OneDish = _context.Dishes.SingleOrDefault(d => d.DishId == dishId);;
            return View("Edit", OneDish);
        }

        [HttpPost("dishes/{dishId}/update")]
        public IActionResult Update(int dishId, Dish upDish)
        {
            // Take stuff from params
            // Query for a single Dish from our MyContext object to track changes
            Dish RetrievedDish = _context.Dishes
                .FirstOrDefault(d => d.DishId == dishId);
            // Then we may modify properties of this tracked model object
            RetrievedDish.Name = upDish.Name;
            RetrievedDish.Chef = upDish.Chef;
            RetrievedDish.Calories = (int)upDish.Calories;
            RetrievedDish.Tastiness = (int)upDish.Tastiness;
            RetrievedDish.Description = upDish.Description;
            RetrievedDish.UpdatedAt = DateTime.Now;
    
            // Finally, .SaveChanges() will update the DB with these new values
            _context.SaveChanges();
            return RedirectToAction("Edit", dishId);
        }

        [HttpGet("dishes/{dishId}/delete")]
        public IActionResult Delete(int dishId)
        {
            Dish RetrievedDish = _context.Dishes
                .FirstOrDefault(d => d.DishId == dishId);
            _context.Remove(RetrievedDish);
            _context.SaveChanges();
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
    }
}
