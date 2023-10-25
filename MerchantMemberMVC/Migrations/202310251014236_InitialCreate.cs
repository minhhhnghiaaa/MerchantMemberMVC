namespace MerchantMemberMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Member",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        Address = c.String(),
                        Age = c.Int(nullable: false),
                        Email = c.String(),
                        Phone = c.String(),
                        MerchantId = c.Guid(nullable: false),
                        CreatedDate = c.DateTime(),
                        UpdatedDate = c.DateTime(),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Merchant", t => t.MerchantId, cascadeDelete: true)
                .Index(t => t.MerchantId);
            
            CreateTable(
                "dbo.Merchant",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        BankName = c.String(),
                        AccountNumber = c.String(),
                        SwiftCode = c.String(),
                        Balance = c.Int(nullable: false),
                        CreatedDate = c.DateTime(),
                        UpdatedDate = c.DateTime(),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Member", "MerchantId", "dbo.Merchant");
            DropIndex("dbo.Member", new[] { "MerchantId" });
            DropTable("dbo.Merchant");
            DropTable("dbo.Member");
        }
    }
}
