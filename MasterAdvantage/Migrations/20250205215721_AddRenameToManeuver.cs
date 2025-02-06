using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MasterAdvantage.Migrations
{
    /// <inheritdoc />
    public partial class AddRenameToManeuver : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TechniqueEnhancements");

            migrationBuilder.DropTable(
                name: "Techniques");

            migrationBuilder.CreateTable(
                name: "Maneuvers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    AP = table.Column<int>(type: "INTEGER", nullable: false),
                    SP = table.Column<int>(type: "INTEGER", nullable: false),
                    Category = table.Column<int>(type: "INTEGER", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    CreatureId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Maneuvers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Maneuvers_Creatures_CreatureId",
                        column: x => x.CreatureId,
                        principalTable: "Creatures",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ManeuverEnhancements",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    ManeuverId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    AP = table.Column<int>(type: "INTEGER", nullable: false),
                    SP = table.Column<int>(type: "INTEGER", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManeuverEnhancements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ManeuverEnhancements_Maneuvers_ManeuverId",
                        column: x => x.ManeuverId,
                        principalTable: "Maneuvers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ManeuverEnhancements_ManeuverId",
                table: "ManeuverEnhancements",
                column: "ManeuverId");

            migrationBuilder.CreateIndex(
                name: "IX_Maneuvers_CreatureId",
                table: "Maneuvers",
                column: "CreatureId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ManeuverEnhancements");

            migrationBuilder.DropTable(
                name: "Maneuvers");

            migrationBuilder.CreateTable(
                name: "Techniques",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    AP = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatureId = table.Column<Guid>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    SP = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Techniques", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Techniques_Creatures_CreatureId",
                        column: x => x.CreatureId,
                        principalTable: "Creatures",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TechniqueEnhancements",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    TechniqueId = table.Column<Guid>(type: "TEXT", nullable: false),
                    AP = table.Column<int>(type: "INTEGER", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    SP = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TechniqueEnhancements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TechniqueEnhancements_Techniques_TechniqueId",
                        column: x => x.TechniqueId,
                        principalTable: "Techniques",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TechniqueEnhancements_TechniqueId",
                table: "TechniqueEnhancements",
                column: "TechniqueId");

            migrationBuilder.CreateIndex(
                name: "IX_Techniques_CreatureId",
                table: "Techniques",
                column: "CreatureId");
        }
    }
}
