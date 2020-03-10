namespace BusinessPlex.DatabaseContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SalesModel_DataTypeChanged : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.SalesCustomers", "LoyaltyPoint", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.SalesCustomers", "LoyaltyPoint", c => c.Int(nullable: false));
        }
    }
}
