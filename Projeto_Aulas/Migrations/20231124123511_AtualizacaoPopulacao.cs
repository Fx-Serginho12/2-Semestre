using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Grafico.Migrations
{
    /// <inheritdoc />
    public partial class AtualizacaoPopulacao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Paises_Continentes_continenteID",
                table: "Paises");

            migrationBuilder.RenameColumn(
                name: "continenteID",
                table: "Paises",
                newName: "ContinenteID");

            migrationBuilder.RenameIndex(
                name: "IX_Paises_continenteID",
                table: "Paises",
                newName: "IX_Paises_ContinenteID");

            migrationBuilder.RenameColumn(
                name: "continenteID",
                table: "Continentes",
                newName: "ContinenteID");

            migrationBuilder.AlterColumn<int>(
                name: "Populacao",
                table: "Paises",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "TEXT");

            migrationBuilder.AddForeignKey(
                name: "FK_Paises_Continentes_ContinenteID",
                table: "Paises",
                column: "ContinenteID",
                principalTable: "Continentes",
                principalColumn: "ContinenteID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Paises_Continentes_ContinenteID",
                table: "Paises");

            migrationBuilder.RenameColumn(
                name: "ContinenteID",
                table: "Paises",
                newName: "continenteID");

            migrationBuilder.RenameIndex(
                name: "IX_Paises_ContinenteID",
                table: "Paises",
                newName: "IX_Paises_continenteID");

            migrationBuilder.RenameColumn(
                name: "ContinenteID",
                table: "Continentes",
                newName: "continenteID");

            migrationBuilder.AlterColumn<decimal>(
                name: "Populacao",
                table: "Paises",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_Paises_Continentes_continenteID",
                table: "Paises",
                column: "continenteID",
                principalTable: "Continentes",
                principalColumn: "continenteID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
