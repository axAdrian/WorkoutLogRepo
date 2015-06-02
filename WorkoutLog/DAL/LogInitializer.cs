using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using WorkoutLog.Models;

namespace WorkoutLog.DAL
{
    public class LogInitializer : DropCreateDatabaseAlways<LogContext>
    {
        protected override void Seed(LogContext context)
        {
            SeedLogContext(context);
            base.Seed(context);
        }

        private void SeedLogContext(LogContext context)
        {
            var tr = new List<Training>
            {
                new Training() {Date = DateTime.Today, trainingName = "plecy"},
                new Training() {Date = DateTime.Today, trainingName = "nogi"}
            };

            tr.ForEach(g => context.Trainings.AddOrUpdate(g));
            context.SaveChanges();
        }
    }
}