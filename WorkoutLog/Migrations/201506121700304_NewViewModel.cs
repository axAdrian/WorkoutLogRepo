namespace WorkoutLog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewViewModel : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.ExeTrains", new[] { "trainingID" });
            DropIndex("dbo.ExeTrains", new[] { "exerciseID" });
            CreateIndex("dbo.ExeTrains", "TrainingID");
            CreateIndex("dbo.ExeTrains", "ExerciseID");
        }
        
        public override void Down()
        {
            DropIndex("dbo.ExeTrains", new[] { "ExerciseID" });
            DropIndex("dbo.ExeTrains", new[] { "TrainingID" });
            CreateIndex("dbo.ExeTrains", "exerciseID");
            CreateIndex("dbo.ExeTrains", "trainingID");
        }
    }
}
