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

        public HomeController()
        { 
        }

        public IActionResult Index()
        {
            return View();
        }

        //public IActionResult TaskView()
        //{
        //    var Tasks = DbContext.Tasks
        //        .Where(x => x.Completed == false)
        //        .ToList();

        //    return View(Tasks);
        //}

        //[HttpGet]
        //public IActionResult Edit(int taskid)
        //{
        //    ViewBag.Categories = DbContext.Categories.ToList();

        //    var tasks = DbContext.Tasks.Single(x => x.TaskId == taskid);

        //    return View("TaskForm", tasks);
        //}

        //[HttpPost]
        //public IActionResult Edit(Tasks ta)
        //{
        //    DbContext.Update(ta);
        //    DbContext.SaveChanges();
        //    return RedirectToAction("TaskView");
        //}

        //[HttpGet]
        //public IActionResult Delete(int taskid)
        //{
        //    var tasks = DbContext.Tasks.Single(x => x.TaskId == taskid);
        //    return View(tasks);
        //}

        //[HttpPost]
        //public IActionResult Delete(Tasks ta)
        //{
        //    DbContext.Tasks.Remove(ta);
        //    DbContext.SaveChanges();

        //    return RedirectToAction("TaskView");
        //}

        //public IActionResult Confirmation()
        //{
        //    return View();
        //}

    }
}
