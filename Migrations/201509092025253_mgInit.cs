namespace UniqueAttribute.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mgInit : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TestModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SomeThing = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TestModels");
        }
    }
}
