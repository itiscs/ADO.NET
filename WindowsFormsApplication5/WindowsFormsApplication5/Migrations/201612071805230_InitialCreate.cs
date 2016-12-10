namespace WindowsFormsApplication5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Cnum = c.Int(nullable: false),
                        Cname = c.String(maxLength: 20),
                        City = c.String(maxLength: 20),
                        Rating = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Cnum);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Onum = c.Int(nullable: false),
                        Odate = c.DateTime(nullable: false),
                        Amt = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Snum = c.Int(nullable: false),
                        Cnum = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Onum)
                .ForeignKey("dbo.Customers", t => t.Cnum, cascadeDelete: true)
                .ForeignKey("dbo.Salespeople", t => t.Snum, cascadeDelete: true)
                .Index(t => t.Snum)
                .Index(t => t.Cnum);
            
            CreateTable(
                "dbo.Salespeople",
                c => new
                    {
                        Snum = c.Int(nullable: false),
                        Sname = c.String(),
                        City = c.String(),
                        Comm = c.Decimal(nullable: false, precision: 3, scale: 2),
                    })
                .PrimaryKey(t => t.Snum);
            
            CreateTable(
                "dbo.SalespersonCustomers",
                c => new
                    {
                        Salesperson_Snum = c.Int(nullable: false),
                        Customer_Cnum = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Salesperson_Snum, t.Customer_Cnum })
                .ForeignKey("dbo.Salespeople", t => t.Salesperson_Snum, cascadeDelete: true)
                .ForeignKey("dbo.Customers", t => t.Customer_Cnum, cascadeDelete: true)
                .Index(t => t.Salesperson_Snum)
                .Index(t => t.Customer_Cnum);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "Snum", "dbo.Salespeople");
            DropForeignKey("dbo.SalespersonCustomers", "Customer_Cnum", "dbo.Customers");
            DropForeignKey("dbo.SalespersonCustomers", "Salesperson_Snum", "dbo.Salespeople");
            DropForeignKey("dbo.Orders", "Cnum", "dbo.Customers");
            DropIndex("dbo.SalespersonCustomers", new[] { "Customer_Cnum" });
            DropIndex("dbo.SalespersonCustomers", new[] { "Salesperson_Snum" });
            DropIndex("dbo.Orders", new[] { "Cnum" });
            DropIndex("dbo.Orders", new[] { "Snum" });
            DropTable("dbo.SalespersonCustomers");
            DropTable("dbo.Salespeople");
            DropTable("dbo.Orders");
            DropTable("dbo.Customers");
        }
    }
}
