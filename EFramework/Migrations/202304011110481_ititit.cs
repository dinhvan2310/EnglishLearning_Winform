namespace EFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ititit : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Account", "BirthDate", c => c.DateTime(precision: 0));
            DropColumn("dbo.Account", "Age");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Account", "Age", c => c.Int(nullable: false));
            AlterColumn("dbo.Account", "BirthDate", c => c.DateTime(nullable: false, precision: 0));
        }
    }
}
