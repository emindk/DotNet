using Microsoft.AspNetCore.Mvc;
using TaskManager.Models;
using System.Collections.Generic;
using System.Linq;

namespace TaskManager.Controllers
{
    public class TaskController : Controller
    {
        private static List<TaskItem> tasks = new List<TaskItem>
        {
            new TaskItem { Id = 1, Title = "Learn ASP.NET Core", IsCompleted = false },
            new TaskItem { Id = 2, Title = "Build an MVC App", IsCompleted = true }
        };

        public IActionResult Index()
        {
            return View(tasks);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(TaskItem task)
        {
            task.Id = tasks.Count + 1;
            tasks.Add(task);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var task = tasks.FirstOrDefault(t => t.Id == id);
            if (task != null)
            {
                tasks.Remove(task);
            }
            return RedirectToAction("Index");
        }
    }
}
