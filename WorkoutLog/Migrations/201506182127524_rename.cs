namespace WorkoutLog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class rename : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Trainings", "TrainingName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Trainings", "TrainingName", c => c.String());
        }
    }
}
