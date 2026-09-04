using EFCoreTaskManager.Data;
using EFCoreTaskManager.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace EFCoreTaskManager.Controllers
{
    public class TaskController : Controller
    {
        private readonly TaskDbContext _context;

        public TaskController(TaskDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            // Ensure Category is loaded
            var tasks = await _context.Tasks
                                      .Include(t => t.Category)
                                    .ToListAsync();
            return View(tasks);
        }

        public IActionResult Delete(int id)
        {
            var task = _context.Tasks.Find(id);
            if (task != null)
            {
                _context.Tasks.Remove(task);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        // GET: Task/Create
        public IActionResult Create()
        {
            ViewBag.Categories = new SelectList(_context.Categories, "Id", "Name");
            return View();
        }

        // POST: Task/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(TaskItem task)
        {
            // reload categories
            ViewBag.Categories = new SelectList(_context.Categories, "Id", "Name");

            if (ModelState.IsValid)
            {
                _context.Tasks.Add(task);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(task);
        }

        // GET Method: Task/Edit/1
        public IActionResult Edit(int id)
        {
            // Include Category data
            var task = _context.Tasks
                .Include(t => t.Category)
                .FirstOrDefault(t => t.Id == id);

            if (task == null)
            {
                return NotFound();
            }

            // Pass category list to ViewBag for dropdown selection
            ViewBag.Categories = new SelectList(_context.Categories, "Id", "Name", task.CategoryId);

            return View(task);
        }

        // POST Method: Task/Edit/1
        [HttpPost]
        public IActionResult Edit(int id, TaskItem updatedTask)
        {
            var task = _context.Tasks.Find(id);

            // Update properties
            task.Title = updatedTask.Title;
            task.Description = updatedTask.Description;
            task.IsCompleted = updatedTask.IsCompleted;

            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
