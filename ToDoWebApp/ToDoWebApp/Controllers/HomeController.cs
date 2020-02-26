using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ToDoWebApp.Models;
using ToDoWebApp.Models.Interfaces;

namespace ToDoWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITaskManager _context;
        public HomeController(ITaskManager context)
        {
            _context = context;
        }

        #region Index
        public async Task<IActionResult> Index()
        {
            return View(await _context.GetTasksAsync());
        }
        #endregion

        #region Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Task,Priority,Completed,DueDate")] ToDoList item)
        {
            if (ModelState.IsValid)
            {
                await _context.CreateATaskAsync(item);
                return RedirectToAction(nameof(Index));
            }
            return View(item);
        }
        #endregion

        #region Details
        public async Task<IActionResult> Details(int id)
        {
            if (id <= 0)
            {
                return NotFound();
            }

            ToDoList task = await _context.GetTaskByIDAsync(id);

            if (task == null)
            {
                return NotFound();
            }

            return View(task);
        }
        #endregion

        #region Edit
        public async Task<IActionResult> Edit(int id)
        {
            if (id <= 0)
            {
                return NotFound();
            }

            var task = await _context.GetTaskByIDAsync(id);
            if (task == null)
            {
                return NotFound();
            }
            return View(task);
        }
        #endregion

        #region Edit (Post)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Task,Priority,Completed,DueDate")] ToDoList item)
        {
            if (id != item.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _context.UpdateTaskAsync(item);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!await TaskExists(item.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(item);
        }
        #endregion

        #region Task Exists
        private async Task<bool> TaskExists(int id)
        {
            ToDoList task = await _context.GetTaskByIDAsync(id);
            if (task != null)
            {
                return true;
            }
            return false;
        }
        #endregion

        #region Delete
        public async Task<IActionResult> Delete(int id)
        {
            if (id <= 0)
            {
                return NotFound();
            }

            var task = await _context.GetTaskByIDAsync(id);
            return View(task);
        }
        #endregion

        #region Confirm Deletion
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _context.DeleteTaskAsync(id);
            return RedirectToAction(nameof(Index));
        }
        #endregion


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
