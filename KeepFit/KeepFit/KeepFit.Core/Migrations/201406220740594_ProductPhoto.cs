namespace KeepFit.Core.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProductPhoto : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "ExcercisePhoto", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "ExcercisePhoto");
        }
    }
}