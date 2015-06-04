using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WorkoutLog.DAL;
using WorkoutLog.Models;

namespace WorkoutLog.Controllers
{
    public class HomeController : Controller
    {
        private LogContext db = new LogContext(); //do polaczenia z baza 

        public ActionResult Index()
        {
            //przykladowa tabela w bazie
            //Training newTraining = new Training { Date = DateTime.Today, trainingName = "najebator"};
            //db.Trainings.Add(newTraining);
            //db.SaveChanges();

            return View();
        }

        public ActionResult info()
        {

            return View();
        }

    }
}