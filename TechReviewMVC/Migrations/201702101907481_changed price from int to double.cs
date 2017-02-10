namespace TechReviewMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changedpricefrominttodouble : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Reviews", "Price", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Reviews", "Price", c => c.Int(nullable: false));
        }
    }
}
