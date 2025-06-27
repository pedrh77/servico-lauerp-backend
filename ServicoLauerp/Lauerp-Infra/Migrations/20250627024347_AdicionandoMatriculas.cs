using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Lauerp_Infra.Migrations
{
    /// <inheritdoc />
    public partial class AdicionandoMatriculas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Presencas_Aulas_AulaId",
                table: "Presencas");

            migrationBuilder.DropForeignKey(
                name: "FK_Presencas_Esportes_EsporteId",
                table: "Presencas");

            migrationBuilder.DropForeignKey(
                name: "FK_Presencas_Jogadores_JogadorId",
                table: "Presencas");

            migrationBuilder.DropIndex(
                name: "IX_Presencas_AulaId",
                table: "Presencas");

            migrationBuilder.DropIndex(
                name: "IX_Presencas_EsporteId",
                table: "Presencas");

            migrationBuilder.DropColumn(
                name: "AulaId",
                table: "Presencas");

            migrationBuilder.DropColumn(
                name: "EsporteId",
                table: "Presencas");

            migrationBuilder.DropColumn(
                name: "DataHora",
                table: "Aulas");

            migrationBuilder.RenameColumn(
                name: "JogadorId",
                table: "Presencas",
                newName: "MatriculaId");

            migrationBuilder.RenameIndex(
                name: "IX_Presencas_JogadorId",
                table: "Presencas",
                newName: "IX_Presencas_MatriculaId");

            migrationBuilder.CreateTable(
                name: "Matriculas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    JogadorId = table.Column<int>(type: "integer", nullable: false),
                    AulaId = table.Column<int>(type: "integer", nullable: false),
                    Criado_em = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Modificado_em = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Matriculas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Matriculas_Aulas_AulaId",
                        column: x => x.AulaId,
                        principalTable: "Aulas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Matriculas_Jogadores_JogadorId",
                        column: x => x.JogadorId,
                        principalTable: "Jogadores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Matriculas_AulaId",
                table: "Matriculas",
                column: "AulaId");

            migrationBuilder.CreateIndex(
                name: "IX_Matriculas_JogadorId",
                table: "Matriculas",
                column: "JogadorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Presencas_Matriculas_MatriculaId",
                table: "Presencas",
                column: "MatriculaId",
                principalTable: "Matriculas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Presencas_Matriculas_MatriculaId",
                table: "Presencas");

            migrationBuilder.DropTable(
                name: "Matriculas");

            migrationBuilder.RenameColumn(
                name: "MatriculaId",
                table: "Presencas",
                newName: "JogadorId");

            migrationBuilder.RenameIndex(
                name: "IX_Presencas_MatriculaId",
                table: "Presencas",
                newName: "IX_Presencas_JogadorId");

            migrationBuilder.AddColumn<int>(
                name: "AulaId",
                table: "Presencas",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EsporteId",
                table: "Presencas",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataHora",
                table: "Aulas",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateIndex(
                name: "IX_Presencas_AulaId",
                table: "Presencas",
                column: "AulaId");

            migrationBuilder.CreateIndex(
                name: "IX_Presencas_EsporteId",
                table: "Presencas",
                column: "EsporteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Presencas_Aulas_AulaId",
                table: "Presencas",
                column: "AulaId",
                principalTable: "Aulas",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Presencas_Esportes_EsporteId",
                table: "Presencas",
                column: "EsporteId",
                principalTable: "Esportes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Presencas_Jogadores_JogadorId",
                table: "Presencas",
                column: "JogadorId",
                principalTable: "Jogadores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
