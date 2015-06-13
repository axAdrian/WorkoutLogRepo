using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WorkoutLog.DAL;
using WorkoutLog.Models;
using WorkoutLog.ViewModels;

namespace WorkoutLog.Controllers
{
    public class ExerciseController : Controller
    {
        private LogContext db = new LogContext();
        // GET: Collection

        public ActionResult Index() //widok listy ćwiczeń
        {
            var exercises = db.Exercises.ToList();
          
            return View(exercises);
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