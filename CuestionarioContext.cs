using apiCuestionario.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace apiCuestionario
{
    public class CuestionarioContext : DbContext
    {
        public DbSet<Cuestionario> Cuestionarios {  get; set; }

        public CuestionarioContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cuestionario>(cuestionario =>
            {
                cuestionario.ToTable("Cuestionarios");
                cuestionario.HasKey(p => p.IdCuestionario);
                cuestionario.Property(p => p.IdPersona);
                cuestionario.Property(p => p.Titulo).HasMaxLength(250);
                cuestionario.Property(p => p.Descripcion).HasMaxLength(250);
                cuestionario.Property(p => p.FechaDeCreacion).HasColumnType("datetime");
                cuestionario.Property(p => p.FechaDeEjecucion).HasColumnType("datetime");
            });


        }


    }
}
