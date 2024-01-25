using ExamenDAW.Models.Comanda;
using ExamenDAW.Models.ComandaProdus;
using ExamenDAW.Models.Produs;
using ExamenDAW.Models.Utilizator;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;
namespace ExamenDAW.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Produs> Produs { get; set; }

        public DbSet<Comanda> Comanda { get; set; }

        public DbSet<ComandaProdus> ComandaProdus { get; set; }

        public DbSet<Utilizator> Utilizator { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Comanda>()
                .HasOne(b => b.Utilizator)
                .WithMany(a => a.Comanda)
                .HasForeignKey(b => b.UtilizatorId);


          
            modelBuilder.Entity<ComandaProdus>()
                 .HasOne(p => p.Comanda)
                 .WithMany(pc => pc.ComandaProdus)
                 .HasForeignKey(p => p.ComandaId);
           
            modelBuilder.Entity<ComandaProdus>()
                 .HasOne(p => p.Produs)
                 .WithMany(pc => pc.ComandaProdus)
                 .HasForeignKey(c => c.ProdusId);

            base.OnModelCreating(modelBuilder);
        }
    }
}