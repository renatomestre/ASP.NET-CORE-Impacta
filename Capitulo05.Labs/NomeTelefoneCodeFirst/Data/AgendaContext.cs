using Microsoft.EntityFrameworkCore;
using NomeTelefoneCodeFirst.Models;

namespace NomeTelefoneCodeFirst.Data
{
    public class AgendaContext : DbContext
    {
        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options) { }

        public DbSet<Agenda> Agendamentos { get; set; } = null!;
    }
}
