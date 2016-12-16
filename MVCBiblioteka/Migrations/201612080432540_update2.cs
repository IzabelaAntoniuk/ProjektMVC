namespace MVCBiblioteka.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Books", "LendID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Books", "LendID", c => c.Int(nullable: false));
        }
    }
}
