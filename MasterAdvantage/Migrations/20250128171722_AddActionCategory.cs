using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MasterAdvantage.Migrations
{
    /// <inheritdoc />
    public partial class AddActionCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Category",
                table: "Actions",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                table: "Actions");
        }
    }
}
