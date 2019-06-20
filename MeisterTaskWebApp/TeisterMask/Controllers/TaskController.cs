using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TeisterMask.DbContext;
using TeisterMask.Models;

namespace TeisterMask.Controllers
{
    public class TaskController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            using (var db = new TeisterMaskDbContext())
            {
                var allTasks = db.Tasks.ToList();
                return View(allTasks);
            }
            
        }

        [HttpGet]
        public IActionResult Create()
        {   
            return View();
        }

        [HttpPost]
        public IActionResult Create(Task task)
        {
            using (var db = new TeisterMaskDbContext())
            {
                db.Tasks.Add(task);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            using (var db = new TeisterMaskDbContext())
            {
                var taskEdit = db.Tasks.FirstOrDefault(t => t.Id == id);
                
                if (taskEdit == null)
                {
                    return RedirectToAction("Index");

                }
                return View(taskEdit);
            }
        }

        [HttpPost]
        public IActionResult Edit(Task task)
        {

            using (var db = new TeisterMaskDbContext())
            {         
                db.Tasks.Update(task);
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            using (var db = new TeisterMaskDbContext())
            {
                Task taskDelete = db.Tasks.Find(id);
                if (taskDelete == null)
                {
                    return RedirectToAction("Index");

                }
                return View(taskDelete);
            }
        }

        [HttpPost]
        public IActionResult Delete(Task task)
        {

            using (var db = new TeisterMaskDbContext())
            {
                db.Tasks.Remove(task);
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}