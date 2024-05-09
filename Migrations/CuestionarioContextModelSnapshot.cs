﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using apiCuestionario;

#nullable disable

namespace apiCuestionario.Migrations
{
    [DbContext(typeof(CuestionarioContext))]
    partial class CuestionarioContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("apiCuestionario.Models.Entities.Cuestionario", b =>
                {
                    b.Property<int>("IdCuestionario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCuestionario"));

                    b.Property<string>("Descripcion")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<DateTime>("FechaDeCreacion")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("FechaDeEjecucion")
                        .HasColumnType("datetime");

                    b.Property<int>("IdPersona")
                        .HasColumnType("int");

                    b.Property<string>("Titulo")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("IdCuestionario");

                    b.ToTable("Cuestionarios", (string)null);
                });

            modelBuilder.Entity("apiCuestionario.Models.Entities.Persona", b =>
                {
                    b.Property<int>("IdPersona")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPersona"));

                    b.Property<string>("Contrasenna")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Correo")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<DateTime>("FechaDeRegistro")
                        .HasColumnType("datetime");

                    b.Property<string>("Nombre")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("NombreUsuario")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Rol")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("IdPersona");

                    b.ToTable("Personas", (string)null);
                });

            modelBuilder.Entity("apiCuestionario.Models.Entities.Pregunta", b =>
                {
                    b.Property<int>("IdPregunta")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPregunta"));

                    b.Property<DateTime>("FechaDeEjecucion")
                        .HasColumnType("datetime");

                    b.Property<int>("IdCuestionario")
                        .HasColumnType("int");

                    b.Property<string>("PreguntaCampo")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)")
                        .HasColumnName("Pregunta");

                    b.Property<string>("TipoDePregunta")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("TipoDeRespuesta")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("IdPregunta");

                    b.ToTable("Pregunta", (string)null);
                });

            modelBuilder.Entity("apiCuestionario.Models.Entities.Respuesta", b =>
                {
                    b.Property<int>("IdRespuesta")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdRespuesta"));

                    b.Property<int>("IdPregunta")
                        .HasColumnType("int");

                    b.Property<string>("RespuestaCampo")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)")
                        .HasColumnName("Respuesta");

                    b.HasKey("IdRespuesta");

                    b.ToTable("Respuesta", (string)null);
                });

            modelBuilder.Entity("apiCuestionario.Models.Entities.RespuestaUsuario", b =>
                {
                    b.Property<int>("IdRespuestaUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdRespuestaUsuario"));

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime");

                    b.Property<int>("IdCuestionario")
                        .HasColumnType("int");

                    b.Property<int>("IdPersona")
                        .HasColumnType("int");

                    b.Property<int>("IdPregunta")
                        .HasColumnType("int");

                    b.Property<int>("IdRespuesta")
                        .HasColumnType("int");

                    b.HasKey("IdRespuestaUsuario");

                    b.ToTable("RespuestaUsuario", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
