using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MasterAdvantage.Migrations
{
    /// <inheritdoc />
    public partial class AddMonsterProps : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Actions",
                table: "Creatures",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Enhancements",
                table: "Creatures",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Features",
                table: "Creatures",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Languages",
                table: "Creatures",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Reactions",
                table: "Creatures",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Senses",
                table: "Creatures",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Actions",
                table: "Creatures");

            migrationBuilder.DropColumn(
                name: "Enhancements",
                table: "Creatures");

            migrationBuilder.DropColumn(
                name: "Features",
                table: "Creatures");

            migrationBuilder.DropColumn(
                name: "Languages",
                table: "Creatures");

            migrationBuilder.DropColumn(
                name: "Reactions",
                table: "Creatures");

            migrationBuilder.DropColumn(
                name: "Senses",
                table: "Creatures");
        }
    }
}
