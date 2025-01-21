using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MasterAdvantage.Migrations
{
    /// <inheritdoc />
    public partial class AddTempHP : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TempHP",
                table: "EncounterItems",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TempHP",
                table: "EncounterItems");
        }
    }
}
