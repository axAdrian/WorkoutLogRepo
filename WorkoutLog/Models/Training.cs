using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WorkoutLog.Models
{
    public class Training
    {
        public int TrainingId { get; set; }
        public DateTime Date { get; set; }
        public string TrainingName { get; set; }

        public virtual ICollection<ExeTrain> ExeTrains  { get; set; }
    }
}