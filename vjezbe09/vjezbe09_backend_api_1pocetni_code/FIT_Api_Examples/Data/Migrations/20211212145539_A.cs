using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FIT_Api_Examples.Data.Migrations
{
    public partial class A : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_KorisnickiNalog_Opstina_opstina_rodjenja_id",
                table: "KorisnickiNalog");

            migrationBuilder.DropIndex(
                name: "IX_KorisnickiNalog_opstina_rodjenja_id",
                table: "KorisnickiNalog");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "KorisnickiNalog");

            migrationBuilder.DropColumn(
                name: "broj_indeksa",
                table: "KorisnickiNalog");

            migrationBuilder.DropColumn(
                name: "created_time",
                table: "KorisnickiNalog");

            migrationBuilder.DropColumn(
                name: "datum_rodjenja",
                table: "KorisnickiNalog");

            migrationBuilder.DropColumn(
                name: "ime",
                table: "KorisnickiNalog");

            migrationBuilder.DropColumn(
                name: "opstina_rodjenja_id",
                table: "KorisnickiNalog");

            migrationBuilder.DropColumn(
                name: "prezime",
                table: "KorisnickiNalog");

            migrationBuilder.DropColumn(
                name: "slika_studenta",
                table: "KorisnickiNalog");

            migrationBuilder.DropColumn(
                name: "Nastavnik_ime",
                table: "KorisnickiNalog");

            migrationBuilder.DropColumn(
                name: "Nastavnik_prezime",
                table: "KorisnickiNalog");

            migrationBuilder.CreateTable(
                name: "Nastavnik",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ime = table.Column<string>(nullable: true),
                    prezime = table.Column<string>(nullable: true),
                    korisnickoIme = table.Column<string>(nullable: true),
                    lozinka = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nastavnik", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ime = table.Column<string>(nullable: true),
                    prezime = table.Column<string>(nullable: true),
                    broj_indeksa = table.Column<string>(nullable: true),
                    opstina_rodjenja_id = table.Column<int>(nullable: true),
                    datum_rodjenja = table.Column<DateTime>(nullable: true),
                    created_time = table.Column<DateTime>(nullable: false),
                    slika_studenta = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.id);
                    table.ForeignKey(
                        name: "FK_Student_Opstina_opstina_rodjenja_id",
                        column: x => x.opstina_rodjenja_id,
                        principalTable: "Opstina",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Student_opstina_rodjenja_id",
                table: "Student",
                column: "opstina_rodjenja_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Nastavnik");

            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "KorisnickiNalog",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "broj_indeksa",
                table: "KorisnickiNalog",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "created_time",
                table: "KorisnickiNalog",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "datum_rodjenja",
                table: "KorisnickiNalog",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ime",
                table: "KorisnickiNalog",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "opstina_rodjenja_id",
                table: "KorisnickiNalog",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "prezime",
                table: "KorisnickiNalog",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "slika_studenta",
                table: "KorisnickiNalog",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nastavnik_ime",
                table: "KorisnickiNalog",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nastavnik_prezime",
                table: "KorisnickiNalog",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_KorisnickiNalog_opstina_rodjenja_id",
                table: "KorisnickiNalog",
                column: "opstina_rodjenja_id");

            migrationBuilder.AddForeignKey(
                name: "FK_KorisnickiNalog_Opstina_opstina_rodjenja_id",
                table: "KorisnickiNalog",
                column: "opstina_rodjenja_id",
                principalTable: "Opstina",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
