using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WorkoutLog.Models
{
    public class ExeTrain
    {
        public int ExeTrainId { get; set; }
        public int TrainingId { get; set; }
        public int ExerciseId { get; set; }

        [Display(Name = "Liczba serii:")]
        public int Sets { get; set; }

        [Display(Name = "Ilość powtórzeń:")]
        public int Rep { get; set; }

        [Display(Name = "Ciężar:")]
        public decimal Weight { get; set; }

        [Display(Name = "Uwagi:")]
        public string Info { get; set; }

        public virtual Training Training { get; set; }
        public virtual Exercise Exercise { get; set; }
    }
}