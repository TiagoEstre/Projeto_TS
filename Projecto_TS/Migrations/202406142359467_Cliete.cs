namespace Projecto_TS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Clietes : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Utilizadors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Status = c.String(),
                        Name = c.String(),
                        Username = c.String(),
                        Password = c.String(),
                        Email = c.String(),
                        Phone = c.Int(nullable: false),
                        Year = c.DateTime(nullable: false),
                        Photo = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Utilizadors");
        }
    }
}
