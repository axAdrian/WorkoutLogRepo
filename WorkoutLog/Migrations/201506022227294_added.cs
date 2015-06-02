namespace WorkoutLog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class added : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ExeTrains", "Sets", c => c.Int(nullable: false));
            AddColumn("dbo.ExeTrains", "Reps", c => c.Int(nullable: false));
            DropColumn("dbo.ExeTrains", "Set");
            DropColumn("dbo.ExeTrains", "Rep");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ExeTrains", "Rep", c => c.Int(nullable: false));
            AddColumn("dbo.ExeTrains", "Set", c => c.Int(nullable: false));
            DropColumn("dbo.ExeTrains", "Reps");
            DropColumn("dbo.ExeTrains", "Sets");
        }
    }
}
