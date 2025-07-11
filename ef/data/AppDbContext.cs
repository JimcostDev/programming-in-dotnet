using Microsoft.EntityFrameworkCore;
using curso_dotnet.ef.models;

namespace curso_dotnet.ef.data
{
    // DbContext configura el acceso a la base de datos y mapea entidades
    public class AppDbContext : DbContext
    {
        public DbSet<League> Leagues { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Cadena de conexión al servidor SQL
            optionsBuilder.UseSqlServer("Server=.\\LOCAL; Database=Test; User Id=user; Password=123456; TrustServerCertificate=True; Encrypt=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuraciones adicionales (ej. restricciones, índices)
            var entity = modelBuilder.Entity<League>();
             entity.ToTable("League", "dbo");
            entity.HasKey(t => t.Id);
            entity.Property(t => t.Name)
                  .IsRequired()
                  .HasMaxLength(100);
        }
    }
}
