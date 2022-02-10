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

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Quadrant()
        {
            var tasks = taskContext.Responses
                .Include(x => x.Quadrant)
                .Include(x => x.Category)
                .ToList();

            return View(tasks);
        }
        [HttpGet]
        public IActionResult AddTask()
        {
            ViewBag.Category = taskContext.Categories.ToList();
            ViewBag.Quadrants = taskContext.Quadrants.ToList();

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
                ViewBag.Quadrants = taskContext.Quadrants.ToList();
                return View(Response);
            }
        }
        [HttpGet]
        public IActionResult Edit(int taskid)
        {
            ViewBag.Category = taskContext.Categories.ToList();
            ViewBag.Quadrants = taskContext.Quadrants.ToList();

            var task = taskContext.Responses.Single(x => x.TaskId == taskid);

            return View("AddTask", task);
        }
        [HttpPost]
        public IActionResult Edit(TaskInputModel edit)
        {
            if (ModelState.IsValid)
            {
                taskContext.Update(edit);
                taskContext.SaveChanges();

                return RedirectToAction("Quadrant");
            }
            else
            {
                ViewBag.Category = taskContext.Categories.ToList();
                return View("AddTask", edit);
            }
        }
        [HttpGet]
        public IActionResult Delete(int taskid)
        {
            ViewBag.Category = taskContext.Categories.ToList();
            ViewBag.Quadrants = taskContext.Quadrants.ToList();

            var task = taskContext.Responses.Single(x => x.TaskId == taskid);

            return View("Delete", task);
        }
        [HttpPost]
        public IActionResult Delete(TaskInputModel delete)
        {
            
                taskContext.Responses.Remove(delete);
                taskContext.SaveChanges();

                return RedirectToAction("Quadrant");
           
        }
    }
}
