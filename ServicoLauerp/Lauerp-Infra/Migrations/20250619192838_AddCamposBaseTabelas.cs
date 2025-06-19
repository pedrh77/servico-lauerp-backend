using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lauerp_Infra.Migrations
{
    /// <inheritdoc />
    public partial class AddCamposBaseTabelas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CPF",
                table: "Jogadores",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "DataNascimento",
                table: "Jogadores",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Jogadores",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "Jogadores",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Telefone",
                table: "Jogadores",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "Criado_em",
                table: "Eventos",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Eventos",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "Modificado_em",
                table: "Eventos",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Descricao",
                table: "Esportes",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Titulo",
                table: "Esportes",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CPF",
                table: "Jogadores");

            migrationBuilder.DropColumn(
                name: "DataNascimento",
                table: "Jogadores");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Jogadores");

            migrationBuilder.DropColumn(
                name: "Nome",
                table: "Jogadores");

            migrationBuilder.DropColumn(
                name: "Telefone",
                table: "Jogadores");

            migrationBuilder.DropColumn(
                name: "Criado_em",
                table: "Eventos");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Eventos");

            migrationBuilder.DropColumn(
                name: "Modificado_em",
                table: "Eventos");

            migrationBuilder.DropColumn(
                name: "Descricao",
                table: "Esportes");

            migrationBuilder.DropColumn(
                name: "Titulo",
                table: "Esportes");
        }
    }
}
