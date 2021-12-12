using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FIT_Api_Examples.Data.Migrations
{
    public partial class student_naslijeduje_korisnika : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.AddColumn<string>(
                name: "broj_indeksa",
                table: "KorisnickiNalog",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "created_time",
                table: "KorisnickiNalog",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "datum_rodjenja",
                table: "KorisnickiNalog",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "opstina_rodjenja_id",
                table: "KorisnickiNalog",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "slika_studenta",
                table: "KorisnickiNalog",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nastavnik_ime",
                table: "KorisnickiNalog",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nastavnik_prezime",
                table: "KorisnickiNalog",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_KorisnickiNalog_Opstina_opstina_rodjenja_id",
                table: "KorisnickiNalog");

            migrationBuilder.DropIndex(
                name: "IX_KorisnickiNalog_opstina_rodjenja_id",
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
                name: "opstina_rodjenja_id",
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
                name: "Student",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    broj_indeksa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    created_time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    datum_rodjenja = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    opstina_rodjenja_id = table.Column<int>(type: "int", nullable: true),
                    prezime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    slika_studenta = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
    }
}
