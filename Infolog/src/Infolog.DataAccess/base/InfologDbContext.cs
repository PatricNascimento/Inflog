using Infolog.Domain.Entities;

using Microsoft.EntityFrameworkCore;

namespace Infolog.DataAccess
{
    public class InfologDbContext : DbContext
    {
        public InfologDbContext(DbContextOptions<InfologDbContext> options) : base(options)
        {
            //if (Database.ProviderName != "Microsoft.EntityFrameworkCore.InMemory")
                //Database.Migrate();
        }


        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Entregador> Entregadores { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => e.Id);
            });
            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.Id);
            });
            modelBuilder.Entity<Entregador>(entity =>
            {
                entity.HasKey(e => e.Id);
            });
            modelBuilder.Entity<Endereco>(entity =>
            {
                entity.HasKey(e => e.Id);
            });
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(InfologDbContext).Assembly);
        }

    }

}