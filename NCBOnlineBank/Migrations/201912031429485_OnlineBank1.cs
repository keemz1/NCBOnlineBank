namespace NCBOnlineBank.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OnlineBank1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AccountTransactions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Category = c.String(),
                        TranactionAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PaymentTime = c.DateTime(nullable: false),
                        CustomerNumber = c.Int(nullable: false),
                        PremiseNumber = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AccountInfoes",
                c => new
                    {
                        PayeeId = c.Int(nullable: false, identity: true),
                        Category = c.String(),
                    })
                .PrimaryKey(t => t.PayeeId);
            
            CreateTable(
                "dbo.PayeeAccounts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Category = c.String(),
                        BillAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CustomerNumber = c.Int(nullable: false),
                        PremiseNumber = c.Int(nullable: false),
                        CustomerName = c.String(),
                        PaymentTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PayeePayments",
                c => new
                    {
                        PayeePaymentID = c.Int(nullable: false, identity: true),
                        PayeeId = c.Int(nullable: false),
                        Category = c.String(),
                        CustomerName = c.String(),
                        PremiseNumber = c.Int(nullable: false),
                        CustomerNumber = c.Int(nullable: false),
                        PaymentAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PaymentTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.PayeePaymentID);
            
            CreateTable(
                "dbo.CustomerPayees",
                c => new
                    {
                        CustomerPayeeID = c.Int(nullable: false, identity: true),
                        PayeeId = c.Int(nullable: false),
                        CustomerName = c.String(),
                        PremiseNumber = c.Int(nullable: false),
                        Category = c.String(),
                        AccountNumber = c.String(),
                    })
                .PrimaryKey(t => t.CustomerPayeeID);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.TransactionHistories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PayeeId = c.Int(nullable: false),
                        Category = c.String(),
                        TranactionAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PaymentTime = c.DateTime(nullable: false),
                        CustomerNumber = c.Int(nullable: false),
                        PremiseNumber = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        AccountNumber = c.Int(nullable: false),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Address1 = c.String(),
                        Address2 = c.String(),
                        PremiseNumber = c.Int(nullable: false),
                        Savings = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Currency = c.String(),
                        PinCode = c.String(),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.TransactionHistories");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.CustomerPayees");
            DropTable("dbo.PayeePayments");
            DropTable("dbo.PayeeAccounts");
            DropTable("dbo.AccountInfoes");
            DropTable("dbo.AccountTransactions");
        }
    }
}
