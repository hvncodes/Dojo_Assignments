using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportsORM.Models;


namespace SportsORM.Controllers
{
    public class HomeController : Controller
    {

        private static Context _context;

        public HomeController(Context DBContext)
        {
            _context = DBContext;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            ViewBag.BaseballLeagues = _context.Leagues
                .Where(l => l.Sport.Contains("Baseball"))
                .ToList();
            return View();
        }

        [HttpGet("level_1")]
        public IActionResult Level1()
        {
            ViewBag.WomensLeagues = _context.Leagues
                .Where(w => w.Name.Contains("Women"))
                .ToList();

            ViewBag.HockeyLeagues = _context.Leagues
                .Where(h => h.Sport.Contains("Hockey"))
                .ToList();

            ViewBag.NotFootballLeagues = _context.Leagues
                .Where(nf => !nf.Sport.Contains("Football"))
                .ToList();

            ViewBag.Conferences = _context.Leagues
                .Where(c => c.Name.Contains("Conference"))
                .ToList();

            ViewBag.AtlanticRegion = _context.Leagues
                .Where(ar => ar.Name.Contains("Atlantic"))
                .ToList();
            
            ViewBag.Dallas = _context.Teams
                .Where(d => d.Location == "Dallas")
                .ToList();
            
            ViewBag.Raptors = _context.Teams
                .Where(r => r.TeamName == "Raptors")
                .ToList();
            // ...all teams whose location includes "City"
            ViewBag.Cities = _context.Teams
                .Where(ct => ct.Location.Contains("City"))
                .ToList();
            // ...all teams whose names begin with "T"
            ViewBag.TTeams = _context.Teams
                .Where(tt => tt.TeamName.StartsWith("T"))
                .ToList();
            // ...all teams, ordered alphabetically by location
            ViewBag.AllTeams = _context.Teams
                .OrderBy(loc => loc.Location)
                .ToList();
            // ...all teams, ordered by team name in reverse alphabetical order
            ViewBag.ReverseTeamName = _context.Teams
                .OrderByDescending(rn => rn.TeamName)
                .ToList();
            // ...every player with last name "Cooper"
            ViewBag.Coopers = _context.Players
                .Where(coop => coop.LastName == "Cooper")
                .ToList();
            // ...every player with first name "Joshua"
            ViewBag.Joshuas = _context.Players
                .Where(josh => josh.FirstName == "Joshua")
                .ToList();
            // ...every player with last name "Cooper" EXCEPT those with "Joshua" as the first name
            ViewBag.CoopersNotJoshua = _context.Players
                .Where(cnoj => cnoj.LastName == "Cooper" && cnoj.FirstName != "Joshua")
                .ToList();
            // ...all players with first name "Alexander" OR first name "Wyatt"
            ViewBag.AlexanderOrWyatt = _context.Players
                .Where(aorw => aorw.FirstName == "Alexander" || aorw.FirstName == "Wyatt")
                .ToList();
            return View();
        }

        [HttpGet("level_2")]
        public IActionResult Level2()
        {
            return View();
        }

        [HttpGet("level_3")]
        public IActionResult Level3()
        {
            return View();
        }

    }
}