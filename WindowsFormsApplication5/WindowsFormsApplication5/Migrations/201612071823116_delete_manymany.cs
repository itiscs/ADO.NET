namespace WindowsFormsApplication5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class delete_manymany : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.SalespersonCustomers", "Salesperson_Snum", "dbo.Salespeople");
            DropForeignKey("dbo.SalespersonCustomers", "Customer_Cnum", "dbo.Customers");
            DropIndex("dbo.SalespersonCustomers", new[] { "Salesperson_Snum" });
            DropIndex("dbo.SalespersonCustomers", new[] { "Customer_Cnum" });
            AddColumn("dbo.Customers", "Snum", c => c.Int());
            CreateIndex("dbo.Customers", "Snum");
            AddForeignKey("dbo.Customers", "Snum", "dbo.Salespeople", "Snum");
            DropTable("dbo.SalespersonCustomers");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.SalespersonCustomers",
                c => new
                    {
                        Salesperson_Snum = c.Int(nullable: false),
                        Customer_Cnum = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Salesperson_Snum, t.Customer_Cnum });
            
            DropForeignKey("dbo.Customers", "Snum", "dbo.Salespeople");
            DropIndex("dbo.Customers", new[] { "Snum" });
            DropColumn("dbo.Customers", "Snum");
            CreateIndex("dbo.SalespersonCustomers", "Customer_Cnum");
            CreateIndex("dbo.SalespersonCustomers", "Salesperson_Snum");
            AddForeignKey("dbo.SalespersonCustomers", "Customer_Cnum", "dbo.Customers", "Cnum", cascadeDelete: true);
            AddForeignKey("dbo.SalespersonCustomers", "Salesperson_Snum", "dbo.Salespeople", "Snum", cascadeDelete: true);
        }
    }
}
