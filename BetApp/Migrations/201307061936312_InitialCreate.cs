namespace BetApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        CreatorId = c.Int(nullable: false),
                        PartnerId = c.Int(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Workouts",
                c => new
                    {
                        WorkoutId = c.Int(nullable: false, identity: true),
                        WorkoutDate = c.DateTime(nullable: false),
                        UserId = c.Int(nullable: false),
                        Notes = c.String(),
                        Bet_Id = c.Int(),
                    })
                .PrimaryKey(t => t.WorkoutId)
                .ForeignKey("dbo.Bets", t => t.Bet_Id)
                .Index(t => t.Bet_Id);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Workouts", new[] { "Bet_Id" });
            DropForeignKey("dbo.Workouts", "Bet_Id", "dbo.Bets");
            DropTable("dbo.Workouts");
            DropTable("dbo.Bets");
        }
    }
}
