using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lauerp_Infra.Migrations
{
    /// <inheritdoc />
    public partial class AdicionandoProfessorProperties : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CPF",
                table: "Professores",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "DataNascimento",
                table: "Professores",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Professores",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "Professores",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Telefone",
                table: "Professores",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CPF",
                table: "Professores");

            migrationBuilder.DropColumn(
                name: "DataNascimento",
                table: "Professores");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Professores");

            migrationBuilder.DropColumn(
                name: "Nome",
                table: "Professores");

            migrationBuilder.DropColumn(
                name: "Telefone",
                table: "Professores");
        }
    }
}
