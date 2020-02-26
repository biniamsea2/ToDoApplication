using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDoWebApp.Models;
using ToDoWebApp.Models.Interfaces;

namespace ToDoWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITaskManager _context;
        public HomeController(ITaskManager task)
        {
            _context = task;
        }

        public async Task <IActionResult> Index()
        {
            return View(await _context.GetTasksAsync());
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
