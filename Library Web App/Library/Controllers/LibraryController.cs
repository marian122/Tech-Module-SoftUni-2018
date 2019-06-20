using System;
using System.Collections.Generic;
using System.Linq;
using Library.DbContext;
using Library.Models;
using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers
{
    public class LibraryController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {

            using (var db = new BookDbContext())
            {
                var allTasks = db.Books.ToList();
                return View(allTasks);
            }
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Book book)
        {
            using (var db = new BookDbContext())
            {
                db.Books.Add(book);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            using (var db = new BookDbContext())
            {
                var taskEdit = db.Books.FirstOrDefault(t => t.Id == id);

                if (taskEdit == null)
                {
                    return RedirectToAction("Index");

                }
                return View(taskEdit);
            }
        }

        [HttpPost]
        public IActionResult Edit(Book book)
        {
            using (var db = new BookDbContext())
            {
                db.Books.Update(book);
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            using (var db = new BookDbContext())
            {
                Book taskDelete = db.Books.Find(id);
                if (taskDelete == null)
                {
                    return RedirectToAction("Index");

                }
                return View(taskDelete);
            }
        }

        [HttpPost]
        public IActionResult Delete(Book book)
        {
            using (var db = new BookDbContext())

            {
                db.Books.Remove(book);
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}