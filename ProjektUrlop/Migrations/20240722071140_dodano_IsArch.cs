using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjektUrlop.Migrations
{
    /// <inheritdoc />
    public partial class dodano_IsArch : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsArch",
                table: "pracownicy",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsArch",
                table: "pracownicy");
        }
    }
}
