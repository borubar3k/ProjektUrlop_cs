using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjektUrlop.Migrations
{
    /// <inheritdoc />
    public partial class dodano_DataZatrudnienia : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DataZatrudnienia",
                table: "pracownicy",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataZatrudnienia",
                table: "pracownicy");
        }
    }
}
