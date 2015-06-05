using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WorkoutLog.DAL;
using WorkoutLog.Models;
using WorkoutLog.ViewModel;

namespace WorkoutLog.Controllers
{
    public class CollectionController : Controller
    {
        private LogContext db = new LogContext();
        // GET: Collection

        public ActionResult Index()
        {
            var exercises = db.Exercises;

            var vm = new CollectionViewModel()
            {
                Exercises = exercises
            };

            return View("Collection", vm);
        }

        public ActionResult Delete(int id)
        {
            Exercise exe = db.Exercises.Find(id);
            db.Exercises.Remove(exe);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Create()
        {
            var exe = new Exercise();

            return View(exe);
        }

        [HttpPost]
        public ActionResult Create(Exercise exe)
        {
            if (!ModelState.IsValid)
                return View("Create");
            else
            {
                db.Exercises.Add(exe);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            
        }
    }
}