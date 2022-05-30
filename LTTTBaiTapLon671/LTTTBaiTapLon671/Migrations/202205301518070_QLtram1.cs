namespace LTTTBaiTapLon671.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class QLtram1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Users", "Tram");
            DropColumn("dbo.Users", "Mucnuoc");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "Mucnuoc", c => c.String());
            AddColumn("dbo.Users", "Tram", c => c.String());
        }
    }
}
