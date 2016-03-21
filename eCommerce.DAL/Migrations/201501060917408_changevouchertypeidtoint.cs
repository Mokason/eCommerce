namespace eCommerce.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changevouchertypeidtoint : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Vouchers", "VoucherTypeId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Vouchers", "VoucherTypeId", c => c.String(maxLength: 100));
        }
    }
}
