using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    /// <inheritdoc />
    public partial class ArreglarModeloNivel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CantidadDeAlumnos",
                table: "Nivel");

            migrationBuilder.RenameColumn(
                name: "Grado",
                table: "Nivel",
                newName: "Nombre");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "Nivel",
                newName: "Grado");

            migrationBuilder.AddColumn<int>(
                name: "CantidadDeAlumnos",
                table: "Nivel",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
