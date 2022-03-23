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

       
=======
        public IActionResult ViewAppointments()
        {
            return View();
        }

        [HttpGet]
        public IActionResult TouristInfo(string appointmentstart)
        {
            ViewBag().DateTime = appointmentstart;
            return View();
        }
        [HttpPost]
        public IActionResult TouristInfo(Tourist to)
        {
            DbContext.Update(to);
            DbContext.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(string appointmentstart)
        {
            ViewBag().TouristInfo = DbContext.Tourists.ToList();
            var appointment = DbContext.Tourists.Single(x => x.AppointmentStart == appointmentstart);
            return View("TouristInfo", appointment);
        }
        [HttpPost]
        public IActionResult Edit(Tourist to)
        {
            DbContext.Update(to);
            DbContext.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Delete(string appointmentstart)
        {
            var appointment = DbContext.Tourists.Single(x => x.AppointmentStart == appointmentstart);
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
