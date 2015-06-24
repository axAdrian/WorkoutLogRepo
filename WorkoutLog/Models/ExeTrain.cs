using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WorkoutLog.Models
{
    public class ExeTrain
    {
        [Key]
        public int ExeTrainId { get; set; }

        public int TrainingId { get; set; }

        [Required(ErrorMessage = "Wybierz ćwiczenie!")]
        [Display(Name = "Nazwa ćwiczenia:")]
        public int ExerciseId { get; set; }

        [Required(ErrorMessage = "Podaj ilość serii!")]
        [Display(Name = "Liczba serii:")]
        public int Sets { get; set; }

        [Required(ErrorMessage = "Podaj ilość powtórzeń!")]
        [Display(Name = "Ilość powtórzeń:")]
        public int Rep { get; set; }

        [Required(ErrorMessage = "Wpisz ciężar")]
        [Display(Name = "Ciężar:")]
        public decimal Weight { get; set; }

        [Display(Name = "Uwagi:")]
        public string Info { get; set; }

        public virtual Training Training { get; set; }
        public virtual Exercise Exercise { get; set; }
    }
}