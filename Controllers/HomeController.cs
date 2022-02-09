using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Project6.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Project6.Controllers
{
    public class HomeController : Controller
    {
        private TaskInputContext taskContext { get; set; }

        public HomeController(TaskInputContext applications)
        {
            taskContext = applications;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        [HttpGet]
        public IActionResult AddTask()
        {
            ViewBag.Category = taskContext.Categories.ToList();
            return View();
        }
        [HttpPost]
        public IActionResult AddTask(TaskInputModel Response)
        {
            if (ModelState.IsValid)
            {
                taskContext.Add(Response);
                taskContext.SaveChanges();
                return RedirectToAction("AddTask", Response);
            }
            else
            {
                ViewBag.Category = taskContext.Categories.ToList();
                return View(Response);
            }
        }

        
    }
}
