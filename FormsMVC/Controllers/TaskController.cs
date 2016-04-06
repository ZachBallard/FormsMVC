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
            List<Task> currentTasks;
            currentTasks = (List<Task>)Session["tasks"] ?? new List<Task>();
            return View(currentTasks);
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
            if (ModelState.IsValid)
            {
                var currentTasks = (List<Task>)Session["tasks"];
                if (currentTasks == null)
                {
                    currentTasks = new List<Task>();
                }
                currentTasks.Add(newTask);

                Session["tasks"] = currentTasks;
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }
    }
}