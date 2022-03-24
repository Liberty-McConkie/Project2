using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Project2.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Project2.Controllers
{
    public class HomeController : Controller
    {
        private TempleTourContext DbContext { get; set; }

        public HomeController(TempleTourContext temp)
        {
            DbContext = temp;
        }

        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public IActionResult SignUp()
        {
            var tourists = DbContext.Tourists.ToList();

            return View(tourists);
        }

        public IActionResult ViewAppointments()
        {
            var tourist = DbContext.Tourists.ToList();

            return View(tourist);
        }

        [HttpGet]
        public IActionResult TouristInfo(string appointmentstart)
        {
            ViewBag.Tourists = appointmentstart;

            return View();

            /*var x = appointmentstart;
            return View("TouristInfo");*/
        }
        [HttpPost]
        public IActionResult TouristInfo(Tourist to)
        {
            DbContext.Update(to);
            DbContext.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(int touristId)
        {
            ViewBag.TouristInfo = touristId;
            var appointment = DbContext.Tourists.Single(x => x.TouristId == touristId);
            return View("TouristInfo2", appointment);
        }
        [HttpPost]
        public IActionResult Edit(Tourist to)
        {
            DbContext.Update(to);
            DbContext.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Delete(int touristId)
        {
            var appointment = DbContext.Tourists.Single(x => x.TouristId == touristId);
            return View(appointment);
        }
        [HttpPost]
        public IActionResult Delete(Tourist to)
        {
            DbContext.Tourists.Remove(to);
            DbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Confirmation()
        {
            return View();
        }

    }
}
