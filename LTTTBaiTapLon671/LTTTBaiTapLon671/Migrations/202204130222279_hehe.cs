namespace LTTTBaiTapLon671.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class hehe : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "UserName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "UserName", c => c.String());
        }
    }
}
