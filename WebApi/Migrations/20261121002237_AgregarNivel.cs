using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    /// <inheritdoc />
    public partial class AgregarNivel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Grado",
                table: "Curso",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "NivelId",
                table: "Curso",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Nivel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Grado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CantidadDeAlumnos = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nivel", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Curso_NivelId",
                table: "Curso",
                column: "NivelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Curso_Nivel_NivelId",
                table: "Curso",
                column: "NivelId",
                principalTable: "Nivel",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Curso_Nivel_NivelId",
                table: "Curso");

            migrationBuilder.DropTable(
                name: "Nivel");

            migrationBuilder.DropIndex(
                name: "IX_Curso_NivelId",
                table: "Curso");

            migrationBuilder.DropColumn(
                name: "NivelId",
                table: "Curso");

            migrationBuilder.AlterColumn<string>(
                name: "Grado",
                table: "Curso",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);
        }
    }
}
