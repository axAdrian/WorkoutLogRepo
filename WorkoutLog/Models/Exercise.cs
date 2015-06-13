using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WorkoutLog.Models
{
    public class Exercise
    {
        [Key]
        public int ExerciseId { get; set; }

        [Required(ErrorMessage = "Musisz podać nazwę ćwiczenia!")]
        [Display(Name = "Nazwa ćwiczenia:")]
        public string ExerciseName { get; set; }

        [Display(Name = "Opis:")]
        [DataType(DataType.MultilineText)]
        public string ExerciseDesc { get; set; }

        public virtual ICollection<ExeTrain> ExeTrains { get; set; }
    }
} 