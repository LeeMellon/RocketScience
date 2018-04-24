using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RocketScience.Models;

namespace RocketScience.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetFuel(string name, float tonnage, string destinationName, float finalSpeed)
        {
            Rocket newRocket = new Rocket
            {
                Name = name,
                Tonnage = tonnage,
                FinalSpeed = finalSpeed,
                DestinationName = destinationName
            };

            ViewBag.fuelResult = newRocket.GetFuel();

            return RedirectToAction("Index");
        }

        public IActionResult getCrew(double days, double tasks)
        {
            Rocket newRocket = new Rocket { };
            var result = newRocket.GetCrew(days, tasks);
            return View(result);
        }

        public IActionResult getDistance(double startLat, double startLong, double endLat, double endLong)
        {
            Rocket newRocket = new Rocket { };
            var result = newRocket.GetDistance(startLat, startLong, endLat, endLong);
            return View(result);
        }
    }
}
