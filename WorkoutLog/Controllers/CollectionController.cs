using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WorkoutLog.DAL;
using WorkoutLog.ViewModel;

namespace WorkoutLog.Controllers
{
    public class CollectionController : Controller
    {
        private LogContext db = new LogContext();
        // GET: Collection

        public ActionResult Index()
        {
            var exercises = db.Trainings;

            var vm = new CollectionViewModel()
            {
                Exercises = exercises
            };

            return View("Collection", vm);
        }
    }
}