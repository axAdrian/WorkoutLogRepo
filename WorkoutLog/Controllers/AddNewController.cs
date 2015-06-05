﻿using System;
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
            return View();
        }

        public ActionResult Details()
        {
            

            return PartialView("_Details");
        }

    }
}