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
            
            DropColumn("dbo.Utilizadors", "Description");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Utilizadors", "Description", c => c.String());
            DropForeignKey("dbo.Mensagems", "UtilizadorId", "dbo.Utilizadors");
            DropIndex("dbo.Mensagems", new[] { "UtilizadorId" });
            DropTable("dbo.Mensagems");
        }
    }
}
