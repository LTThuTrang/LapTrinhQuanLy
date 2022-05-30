namespace LTTTBaiTapLon671.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class QLtram : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Admins", "Tram", c => c.String());
            AddColumn("dbo.Admins", "Mucnuoc", c => c.String());
            AddColumn("dbo.Managers", "Mucnuoc", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Managers", "Mucnuoc");
            DropColumn("dbo.Admins", "Mucnuoc");
            DropColumn("dbo.Admins", "Tram");
        }
    }
}
