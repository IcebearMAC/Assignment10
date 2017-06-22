namespace Assignment10.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inital : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        AccountNumber = c.Int(nullable: false),
                        ClearingNumber = c.String(maxLength: 128),
                        Balance = c.Double(nullable: false),
                        History_ID = c.Int(),
                    })
                .PrimaryKey(t => t.AccountNumber)
                .ForeignKey("dbo.Banks", t => t.ClearingNumber)
                .ForeignKey("dbo.Histories", t => t.History_ID)
                .Index(t => t.ClearingNumber)
                .Index(t => t.History_ID);
            
            CreateTable(
                "dbo.Banks",
                c => new
                    {
                        ClearingNumber = c.String(nullable: false, maxLength: 128),
                        Category = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ClearingNumber);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        SSN = c.String(nullable: false, maxLength: 10),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.SSN);
            
            CreateTable(
                "dbo.Histories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TransactionTime = c.DateTime(nullable: false),
                        AccountHistory = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.CustomerAccounts",
                c => new
                    {
                        Customer_SSN = c.String(nullable: false, maxLength: 10),
                        Account_AccountNumber = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Customer_SSN, t.Account_AccountNumber })
                .ForeignKey("dbo.Customers", t => t.Customer_SSN, cascadeDelete: true)
                .ForeignKey("dbo.Accounts", t => t.Account_AccountNumber, cascadeDelete: true)
                .Index(t => t.Customer_SSN)
                .Index(t => t.Account_AccountNumber);
            
            CreateStoredProcedure(
                "dbo.Customer_Insert",
                p => new
                    {
                        SSN = p.String(maxLength: 10),
                        Name = p.String(),
                    },
                body:
                    @"INSERT [dbo].[Customers]([SSN], [Name])
                      VALUES (@SSN, @Name)"
            );
            
            CreateStoredProcedure(
                "dbo.Customer_Update",
                p => new
                    {
                        SSN = p.String(maxLength: 10),
                        Name = p.String(),
                    },
                body:
                    @"UPDATE [dbo].[Customers]
                      SET [Name] = @Name
                      WHERE ([SSN] = @SSN)"
            );
            
            CreateStoredProcedure(
                "dbo.Customer_Delete",
                p => new
                    {
                        SSN = p.String(maxLength: 10),
                    },
                body:
                    @"DELETE [dbo].[Customers]
                      WHERE ([SSN] = @SSN)"
            );
            
        }
        
        public override void Down()
        {
            DropStoredProcedure("dbo.Customer_Delete");
            DropStoredProcedure("dbo.Customer_Update");
            DropStoredProcedure("dbo.Customer_Insert");
            DropForeignKey("dbo.Accounts", "History_ID", "dbo.Histories");
            DropForeignKey("dbo.CustomerAccounts", "Account_AccountNumber", "dbo.Accounts");
            DropForeignKey("dbo.CustomerAccounts", "Customer_SSN", "dbo.Customers");
            DropForeignKey("dbo.Accounts", "ClearingNumber", "dbo.Banks");
            DropIndex("dbo.CustomerAccounts", new[] { "Account_AccountNumber" });
            DropIndex("dbo.CustomerAccounts", new[] { "Customer_SSN" });
            DropIndex("dbo.Accounts", new[] { "History_ID" });
            DropIndex("dbo.Accounts", new[] { "ClearingNumber" });
            DropTable("dbo.CustomerAccounts");
            DropTable("dbo.Histories");
            DropTable("dbo.Customers");
            DropTable("dbo.Banks");
            DropTable("dbo.Accounts");
        }
    }
}
