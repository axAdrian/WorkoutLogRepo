using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WorkoutLog.Models;

namespace WorkoutLog.ViewModel
{
    public class CollectionViewModel
    {
        public IEnumerable<Training> Exercises { get; set; } 
    }
}