using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MasterAdvantage.Migrations
{
    /// <inheritdoc />
    public partial class InitialCommit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Creatures",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    MaxHP = table.Column<int>(type: "INTEGER", nullable: false),
                    MaxMana = table.Column<int>(type: "INTEGER", nullable: false),
                    MaxStamina = table.Column<int>(type: "INTEGER", nullable: false),
                    ActionPoints = table.Column<int>(type: "INTEGER", nullable: false),
                    PD = table.Column<int>(type: "INTEGER", nullable: false),
                    MD = table.Column<int>(type: "INTEGER", nullable: false),
                    PDR = table.Column<int>(type: "INTEGER", nullable: false),
                    MDR = table.Column<int>(type: "INTEGER", nullable: false),
                    Discriminator = table.Column<string>(type: "TEXT", maxLength: 13, nullable: false),
                    PlayerName = table.Column<string>(type: "TEXT", nullable: true),
                    Level = table.Column<int>(type: "INTEGER", nullable: true),
                    Might = table.Column<int>(type: "INTEGER", nullable: true),
                    MightSave = table.Column<bool>(type: "INTEGER", nullable: true),
                    Agility = table.Column<int>(type: "INTEGER", nullable: true),
                    AgilitySave = table.Column<bool>(type: "INTEGER", nullable: true),
                    Charisma = table.Column<int>(type: "INTEGER", nullable: true),
                    CharismaSave = table.Column<bool>(type: "INTEGER", nullable: true),
                    Intelligence = table.Column<int>(type: "INTEGER", nullable: true),
                    IntelligenceSave = table.Column<bool>(type: "INTEGER", nullable: true),
                    AwarenessMastery = table.Column<int>(type: "INTEGER", nullable: true),
                    AthleticsMastery = table.Column<int>(type: "INTEGER", nullable: true),
                    IntimidationMastery = table.Column<int>(type: "INTEGER", nullable: true),
                    AcrobaticsMastery = table.Column<int>(type: "INTEGER", nullable: true),
                    TrickeryMastery = table.Column<int>(type: "INTEGER", nullable: true),
                    StealthMastery = table.Column<int>(type: "INTEGER", nullable: true),
                    AnimalMastery = table.Column<int>(type: "INTEGER", nullable: true),
                    InfluenceMastery = table.Column<int>(type: "INTEGER", nullable: true),
                    InsightMastery = table.Column<int>(type: "INTEGER", nullable: true),
                    InvestigationMastery = table.Column<int>(type: "INTEGER", nullable: true),
                    MedicineMastery = table.Column<int>(type: "INTEGER", nullable: true),
                    SurvivalMastery = table.Column<int>(type: "INTEGER", nullable: true),
                    ArcanaMastery = table.Column<int>(type: "INTEGER", nullable: true),
                    HistoryMastery = table.Column<int>(type: "INTEGER", nullable: true),
                    NatureMastery = table.Column<int>(type: "INTEGER", nullable: true),
                    OccultismMastery = table.Column<int>(type: "INTEGER", nullable: true),
                    ReligionMastery = table.Column<int>(type: "INTEGER", nullable: true),
                    CustomKnowledge1Name = table.Column<string>(type: "TEXT", nullable: true),
                    CustomKnowledge1Mastery = table.Column<int>(type: "INTEGER", nullable: true),
                    CustomKnowledge2Name = table.Column<string>(type: "TEXT", nullable: true),
                    CustomKnowledge2Mastery = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Creatures", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Encounters",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Encounters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EncounterItems",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Initiative = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatureId = table.Column<Guid>(type: "TEXT", nullable: true),
                    CurrentHP = table.Column<int>(type: "INTEGER", nullable: false),
                    CurrentMana = table.Column<int>(type: "INTEGER", nullable: false),
                    CurrentStamina = table.Column<int>(type: "INTEGER", nullable: false),
                    Action1 = table.Column<bool>(type: "INTEGER", nullable: false),
                    Action2 = table.Column<bool>(type: "INTEGER", nullable: false),
                    Action3 = table.Column<bool>(type: "INTEGER", nullable: false),
                    Action4 = table.Column<bool>(type: "INTEGER", nullable: false),
                    EncounterId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EncounterItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EncounterItems_Creatures_CreatureId",
                        column: x => x.CreatureId,
                        principalTable: "Creatures",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EncounterItems_Encounters_EncounterId",
                        column: x => x.EncounterId,
                        principalTable: "Encounters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Creatures",
                columns: new[] { "Id", "AcrobaticsMastery", "ActionPoints", "Agility", "AgilitySave", "AnimalMastery", "ArcanaMastery", "AthleticsMastery", "AwarenessMastery", "Charisma", "CharismaSave", "CustomKnowledge1Mastery", "CustomKnowledge1Name", "CustomKnowledge2Mastery", "CustomKnowledge2Name", "Discriminator", "HistoryMastery", "InfluenceMastery", "InsightMastery", "Intelligence", "IntelligenceSave", "IntimidationMastery", "InvestigationMastery", "Level", "MD", "MDR", "MaxHP", "MaxMana", "MaxStamina", "MedicineMastery", "Might", "MightSave", "Name", "NatureMastery", "OccultismMastery", "PD", "PDR", "PlayerName", "ReligionMastery", "StealthMastery", "SurvivalMastery", "TrickeryMastery" },
                values: new object[,]
                {
                    { new Guid("050d6568-57f0-4a44-801c-f122192221be"), 0, 4, 0, false, 0, 0, 0, 0, 0, false, 0, "", 0, "", "Character", 0, 0, 0, 0, false, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, false, "The Bear Dru", 0, 0, 0, 0, "Nate", 0, 0, 0, 0 },
                    { new Guid("1e6075ff-f16c-46ac-a16a-59ae37cc0300"), 0, 4, 0, false, 0, 0, 0, 0, 0, false, 0, "", 0, "", "Character", 0, 0, 0, 0, false, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, false, "Marf", 0, 0, 0, 0, "Spence", 0, 0, 0, 0 },
                    { new Guid("5517fa17-9012-4008-8821-b59d322cf94c"), 0, 4, 0, false, 0, 0, 0, 0, 0, false, 0, "", 0, "", "Character", 0, 0, 0, 0, false, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, false, "Kerf", 0, 0, 0, 0, "Alex", 0, 0, 0, 0 },
                    { new Guid("a35f7eb0-38a6-4c94-9e80-570f5ae930c1"), 0, 4, 0, false, 0, 0, 0, 0, 0, false, 0, "", 0, "", "Character", 0, 0, 0, 0, false, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, false, "Ishraq", 0, 0, 0, 0, "James", 0, 0, 0, 0 }
                });

            migrationBuilder.InsertData(
                table: "Encounters",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("bb2c10ef-6241-43cc-9ed2-992a2f943cf8"), "First Encounter" });

            migrationBuilder.InsertData(
                table: "EncounterItems",
                columns: new[] { "Id", "Action1", "Action2", "Action3", "Action4", "CreatureId", "CurrentHP", "CurrentMana", "CurrentStamina", "EncounterId", "Initiative" },
                values: new object[,]
                {
                    { new Guid("3fcc042a-80c1-4a1f-a97e-4c8ee90e6251"), false, false, false, false, new Guid("1e6075ff-f16c-46ac-a16a-59ae37cc0300"), 0, 0, 0, new Guid("bb2c10ef-6241-43cc-9ed2-992a2f943cf8"), 0 },
                    { new Guid("5374ebf5-cdaa-4165-8a62-06df1dc3bad6"), false, false, false, false, new Guid("050d6568-57f0-4a44-801c-f122192221be"), 0, 0, 0, new Guid("bb2c10ef-6241-43cc-9ed2-992a2f943cf8"), 0 },
                    { new Guid("7e04cf58-c4a3-4db3-b9b3-3fdd4dda455c"), false, false, false, false, new Guid("5517fa17-9012-4008-8821-b59d322cf94c"), 0, 0, 0, new Guid("bb2c10ef-6241-43cc-9ed2-992a2f943cf8"), 0 },
                    { new Guid("ad4d0dc6-39c9-4d87-9321-d77dfe929afb"), false, false, false, false, new Guid("a35f7eb0-38a6-4c94-9e80-570f5ae930c1"), 0, 0, 0, new Guid("bb2c10ef-6241-43cc-9ed2-992a2f943cf8"), 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_EncounterItems_CreatureId",
                table: "EncounterItems",
                column: "CreatureId");

            migrationBuilder.CreateIndex(
                name: "IX_EncounterItems_EncounterId",
                table: "EncounterItems",
                column: "EncounterId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EncounterItems");

            migrationBuilder.DropTable(
                name: "Creatures");

            migrationBuilder.DropTable(
                name: "Encounters");
        }
    }
}
