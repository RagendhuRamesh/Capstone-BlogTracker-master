namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AdminInfo",
                c => new
                    {
                        AdminId = c.Int(nullable: false, identity: true),
                        EmailId = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.AdminId);
            
            CreateTable(
                "dbo.BlogInfo",
                c => new
                    {
                        BlogInfoId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Subject = c.String(),
                        DateOfCreation = c.DateTime(nullable: false),
                        BlogUrl = c.String(),
                        EmpEmailId = c.String(),
                    })
                .PrimaryKey(t => t.BlogInfoId);
            
            CreateTable(
                "dbo.EmpInfo",
                c => new
                    {
                        EmpInfoId = c.Int(nullable: false, identity: true),
                        EmailId = c.String(),
                        Name = c.String(),
                        DateOfJoining = c.DateTime(nullable: false),
                        PassCode = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EmpInfoId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.EmpInfo");
            DropTable("dbo.BlogInfo");
            DropTable("dbo.AdminInfo");
        }
    }
}
