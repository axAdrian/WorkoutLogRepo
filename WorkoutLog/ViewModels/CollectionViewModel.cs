using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WorkoutLog.Models;

namespace WorkoutLog.ViewModels
{
    public class CollectionViewModel
    {
        public IEnumerable<Exercise> Exercises { get; set; } 
    }
}