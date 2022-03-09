namespace LTTTBaiTapLon671.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class User : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Admins");
            DropTable("dbo.Managers");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Managers",
                c => new
                    {
                        ManagerID = c.String(nullable: false, maxLength: 128),
                        ManagerName = c.String(),
                    })
                .PrimaryKey(t => t.ManagerID);
            
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        AdminID = c.String(nullable: false, maxLength: 128),
                        AdminName = c.String(),
                    })
                .PrimaryKey(t => t.AdminID);
            
        }
    }
}
