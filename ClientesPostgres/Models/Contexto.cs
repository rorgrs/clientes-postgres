using Microsoft.EntityFrameworkCore;

namespace ClientesPostgres.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options)
            : base(options) { }

        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Cliente>()
                .HasIndex(c => c.CNPJ)
                .IsUnique();
        }

    }
}
