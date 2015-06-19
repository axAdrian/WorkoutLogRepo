using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WorkoutLog.Models
{
    public class Training
    {
        [Key]
        public int TrainingId { get; set; }

        [Required(ErrorMessage = "Wybierz datę treningu!")]
        [Display(Name = "Data treningu:")]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Wpisz nazwę!")]
        [Display(Name = "Nazwa treningu:")]
        public string TrainingName { get; set; }

        public virtual ICollection<ExeTrain> ExeTrains  { get; set; }
    }
}