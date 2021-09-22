using Microsoft.EntityFrameworkCore;
using MascotaFeliz.App.Dominio;

namespace MascotaFeliz.App.Persistencia {
    
    public class AppContext : DbContext {

        public DbSet<Mascota> Mascotas { get; set; }
        public DbSet<Veterinario> Veterinarios { get; set; }
        public DbSet<Propietario> Propietarios { get; set; }
        public DbSet<RegistroVisita> RegistrosVisitas { get; set; }
        public DbSet<MascotaVeterinario> MascotasVeterinarios { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
        if (!optionsBuilder.IsConfigured) {
            optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = MascotaFeliz.Data");
        }

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder) { 
            modelBuilder.Entity<MascotaVeterinario>().HasKey(x => new{x.VeterinarioId, x.MascotaId}); 
        }

    }
}