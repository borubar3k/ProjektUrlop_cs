using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjektUrlop.Migrations
{
    /// <inheritdoc />
    public partial class dodano_IsAppr : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsAppr",
                table: "urlopy",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsAppr",
                table: "urlopy");
        }
    }
}
