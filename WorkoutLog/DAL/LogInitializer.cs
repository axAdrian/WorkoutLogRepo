using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using WorkoutLog.Models;
using WorkoutLog.Migrations;

namespace WorkoutLog.DAL
{
    public class LogInitializer : MigrateDatabaseToLatestVersion<LogContext, WorkoutLog.Migrations.Configuration>
    {
        //protected override void Seed(LogContext context)
        //{
        //    SeedLogContext(context);
        //    base.Seed(context);
        //}

        public static void SeedLogContext(LogContext context)
        {
            var tr = new List<Training>
            {
                new Training() {Date = DateTime.Today, trainingName = "plecy"},
                new Training() {Date = DateTime.Today, trainingName = "nogi"}
            };
            tr.ForEach(g => context.Trainings.AddOrUpdate(g));

            var ex = new List<Exercise>
            {
                new Exercise() { exerciseDesc = "nowe cwiczonko", exerciseName = "ohp"},
                new Exercise() { exerciseDesc = "super klata", exerciseName = "push up"},
            };
            ex.ForEach(g => context.Exercises.AddOrUpdate(g));

            
            context.SaveChanges();
        }
    }
}