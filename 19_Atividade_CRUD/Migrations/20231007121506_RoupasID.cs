using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _19_Atividade_CRUD.Migrations
{
    /// <inheritdoc />
    public partial class RoupasID : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "JogoId",
                table: "Roupas",
                newName: "RoupaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RoupaId",
                table: "Roupas",
                newName: "JogoId");
        }
    }
}
