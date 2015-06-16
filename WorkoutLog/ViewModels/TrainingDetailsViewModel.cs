using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WorkoutLog.Models;

namespace WorkoutLog.ViewModels
{
    public class TrainingDetailsViewModel
    {
     
        [Required(ErrorMessage = "Musisz podać nazwę ćwiczenia!")]
        public string TrainingName { get; set; }
        public int TrainingId { get; set; }
        public DateTime Date { get; set; }

        List<ExeTrain> exeTrains { get; set; } 

    }
}