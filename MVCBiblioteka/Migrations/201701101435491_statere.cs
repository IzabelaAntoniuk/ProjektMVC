namespace MVCBiblioteka.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class statere : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Books", "state", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Books", "state", c => c.String(nullable: false));
        }
    }
}
