using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lauerp_Infra.Migrations
{
    /// <inheritdoc />
    public partial class AlteraçãoAula : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Ano",
                table: "Aulas",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Semestre",
                table: "Aulas",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ano",
                table: "Aulas");

            migrationBuilder.DropColumn(
                name: "Semestre",
                table: "Aulas");
        }
    }
}
