using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MasterAdvantage.Migrations
{
    /// <inheritdoc />
    public partial class AddProps : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CurrentGritPoints",
                table: "EncounterItems",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CurrentRestPoints",
                table: "EncounterItems",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeathThreshold",
                table: "Creatures",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GritPoints",
                table: "Creatures",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RestPoints",
                table: "Creatures",
                type: "INTEGER",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CurrentGritPoints",
                table: "EncounterItems");

            migrationBuilder.DropColumn(
                name: "CurrentRestPoints",
                table: "EncounterItems");

            migrationBuilder.DropColumn(
                name: "DeathThreshold",
                table: "Creatures");

            migrationBuilder.DropColumn(
                name: "GritPoints",
                table: "Creatures");

            migrationBuilder.DropColumn(
                name: "RestPoints",
                table: "Creatures");
        }
    }
}
