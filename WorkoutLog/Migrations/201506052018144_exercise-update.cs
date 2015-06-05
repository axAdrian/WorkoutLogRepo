namespace WorkoutLog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class exerciseupdate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Exercises", "exerciseName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Exercises", "exerciseName", c => c.String());
        }
    }
}
