using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProdutosApi.Migrations
{
    /// <inheritdoc />
    public partial class AjusteTituloDescricao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Produtos",
                newName: "Titulo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Titulo",
                table: "Produtos",
                newName: "Title");
        }
    }
}
