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
            var tasks = taskContext.Responses
                /*.Where()*/
                .OrderBy(x => x.Category)
                .ToList();
            var category = taskContext.Categories
                .ToList();
            var quadrant = taskContext.Quadrants
                .ToList();


            return View(tasks);
        }

        public IActionResult Quadrant()
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
        [HttpGet]
        public IActionResult EditTask(int taskid)
        {
            ViewBag.Category = taskContext.Categories.ToList();

            var task = taskContext.Responses.Single(x => x.TaskId == taskid);

            return View("AddTask", task);
        }
        [HttpPost]
        public IActionResult EditTask(TaskInputModel edit)
        {
            if (ModelState.IsValid)
            {
                taskContext.Update(edit);
                taskContext.SaveChanges();

                return RedirectToAction("AddTask");
            }
            else
            {
                ViewBag.Category = taskContext.Categories.ToList();
                return View("AddTask", edit);
            }
        }
        [HttpGet]
        public IActionResult DeleteTask(int taskid)
        {
            ViewBag.Category = taskContext.Categories.ToList();

            var task = taskContext.Responses.Single(x => x.TaskId == taskid);

            return View();
        }
        [HttpPost]
        public IActionResult DeleteTask(TaskInputModel delete)
        {
            
                taskContext.Responses.Remove(delete);
                taskContext.SaveChanges();

                return RedirectToAction("DeleteTask");
           
        }
    }
}
