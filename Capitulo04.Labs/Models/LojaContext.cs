using System.Data.Common;
using System.Data.Entity;

namespace Capitulo04.Labs.Models
{
    public class LojaContext : DbContext
    {
        public LojaContext() : base(conexao)
        {
        }
        public LojaContext(string conexao) : base(conexao)
        {
        }
        public LojaContext(DbConnection cn) : base(cn, true)
        {
        }

        private static string conexao = @"Data ...";
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Produto>()
                .Property(d => d.Nome)
                .IsRequired();
        }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
    }
}