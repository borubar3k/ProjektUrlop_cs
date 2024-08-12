using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjektUrlop.Migrations
{
    /// <inheritdoc />
    public partial class InitMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "pracownicy",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Imie = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nazwisko = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Haslo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsAdmin = table.Column<bool>(type: "bit", nullable: false),
                    DniUrlopu = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pracownicy", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "urlopy",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_pracownika = table.Column<int>(type: "int", nullable: false),
                    DataOD = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataDO = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LiczbaDni = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_urlopy", x => x.Id);
                    table.ForeignKey(
                        name: "FK_urlopy_pracownicy_Id_pracownika",
                        column: x => x.Id_pracownika,
                        principalTable: "pracownicy",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
            migrationBuilder.CreateIndex(
            name: "IX_urlopy_Id_pracownika",
            table: "urlopy",
            column: "Id_pracownika");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "pracownicy");

            migrationBuilder.DropTable(
                name: "urlopy");
        }
    }
}
