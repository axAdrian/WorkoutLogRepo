using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WorkoutLog.Models
{
    public class Training
    {
        public int TrainingID { get; set; }
        public DateTime Date { get; set; }
        public string TrainingName { get; set; }

        public virtual ICollection<ExeTrain> ExeTrains  { get; set; }
    }
}