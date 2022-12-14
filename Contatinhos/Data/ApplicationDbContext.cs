using Contatinhos.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Contatinhos.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Contato> Contatos { get; set; }
        public DbSet<Evento> Eventos { get; set; }
        public DbSet<UsuarioModel> Usuarios { get; set; }
    }
}