namespace BusinessPlex.DatabaseContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SupplierModel_DataAnnotations_Added : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Suppliers", "Email", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Suppliers", "Contact", c => c.String(nullable: false, maxLength: 12));
            AlterColumn("dbo.Suppliers", "ContactPerson", c => c.String(maxLength: 12));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Suppliers", "ContactPerson", c => c.String());
            AlterColumn("dbo.Suppliers", "Contact", c => c.String(nullable: false));
            AlterColumn("dbo.Suppliers", "Email", c => c.String(nullable: false));
        }
    }
}
