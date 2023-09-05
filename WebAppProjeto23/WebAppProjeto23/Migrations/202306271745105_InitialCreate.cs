namespace WebAppProjeto23.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categorias",
                c => new
                    {
                        CategoriaId = c.Long(nullable: false, identity: true),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.CategoriaId);
            
            CreateTable(
                "dbo.Produtoes",
                c => new
                    {
                        ProdutoId = c.Long(nullable: false, identity: true),
                        Nome = c.String(),
                        CategoriaId = c.Long(),
                        FabricanteId = c.Long(),
                        LogotipoMimeType = c.String(),
                        Logotipo = c.Binary(),
                        NomeArquivo = c.String(),
                        TamanhoArquivo = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.ProdutoId)
                .ForeignKey("dbo.Categorias", t => t.CategoriaId)
                .ForeignKey("dbo.Fabricantes", t => t.FabricanteId)
                .Index(t => t.CategoriaId)
                .Index(t => t.FabricanteId);
            
            CreateTable(
                "dbo.Fabricantes",
                c => new
                    {
                        FabricanteId = c.Long(nullable: false, identity: true),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.FabricanteId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Produtoes", "FabricanteId", "dbo.Fabricantes");
            DropForeignKey("dbo.Produtoes", "CategoriaId", "dbo.Categorias");
            DropIndex("dbo.Produtoes", new[] { "FabricanteId" });
            DropIndex("dbo.Produtoes", new[] { "CategoriaId" });
            DropTable("dbo.Fabricantes");
            DropTable("dbo.Produtoes");
            DropTable("dbo.Categorias");
        }
    }
}
