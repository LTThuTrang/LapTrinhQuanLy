namespace LTTTBaiTapLon671.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m123 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Managers", "ManagerName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Managers", "ManagerName", c => c.String());
        }
    }
}
