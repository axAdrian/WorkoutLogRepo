﻿using System;
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
            if (ModelState.IsValid)
            {
                db.ExeTrains.Add(exeTrain);
                db.SaveChanges();
            }

            return RedirectToAction("Details", "Training", new { id = exeTrain.TrainingId });
        }



        // GET: Wizard
        /*
        public ActionResult Index(int id)
        {
            var obj = new TrainingDetailsViewModel();
            obj.TrainingId = id;

            List<TrainingDetailsViewModel> objList = new List<TrainingDetailsViewModel>();
            objList.Add(obj);
            return View("ChooseExercise", objList);
        }

        public ActionResult Suc()
        {
            return View();
        }
        */
        //[HttpPost]
        //public ActionResult ChooseExercise(TrainingDetailsViewModel data, string prevBtn, string nextBtn)
        //{
        //    if (nextBtn != null)
        //    {
        //        if (ModelState.IsValid)
        //        {
        //            TrainingDetailsViewModel obj = GetTraining();
        //            obj.TrainingID = data.TrainingID;
        //            obj.Date = data.Date;
        //            return View("ExerciseDetails");
        //        }
        //    }
        //    return View();
        //}

        //        [HttpPost]
        //        public ActionResult ExerciseDetails(TrainingDetails data, string prevBtn, string nextBtn)
        //        {
        //            TrainingDetails obj = GetTraining();
        //            if (prevBtn != null)
        //            {
        //                TrainingDetails bd = new TrainingDetails();
        //                bd.TrainingName = obj.TrainingName;
        //                bd.Date = obj.Date;
        //                return View("TrainingDetails", bd);
        //            }
        //            if (nextBtn != null)
        //            {
        //                if (ModelState.IsValid)
        //                {
        //                    obj.ExerciseName = data.ExerciseName;
        //                    obj.Weight = data.Weight;
        //                    obj.Sets = data.Sets;
        //                    obj.Rep = data.Rep;
        //                    obj.Info = data.Info;
        //                    //ExeTrain exeTrain = new ExeTrain();
        //                    //Exercise exercise = new Exercise();
        //                    //Training training = new Training();

        //                    //training.TrainingName = obj.TrainingName;
        //                    //training.Date = obj.Date;
        //                    //exercise.ExerciseName = obj.ExerciseName;
        //                    //exeTrain.Weight = obj.Weight;
        //                    //exeTrain.Rep = obj.Rep;
        //                    //exeTrain.Sets = obj.Sets;
        //                    //exeTrain.Info = obj.Info;

        //                    //db.ExeTrains.Add(exeTrain);// problem
        //                    //db.Exercises.Add(exercise);
        //                    //db.Trainings.Add(training);
        //                    //db.SaveChanges();
        //                    //RemoveTrainingDetails();

        //                    return View("Suc");
        //                }
        //            }
        //            return View();
        //        }
    }
}