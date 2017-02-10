namespace TechReviewMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changingpricefromdoubletostring : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Reviews", "Price", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Reviews", "Price", c => c.Double(nullable: false));
        }
    }
}
