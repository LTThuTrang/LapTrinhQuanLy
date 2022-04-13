namespace LTTTBaiTapLon671.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class hihi : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Admins", "AdminName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Admins", "AdminName", c => c.String());
        }
    }
}
