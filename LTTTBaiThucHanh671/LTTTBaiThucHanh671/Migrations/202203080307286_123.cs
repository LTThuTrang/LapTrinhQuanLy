namespace LTTTBaiThucHanh671.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _123 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudnetID = c.String(nullable: false, maxLength: 128),
                        StudnetName = c.String(),
                    })
                .PrimaryKey(t => t.StudnetID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Students");
        }
    }
}
