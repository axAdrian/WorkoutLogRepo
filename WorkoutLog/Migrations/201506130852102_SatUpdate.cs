namespace WorkoutLog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SatUpdate : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.ExeTrains", new[] { "TrainingID" });
            DropIndex("dbo.ExeTrains", new[] { "ExerciseID" });
            CreateIndex("dbo.ExeTrains", "TrainingId");
            CreateIndex("dbo.ExeTrains", "ExerciseId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.ExeTrains", new[] { "ExerciseId" });
            DropIndex("dbo.ExeTrains", new[] { "TrainingId" });
            CreateIndex("dbo.ExeTrains", "ExerciseID");
            CreateIndex("dbo.ExeTrains", "TrainingID");
        }
    }
}
