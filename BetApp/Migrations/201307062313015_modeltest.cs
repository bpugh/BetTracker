namespace BetApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modeltest : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Bets", "DateCreated", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Bets", "DateCreated");
        }
    }
}
