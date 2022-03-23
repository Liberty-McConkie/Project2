using Microsoft.AspNetCore.Mvc;
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
            


            return View();
        }

    }
}
