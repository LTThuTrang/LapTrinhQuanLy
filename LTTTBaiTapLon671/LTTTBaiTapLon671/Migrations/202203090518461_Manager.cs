namespace LTTTBaiTapLon671.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Manager : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Managers",
                c => new
                    {
                        ManagerID = c.String(nullable: false, maxLength: 128),
                        ManagerName = c.String(),
                    })
                .PrimaryKey(t => t.ManagerID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Managers");
        }
    }
}
