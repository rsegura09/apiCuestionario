using apiCuestionario.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace apiCuestionario
{
    public class CuestionarioContext : DbContext
    {
        public DbSet<Cuestionario> Cuestionarios { get; set; }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Pregunta> Preguntas { get; set; }
        public DbSet<Respuesta> Respuestas { get; set; }
        public DbSet<RespuestaUsuario> RespuestaUsuario { get; set; }

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
                persona.Property(p => p.Rol).HasMaxLength(250);
            });

            modelBuilder.Entity<Pregunta>(pregunta =>
            {
                pregunta.ToTable("Pregunta");
                pregunta.HasKey( p => p.IdPregunta);
                pregunta.Property(p => p.IdPregunta).UseIdentityColumn();
                pregunta.Property(p => p.IdCuestionario);
                pregunta.Property(p => p.PreguntaCampo).HasColumnName("Pregunta").HasMaxLength(250);
                pregunta.Property(p => p.TipoDePregunta).HasMaxLength(250);
                pregunta.Property(p => p.TipoDeRespuesta).HasMaxLength(250);pregunta.Property(p => p.TipoDeRespuesta).HasMaxLength(250);
                pregunta.Property(p => p.FechaDeEjecucion).HasColumnType("datetime");
            });

            modelBuilder.Entity<Respuesta>(respuesta =>
            {
                respuesta.ToTable("Respuesta");
                respuesta.HasKey( p => p.IdRespuesta);
                respuesta.Property(p => p.IdRespuesta).UseIdentityColumn();
                respuesta.Property(p => p.IdPregunta);
                respuesta.Property(p => p.RespuestaCampo).HasColumnName("Respuesta").HasMaxLength(250);
            });

            modelBuilder.Entity<RespuestaUsuario>(respuestausuario => {
                respuestausuario.ToTable("RespuestaUsuario");
                respuestausuario.HasKey(p => p.IdRespuestaUsuario);
                respuestausuario.Property(p => p.IdRespuestaUsuario).UseIdentityColumn();
                respuestausuario.Property(p => p.IdCuestionario);
                respuestausuario.Property(p => p.IdPersona);
                respuestausuario.Property(p => p.IdPregunta);
                respuestausuario.Property(p => p.IdRespuesta);
                respuestausuario.Property(p => p.Fecha).HasColumnType("datetime");
            });
        }
    }
}