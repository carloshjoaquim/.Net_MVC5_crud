namespace Estoque.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpProdutos : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Produtos", "CategoriaId", "dbo.CategoriaDoProduto");
            DropIndex("dbo.Produtos", new[] { "CategoriaId" });
            AlterColumn("dbo.Produtos", "CategoriaId", c => c.Int(nullable: false));
            CreateIndex("dbo.Produtos", "CategoriaId");
            AddForeignKey("dbo.Produtos", "CategoriaId", "dbo.CategoriaDoProduto", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Produtos", "CategoriaId", "dbo.CategoriaDoProduto");
            DropIndex("dbo.Produtos", new[] { "CategoriaId" });
            AlterColumn("dbo.Produtos", "CategoriaId", c => c.Int());
            CreateIndex("dbo.Produtos", "CategoriaId");
            AddForeignKey("dbo.Produtos", "CategoriaId", "dbo.CategoriaDoProduto", "Id");
        }
    }
}
