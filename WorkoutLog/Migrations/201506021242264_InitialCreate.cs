namespace WorkoutLog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Exercises",
                c => new
                    {
                        exerciseID = c.Int(nullable: false, identity: true),
                        exerciseName = c.String(),
                        exerciseDesc = c.String(),
                        trainingID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.exerciseID);
            
            CreateTable(
                "dbo.ExeTrains",
                c => new
                    {
                        exeTrainID = c.Int(nullable: false, identity: true),
                        trainingID = c.Int(nullable: false),
                        exerciseID = c.Int(nullable: false),
                        Set = c.Int(nullable: false),
                        Rep = c.Int(nullable: false),
                        Weight = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Info = c.String(),
                    })
                .PrimaryKey(t => t.exeTrainID)
                .ForeignKey("dbo.Exercises", t => t.exerciseID, cascadeDelete: true)
                .ForeignKey("dbo.Trainings", t => t.trainingID, cascadeDelete: true)
                .Index(t => t.trainingID)
                .Index(t => t.exerciseID);
            
            CreateTable(
                "dbo.Trainings",
                c => new
                    {
                        trainingID = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        trainingName = c.String(),
                    })
                .PrimaryKey(t => t.trainingID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ExeTrains", "trainingID", "dbo.Trainings");
            DropForeignKey("dbo.ExeTrains", "exerciseID", "dbo.Exercises");
            DropIndex("dbo.ExeTrains", new[] { "exerciseID" });
            DropIndex("dbo.ExeTrains", new[] { "trainingID" });
            DropTable("dbo.Trainings");
            DropTable("dbo.ExeTrains");
            DropTable("dbo.Exercises");
        }
    }
}
