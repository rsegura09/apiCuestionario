using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace apiCuestionario.Migrations
{
    /// <inheritdoc />
    public partial class ChangeNamesDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Respuesta",
                table: "Respuesta");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pregunta",
                table: "Pregunta");

            migrationBuilder.RenameTable(
                name: "Respuesta",
                newName: "Respuestas");

            migrationBuilder.RenameTable(
                name: "Pregunta",
                newName: "Preguntas");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Respuestas",
                table: "Respuestas",
                column: "IdRespuesta");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Preguntas",
                table: "Preguntas",
                column: "IdPregunta");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Respuestas",
                table: "Respuestas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Preguntas",
                table: "Preguntas");

            migrationBuilder.RenameTable(
                name: "Respuestas",
                newName: "Respuesta");

            migrationBuilder.RenameTable(
                name: "Preguntas",
                newName: "Pregunta");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Respuesta",
                table: "Respuesta",
                column: "IdRespuesta");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pregunta",
                table: "Pregunta",
                column: "IdPregunta");
        }
    }
}
