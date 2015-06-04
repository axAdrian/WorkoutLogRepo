namespace WorkoutLog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewOne : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ExeTrains", "Rep", c => c.Int(nullable: false));
            DropColumn("dbo.Exercises", "trainingID");
            DropColumn("dbo.ExeTrains", "Reps");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ExeTrains", "Reps", c => c.Int(nullable: false));
            AddColumn("dbo.Exercises", "trainingID", c => c.Int(nullable: false));
            DropColumn("dbo.ExeTrains", "Rep");
        }
    }
}
