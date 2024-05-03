using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace apiCuestionario.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cuestionarios",
                columns: table => new
                {
                    IdCuestionario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdPersona = table.Column<int>(type: "int", nullable: false),
                    Titulo = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Descripcion = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    FechaDeCreacion = table.Column<DateTime>(type: "datetime", nullable: false),
                    FechaDeEjecucion = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cuestionarios", x => x.IdCuestionario);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cuestionarios");
        }
    }
}
