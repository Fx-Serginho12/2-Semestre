using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Projeto.Migrations
{
    /// <inheritdoc />
    public partial class Atualizacao03 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Categorias_CategoriaID",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_CategoriaID",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "CategoriaID",
                table: "Usuarios");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoriaID",
                table: "Usuarios",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_CategoriaID",
                table: "Usuarios",
                column: "CategoriaID");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Categorias_CategoriaID",
                table: "Usuarios",
                column: "CategoriaID",
                principalTable: "Categorias",
                principalColumn: "CategoriaId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
