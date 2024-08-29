using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MasterAdvantage.Migrations
{
    /// <inheritdoc />
    public partial class AddHidden : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EncounterItems",
                keyColumn: "Id",
                keyValue: new Guid("3fcc042a-80c1-4a1f-a97e-4c8ee90e6251"));

            migrationBuilder.DeleteData(
                table: "EncounterItems",
                keyColumn: "Id",
                keyValue: new Guid("5374ebf5-cdaa-4165-8a62-06df1dc3bad6"));

            migrationBuilder.DeleteData(
                table: "EncounterItems",
                keyColumn: "Id",
                keyValue: new Guid("7e04cf58-c4a3-4db3-b9b3-3fdd4dda455c"));

            migrationBuilder.DeleteData(
                table: "EncounterItems",
                keyColumn: "Id",
                keyValue: new Guid("ad4d0dc6-39c9-4d87-9321-d77dfe929afb"));

            migrationBuilder.DeleteData(
                table: "Creatures",
                keyColumn: "Id",
                keyValue: new Guid("050d6568-57f0-4a44-801c-f122192221be"));

            migrationBuilder.DeleteData(
                table: "Creatures",
                keyColumn: "Id",
                keyValue: new Guid("1e6075ff-f16c-46ac-a16a-59ae37cc0300"));

            migrationBuilder.DeleteData(
                table: "Creatures",
                keyColumn: "Id",
                keyValue: new Guid("5517fa17-9012-4008-8821-b59d322cf94c"));

            migrationBuilder.DeleteData(
                table: "Creatures",
                keyColumn: "Id",
                keyValue: new Guid("a35f7eb0-38a6-4c94-9e80-570f5ae930c1"));

            migrationBuilder.DeleteData(
                table: "Encounters",
                keyColumn: "Id",
                keyValue: new Guid("bb2c10ef-6241-43cc-9ed2-992a2f943cf8"));

            migrationBuilder.AddColumn<bool>(
                name: "Hidden",
                table: "EncounterItems",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "Creatures",
                columns: new[] { "Id", "AcrobaticsMastery", "ActionPoints", "Agility", "AgilitySave", "AnimalMastery", "ArcanaMastery", "AthleticsMastery", "AwarenessMastery", "Charisma", "CharismaSave", "CustomKnowledge1Mastery", "CustomKnowledge1Name", "CustomKnowledge2Mastery", "CustomKnowledge2Name", "Discriminator", "HistoryMastery", "InfluenceMastery", "InsightMastery", "Intelligence", "IntelligenceSave", "IntimidationMastery", "InvestigationMastery", "Level", "MD", "MDR", "MaxHP", "MaxMana", "MaxStamina", "MedicineMastery", "Might", "MightSave", "Name", "NatureMastery", "OccultismMastery", "PD", "PDR", "PlayerName", "ReligionMastery", "StealthMastery", "SurvivalMastery", "TrickeryMastery" },
                values: new object[,]
                {
                    { new Guid("30198d67-bba4-4114-8bee-61d29a40f48c"), 0, 4, 0, false, 0, 0, 0, 0, 0, false, 0, "", 0, "", "Character", 0, 0, 0, 0, false, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, false, "The Bear Dru", 0, 0, 0, 0, "Nate", 0, 0, 0, 0 },
                    { new Guid("65f75ecb-b94c-496c-ad43-bad6c28831b3"), 0, 4, 0, false, 0, 0, 0, 0, 0, false, 0, "", 0, "", "Character", 0, 0, 0, 0, false, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, false, "Kerf", 0, 0, 0, 0, "Alex", 0, 0, 0, 0 },
                    { new Guid("677ad4bb-439f-4641-acfe-63a4a3f2344a"), 0, 4, 0, false, 0, 0, 0, 0, 0, false, 0, "", 0, "", "Character", 0, 0, 0, 0, false, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, false, "Marf", 0, 0, 0, 0, "Spence", 0, 0, 0, 0 },
                    { new Guid("7401117c-c728-4381-97c2-2fd2040d7360"), 0, 4, 0, false, 0, 0, 0, 0, 0, false, 0, "", 0, "", "Character", 0, 0, 0, 0, false, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, false, "Ishraq", 0, 0, 0, 0, "James", 0, 0, 0, 0 }
                });

            migrationBuilder.InsertData(
                table: "Encounters",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("e4bd3662-5307-463b-a05f-874461de7e0c"), "First Encounter" });

            migrationBuilder.InsertData(
                table: "EncounterItems",
                columns: new[] { "Id", "Action1", "Action2", "Action3", "Action4", "CreatureId", "CurrentHP", "CurrentMana", "CurrentStamina", "EncounterId", "Hidden", "Initiative" },
                values: new object[,]
                {
                    { new Guid("254857d7-0287-45a2-8e34-e6895f31df5c"), false, false, false, false, new Guid("677ad4bb-439f-4641-acfe-63a4a3f2344a"), 0, 0, 0, new Guid("e4bd3662-5307-463b-a05f-874461de7e0c"), false, 0 },
                    { new Guid("5d86da12-e15b-4d06-972b-359131c2b3fb"), false, false, false, false, new Guid("7401117c-c728-4381-97c2-2fd2040d7360"), 0, 0, 0, new Guid("e4bd3662-5307-463b-a05f-874461de7e0c"), false, 0 },
                    { new Guid("b5c6979e-badd-4bec-bb4e-5e8fa57abd08"), false, false, false, false, new Guid("30198d67-bba4-4114-8bee-61d29a40f48c"), 0, 0, 0, new Guid("e4bd3662-5307-463b-a05f-874461de7e0c"), false, 0 },
                    { new Guid("e0448996-7aa0-494d-b072-77230e36be0b"), false, false, false, false, new Guid("65f75ecb-b94c-496c-ad43-bad6c28831b3"), 0, 0, 0, new Guid("e4bd3662-5307-463b-a05f-874461de7e0c"), false, 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EncounterItems",
                keyColumn: "Id",
                keyValue: new Guid("254857d7-0287-45a2-8e34-e6895f31df5c"));

            migrationBuilder.DeleteData(
                table: "EncounterItems",
                keyColumn: "Id",
                keyValue: new Guid("5d86da12-e15b-4d06-972b-359131c2b3fb"));

            migrationBuilder.DeleteData(
                table: "EncounterItems",
                keyColumn: "Id",
                keyValue: new Guid("b5c6979e-badd-4bec-bb4e-5e8fa57abd08"));

            migrationBuilder.DeleteData(
                table: "EncounterItems",
                keyColumn: "Id",
                keyValue: new Guid("e0448996-7aa0-494d-b072-77230e36be0b"));

            migrationBuilder.DeleteData(
                table: "Creatures",
                keyColumn: "Id",
                keyValue: new Guid("30198d67-bba4-4114-8bee-61d29a40f48c"));

            migrationBuilder.DeleteData(
                table: "Creatures",
                keyColumn: "Id",
                keyValue: new Guid("65f75ecb-b94c-496c-ad43-bad6c28831b3"));

            migrationBuilder.DeleteData(
                table: "Creatures",
                keyColumn: "Id",
                keyValue: new Guid("677ad4bb-439f-4641-acfe-63a4a3f2344a"));

            migrationBuilder.DeleteData(
                table: "Creatures",
                keyColumn: "Id",
                keyValue: new Guid("7401117c-c728-4381-97c2-2fd2040d7360"));

            migrationBuilder.DeleteData(
                table: "Encounters",
                keyColumn: "Id",
                keyValue: new Guid("e4bd3662-5307-463b-a05f-874461de7e0c"));

            migrationBuilder.DropColumn(
                name: "Hidden",
                table: "EncounterItems");

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
        }
    }
}
