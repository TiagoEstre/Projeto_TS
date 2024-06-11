namespace Projecto_TS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Chat : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Mensagems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Conteudo = c.String(),
                        Data = c.DateTime(nullable: false),
                        UtilizadorId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Utilizadors", t => t.UtilizadorId, cascadeDelete: true)
                .Index(t => t.UtilizadorId);
            
            CreateTable(
                "dbo.Utilizadors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Username = c.String(),
                        Password = c.String(),
                        Email = c.String(),
                        Phone = c.String(),
                        Year = c.String(),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Mensagems", "UtilizadorId", "dbo.Utilizadors");
            DropIndex("dbo.Mensagems", new[] { "UtilizadorId" });
            DropTable("dbo.Utilizadors");
            DropTable("dbo.Mensagems");
        }
    }
}
