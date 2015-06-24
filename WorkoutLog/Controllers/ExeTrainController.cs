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
    public class ExeTrainController : Controller
    {

        public LogContext db = new LogContext();


        public ActionResult Delete(int id)
        {
            ExeTrain exetrain = db.ExeTrains.Find(id);
            db.ExeTrains.Remove(exetrain);
            db.SaveChanges();
            return RedirectToAction("Details", "Training", new {id = exetrain.TrainingId});
        }

        [HttpGet]
        public ActionResult Create(int trainingId)
        {
            var exeTrain = new ExeTrain()
            {
                TrainingId = trainingId
            };

            var exercises = db.Exercises.ToList();
            ViewBag.ListForDropdown = new SelectList(exercises, "ExerciseID", "ExerciseName");

            return View(exeTrain);
        }

        [HttpPost]
        public ActionResult Create(ExeTrain exeTrain)
        {
            // DO bazy
            if (!ModelState.IsValid)
            {
                return View("Create");
            }
            else
            {
                db.ExeTrains.Add(exeTrain);
                db.SaveChanges();
                return RedirectToAction("Details", "Training", new { id = exeTrain.TrainingId });
            }

            //return RedirectToAction("Details", "Training", new { id = exeTrain.TrainingId });
        }

    }
}