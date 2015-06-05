using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WorkoutLog.Migrations;
using WorkoutLog.Models;

namespace WorkoutLog.DAL
{
    public class LogContext : DbContext
    {
        public LogContext() : base("LogContext")
        {
           
        }

        static LogContext()
        {
            Database.SetInitializer<LogContext>(new LogInitializer());
        }

        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<Training> Trainings { get; set; }
        public DbSet<ExeTrain> ExeTrains { get; set; }
    }
}