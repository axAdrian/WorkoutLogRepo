using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WorkoutLog.Models
{
    public class ExeTrain
    {
        public int exeTrainID { get; set; }
        public int trainingID { get; set; }
        public int exerciseID { get; set; }

        public int Set { get; set; }
        public int Rep { get; set; }
        public decimal Weight { get; set; }
        public string Info { get; set; }

        public virtual Training Training { get; set; }
        public virtual Exercise Exercise { get; set; }
    }
}