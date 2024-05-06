using apiCuestionario.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace apiCuestionario
{
    public class CuestionarioContext : DbContext
    {
        public DbSet<Cuestionario> Cuestionarios { get; set; }

        public DbSet<Persona> Personas { get; set; }

        public CuestionarioContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cuestionario>(cuestionario =>
            {
                cuestionario.ToTable("Cuestionarios");
                cuestionario.HasKey(p => p.IdCuestionario);
                cuestionario.Property(p => p.IdCuestionario).UseIdentityColumn();
                cuestionario.Property(p => p.IdPersona);
                cuestionario.Property(p => p.Titulo).HasMaxLength(250);
                cuestionario.Property(p => p.Descripcion).HasMaxLength(250);
                cuestionario.Property(p => p.FechaDeCreacion).HasColumnType("datetime");
                cuestionario.Property(p => p.FechaDeEjecucion).HasColumnType("datetime");
            });

            modelBuilder.Entity<Persona>(persona =>
            {
                persona.ToTable("Personas");
                persona.HasKey(p => p.IdPersona);
                persona.Property(p => p.IdPersona).UseIdentityColumn();
                persona.Property(p => p.NombreUsuario).HasMaxLength(250);
                persona.Property(p => p.Contrasenna).HasMaxLength(250);
                persona.Property(p => p.Nombre).HasMaxLength(250);
                persona.Property(p => p.Correo).HasMaxLength(250);
                persona.Property(p => p.FechaDeRegistro).HasColumnType("datetime");
                persona.Property(p => p.Rol).HasMaxLength(5);
            });

        }
    }
}