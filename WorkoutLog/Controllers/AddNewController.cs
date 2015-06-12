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
    public class AddNewController : Controller
    {
        private LogContext db =new LogContext();

        // GET: AddNew
        public ActionResult Index()
        {
            var traninig = db.Trainings.ToList();

            var vm = new AddNewViewModel()
            {
                Trainings = traninig
            };

            return View(vm);
        }

        public ActionResult Add()
        {
            return View("TrainingDetails");
        }

        private TrainingDetails GetTraining()
        {
            if (Session["training"] == null)
             {
                Session["training"] = new TrainingDetails();
               }
          return (TrainingDetails)Session["training"];
        }
        
        
        private void RemoveTrainingDetails()
        {
          Session.Remove("training");
        }

        [HttpPost]
        public ActionResult TrainingDetails(TrainingDetails data, string prevBtn, string nextBtn)
        {
            if (nextBtn != null)
            {
                if (ModelState.IsValid)
                {
                    TrainingDetails obj = GetTraining();
                    obj.TrainingName = data.TrainingName;
                    obj.Date = data.Date;
                    return View("ExerciseDetails");
                }
            }
            return View();
        }

        [HttpPost]
        public ActionResult ExerciseDetails(TrainingDetails data, string prevBtn, string nextBtn)
        {
            TrainingDetails obj = GetTraining();
            if (prevBtn != null)
            {
                TrainingDetails bd = new TrainingDetails();
                bd.TrainingName = obj.TrainingName;
                bd.Date = obj.Date;
                return View("TrainingDetails", bd);
            }
            if (nextBtn != null)
            {
                if (ModelState.IsValid)
                {
                    obj.ExerciseName = data.ExerciseName;
                    obj.Weight = data.Weight;
                    obj.Sets = data.Sets;
                    obj.Rep = data.Rep;
                    obj.Info = data.Info;
                    //ExeTrain exeTrain = new ExeTrain();
                    //Exercise exercise = new Exercise();
                    //Training training = new Training();

                    //training.TrainingName = obj.TrainingName;
                    //training.Date = obj.Date;
                    //exercise.ExerciseName = obj.ExerciseName;
                    //exeTrain.Weight = obj.Weight;
                    //exeTrain.Rep = obj.Rep;
                    //exeTrain.Sets = obj.Sets;
                    //exeTrain.Info = obj.Info;

                    //db.ExeTrains.Add(exeTrain);// problem
                    //db.Exercises.Add(exercise);
                    //db.Trainings.Add(training);
                    //db.SaveChanges();
                    //RemoveTrainingDetails();

                    return View("Suc");
                }
            }
            return View();
        }

        
        public ActionResult Details()
        {
            var traninig = db.Trainings.ToList();
            var exercise = db.Exercises.ToList();
            var exetrain = db.ExeTrains.ToList();

            var vm = new AddNewViewModel()
            {
                Trainings = traninig,
                Exercises = exercise,
                Exetrains = exetrain
            };
            
            return PartialView("_Details", vm);
        }

        public ActionResult Create()
        {
            
            return View();
        }
    }
}