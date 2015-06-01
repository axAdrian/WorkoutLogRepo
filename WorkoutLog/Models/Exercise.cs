using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WorkoutLog.Models
{
    public class Exercise
    {
        public int exerciseID { get; set; }
        public string exerciseName { get; set; }
        public string exerciseDesc { get; set; }

        public int trainingID { get; set; }

        public virtual Training Training { get; set; }
    }
}