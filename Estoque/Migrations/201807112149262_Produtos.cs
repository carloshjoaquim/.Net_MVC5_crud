namespace Estoque.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Produtos : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.CategoriaDoProdutoes", newName: "CategoriaDoProduto");
            RenameTable(name: "dbo.Produtoes", newName: "Produtos");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Produtos", newName: "Produtoes");
            RenameTable(name: "dbo.CategoriaDoProduto", newName: "CategoriaDoProdutoes");
        }
    }
}
