﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WorkoutLog.Models;

namespace WorkoutLog.ViewModel
{
    public class AddNewViewModel
    {
        public IEnumerable<Training> Trainings { get; set; }
    }
}