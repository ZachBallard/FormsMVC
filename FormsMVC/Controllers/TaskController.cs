using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.Mvc;

namespace FormsMVC.Controllers
{
    public class TaskController : Controller
    {
        public List<Task> tasks { get; set; } = new List<Task>();

        // GET: Task
        [HttpGet]
        public ActionResult Index(string task)
        {
            return View(tasks);
        }
        
        // Create new task
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Task
        [HttpPost]
        public ActionResult Create(Task newTask)
        {
            tasks.Add(newTask);
            return RedirectToAction("Index");
        }
    }
}