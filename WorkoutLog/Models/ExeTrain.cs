using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WorkoutLog.Models
{
    public class ExeTrain
    {
        public int ExeTrainId { get; set; }
        public int TrainingId { get; set; }
        public int ExerciseId { get; set; }

        public int Sets { get; set; }
        public int Rep { get; set; }
        public decimal Weight { get; set; }
        public string Info { get; set; }

        public virtual Training Training { get; set; }
        public virtual Exercise Exercise { get; set; }
    }
}