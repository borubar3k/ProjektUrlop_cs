using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjektUrlop.Migrations
{
    /// <inheritdoc />
    public partial class dodano_tab_Logowania : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "logowania",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_pracownika = table.Column<int>(type: "int", nullable: false),
                    DataLogowania = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_logowania", x => x.Id);
                    table.ForeignKey(
                        name: "FK_logowania_pracownicy_Id_pracownika",
                        column: x => x.Id_pracownika,
                        principalTable: "pracownicy",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
            migrationBuilder.CreateIndex(
            name: "IX_logowania_Id_pracownika",
            table: "logowania",
            column: "Id_pracownika");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "logowania");
        }
    }
}
