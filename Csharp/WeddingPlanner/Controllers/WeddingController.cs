using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WeddingPlanner.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace WeddingPlanner.Controllers
{
    public class WeddingController : Controller
    {
        private WeddingPlannerContext db;
        public WeddingController(WeddingPlannerContext context)
        {
            db = context;
        }

        private int? uid
        {
            get
            {
                return HttpContext.Session.GetInt32("UserId");
            }
        }

        private bool isLoggedIn
        {
            get
            {
                return uid != null;
            }
        }

        [HttpGet("/dashboard")]
        public IActionResult Dashboard()
        {
            if (!isLoggedIn)
            {
                return RedirectToAction("Index", "Home");
            }

            var AllWeddings = db.Weddings
            .Include(w => w.UserWeddings)
            .ThenInclude(uw => uw.User)
            .ToList();
            ViewBag.AllWeddings = AllWeddings;
            return View("Dashboard");
        }

        [HttpGet("/wedding/{wedId}")]
        public IActionResult Wedding(int wedId)
        {
            if (!isLoggedIn)
            {
                return RedirectToAction("Index", "Home");
            }

            Wedding oneWedding = db.Weddings
            .Include(w => w.UserWeddings)
            .ThenInclude(uw => uw.User)
            .FirstOrDefault(w => w.WeddingId == wedId);
            return View("OneWedding", oneWedding);
        }

        [HttpGet("/wedding/new")]
        public IActionResult NewWedding()
        {
            if (!isLoggedIn)
            {
                return RedirectToAction("Index", "Home");
            }

            return View("NewWedding");
        }

        [HttpPost("/wedding/create")]
        public IActionResult CreateWedding(Wedding newWed)
        {
            if (ModelState.IsValid == false)
            {
                return View("NewWedding");
            }

            if (newWed.WeddingDate <= DateTime.Now) // if past date, error
            {
                ModelState.AddModelError("WeddingDate", "must be a future date.");
                return View("NewWedding");
            }
            newWed.UserId = (int)uid;
            db.Add(newWed);
            db.SaveChanges();
            return RedirectToAction("Dashboard", "Wedding");
        }

        [HttpPost("/wedding/{weddingId}/rsvp")]
        public IActionResult RsvpWedding(int weddingId)
        {
            if (!isLoggedIn)
            {
                return RedirectToAction("Index", "Home");
            }

            UserWedding existingRsvp = db.UserWeddings
            .FirstOrDefault(uw => uw.UserId == (int)uid && uw.WeddingId == weddingId);

            if (existingRsvp == null)
            {
                UserWedding rsvp = new UserWedding()
                {
                    WeddingId = weddingId,
                    UserId = (int)uid
                };

                db.UserWeddings.Add(rsvp);
            }
            else
            {
                db.UserWeddings.Remove(existingRsvp);
            }

            db.SaveChanges();
            return RedirectToAction("Dashboard", "Wedding");
        }

        [HttpPost("/wedding/{weddingId}/delete")]
        public IActionResult DeleteWedding(int weddingId)
        {
            if (!isLoggedIn)
            {
                return RedirectToAction("Index", "Home");
            }

            Wedding toDelete = db.Weddings.FirstOrDefault(w => w.WeddingId == weddingId);

            if (toDelete == null)
            {
                return RedirectToAction("Dashboard", "Wedding");
            }

            db.Weddings.Remove(toDelete);
            db.SaveChanges();
            return RedirectToAction("Dashboard", "Wedding");
        }
    }
}