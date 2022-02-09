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

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        /*[HttpGet]
        public IActionResult Delete(int movieid)
        {
            ViewBag.Category = movieContext.Category.ToList();

            var movie = movieContext.Responses.Single(x => x.MovieId == movieid);

            return View(movie);
        }*/

        /*[HttpPost]
        public IActionResult Delete(MovieForm delete)
        {


            movieContext.Responses.Remove(delete);
            movieContext.SaveChanges();

            return RedirectToAction("MovieList");
        }*/
    }
}
