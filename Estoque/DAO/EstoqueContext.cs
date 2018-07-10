using Estoque.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Estoque.DAO
{
    public class EstoqueContext : DbContext
    {

        public EstoqueContext() : base("EstoqueContext")
        {
            Database.SetInitializer<EstoqueContext>(new CreateDatabaseIfNotExists<EstoqueContext>());
        }

        public DbSet<Produto> Produtos { get; set; }

        public DbSet<CategoriaDoProduto> Categorias { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
        }
    }
}