﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CRUDelicious.Models;

namespace CRUDelicious.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        // public HomeController(ILogger<HomeController> logger)
        // {
        //     _logger = logger;
        // }

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
            List<Dish> RecentFiveDishes = _context.Dishes
                .OrderByDescending(d => d.CreatedAt)
                .Take(5)
                .ToList();
            return View("Index", RecentFiveDishes);
        }

        [HttpGet("/{dishId}")]
        public IActionResult OneDish(int dishId)
        {
            Dish OneDish = _context.Dishes.SingleOrDefault(d => d.DishId == dishId);;
            return View("OneDish", OneDish);
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
