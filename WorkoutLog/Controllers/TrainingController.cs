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
    public class TrainingController : Controller
    {
        private LogContext db = new LogContext();

        // GET: AddNew
        public ActionResult Index()
        {
            var training = db.Trainings.ToList();

            return View(training);
        }
        
        public ActionResult Details(int? id)
        {
            Training traninig = db.Trainings.Find(id);
          //  var exercise = db.Exercises.ToList();
          //  var exetrain = db.ExeTrains.ToList();

            //var vm = new AddNewViewModel()
            //{
            //    Trainings = traninig,
            //    Exercises = exercise,
            //    Exetrains = exetrain
            //};
            
            return View(traninig);
        }

        public ActionResult Delete(int id)
        {
            Training tr = db.Trainings.Find(id);
            db.Trainings.Remove(tr);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Create()
        {
            var tr = new Training();
            tr.Date = DateTime.Now;
            return View(tr);
        }

        [HttpPost]
        public ActionResult Create(Training tr)
        {
            if (!ModelState.IsValid)
                return View("Create");
            else
            {
                db.Trainings.Add(tr);
                db.SaveChanges();

                return RedirectToAction("Index");
            }

        }
    }
}