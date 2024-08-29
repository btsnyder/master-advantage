using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MasterAdvantage.Migrations
{
    /// <inheritdoc />
    public partial class ActionsUsedRefactor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EncounterItems",
                keyColumn: "Id",
                keyValue: new Guid("0ecb2f3b-4624-4d9d-8497-28f24a6fdf33"));

            migrationBuilder.DeleteData(
                table: "EncounterItems",
                keyColumn: "Id",
                keyValue: new Guid("1d11fba5-e645-4427-a620-8778972794be"));

            migrationBuilder.DeleteData(
                table: "EncounterItems",
                keyColumn: "Id",
                keyValue: new Guid("4f7238c8-2b0e-4b6e-abee-f8d5aa6ee777"));

            migrationBuilder.DeleteData(
                table: "EncounterItems",
                keyColumn: "Id",
                keyValue: new Guid("93bae85a-37c4-406e-b6e9-6970e1166e41"));

            migrationBuilder.DeleteData(
                table: "Creatures",
                keyColumn: "Id",
                keyValue: new Guid("15abf7c3-2780-4cec-b672-1af0bc17b486"));

            migrationBuilder.DeleteData(
                table: "Creatures",
                keyColumn: "Id",
                keyValue: new Guid("72b54097-0782-465a-a0d4-d338d721420d"));

            migrationBuilder.DeleteData(
                table: "Creatures",
                keyColumn: "Id",
                keyValue: new Guid("bb9eabbf-5d14-4646-8f51-c4019da03600"));

            migrationBuilder.DeleteData(
                table: "Creatures",
                keyColumn: "Id",
                keyValue: new Guid("e0f124e0-7ef5-4b11-a09a-15c2b8f0605f"));

            migrationBuilder.DeleteData(
                table: "Encounters",
                keyColumn: "Id",
                keyValue: new Guid("748ed191-0a60-478c-82fa-8c96137c1db7"));

            migrationBuilder.DropColumn(
                name: "Action1",
                table: "EncounterItems");

            migrationBuilder.DropColumn(
                name: "Action2",
                table: "EncounterItems");

            migrationBuilder.DropColumn(
                name: "Action3",
                table: "EncounterItems");

            migrationBuilder.RenameColumn(
                name: "Action4",
                table: "EncounterItems",
                newName: "ActionsUsed");

            migrationBuilder.InsertData(
                table: "Creatures",
                columns: new[] { "Id", "AcrobaticsMastery", "ActionPoints", "Agility", "AgilitySave", "AnimalMastery", "ArcanaMastery", "AthleticsMastery", "AwarenessMastery", "Charisma", "CharismaSave", "CustomKnowledge1Mastery", "CustomKnowledge1Name", "CustomKnowledge2Mastery", "CustomKnowledge2Name", "Discriminator", "HistoryMastery", "InfluenceMastery", "InsightMastery", "Intelligence", "IntelligenceSave", "IntimidationMastery", "InvestigationMastery", "Level", "MD", "MDR", "MaxHP", "MaxMana", "MaxStamina", "MedicineMastery", "Might", "MightSave", "Name", "NatureMastery", "OccultismMastery", "PD", "PDR", "PlayerName", "ReligionMastery", "StealthMastery", "SurvivalMastery", "TrickeryMastery" },
                values: new object[,]
                {
                    { new Guid("43195580-bf73-4747-a12a-9387b1e07873"), 0, 4, 0, false, 0, 0, 0, 0, 0, false, 0, "", 0, "", "Character", 0, 0, 0, 0, false, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, false, "Ishraq", 0, 0, 0, 0, "James", 0, 0, 0, 0 },
                    { new Guid("7d1a9aac-7028-4760-a3ac-95b0a30997ce"), 0, 4, 0, false, 0, 0, 0, 0, 0, false, 0, "", 0, "", "Character", 0, 0, 0, 0, false, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, false, "Marf", 0, 0, 0, 0, "Spence", 0, 0, 0, 0 },
                    { new Guid("978d2cfa-e833-468c-9354-de0496412f10"), 0, 4, 0, false, 0, 0, 0, 0, 0, false, 0, "", 0, "", "Character", 0, 0, 0, 0, false, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, false, "Kerf", 0, 0, 0, 0, "Alex", 0, 0, 0, 0 },
                    { new Guid("aff088c8-8ac3-4c72-9497-c44a0faa621e"), 0, 4, 0, false, 0, 0, 0, 0, 0, false, 0, "", 0, "", "Character", 0, 0, 0, 0, false, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, false, "The Bear Dru", 0, 0, 0, 0, "Nate", 0, 0, 0, 0 }
                });

            migrationBuilder.InsertData(
                table: "Encounters",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("38ea5e75-0dac-4f30-9ad1-ffe2dc050c1f"), "First Encounter" });

            migrationBuilder.InsertData(
                table: "EncounterItems",
                columns: new[] { "Id", "ActionsUsed", "Conditions", "ConditionsOpen", "CreatureId", "CurrentHP", "CurrentMana", "CurrentStamina", "EncounterId", "Hidden", "Initiative" },
                values: new object[,]
                {
                    { new Guid("105d438d-0b25-452f-8d9d-de0b5fa39f0d"), 0, "[]", false, new Guid("aff088c8-8ac3-4c72-9497-c44a0faa621e"), 0, 0, 0, new Guid("38ea5e75-0dac-4f30-9ad1-ffe2dc050c1f"), false, 0 },
                    { new Guid("4dbf0076-55c0-4c9b-9ea7-259803521a2f"), 0, "[]", false, new Guid("43195580-bf73-4747-a12a-9387b1e07873"), 0, 0, 0, new Guid("38ea5e75-0dac-4f30-9ad1-ffe2dc050c1f"), false, 0 },
                    { new Guid("aa2ec423-5fd4-4cf7-96c8-67629514308c"), 0, "[]", false, new Guid("978d2cfa-e833-468c-9354-de0496412f10"), 0, 0, 0, new Guid("38ea5e75-0dac-4f30-9ad1-ffe2dc050c1f"), false, 0 },
                    { new Guid("cdbd1ff9-cbb5-47a2-9ad3-54689987e0c9"), 0, "[]", false, new Guid("7d1a9aac-7028-4760-a3ac-95b0a30997ce"), 0, 0, 0, new Guid("38ea5e75-0dac-4f30-9ad1-ffe2dc050c1f"), false, 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EncounterItems",
                keyColumn: "Id",
                keyValue: new Guid("105d438d-0b25-452f-8d9d-de0b5fa39f0d"));

            migrationBuilder.DeleteData(
                table: "EncounterItems",
                keyColumn: "Id",
                keyValue: new Guid("4dbf0076-55c0-4c9b-9ea7-259803521a2f"));

            migrationBuilder.DeleteData(
                table: "EncounterItems",
                keyColumn: "Id",
                keyValue: new Guid("aa2ec423-5fd4-4cf7-96c8-67629514308c"));

            migrationBuilder.DeleteData(
                table: "EncounterItems",
                keyColumn: "Id",
                keyValue: new Guid("cdbd1ff9-cbb5-47a2-9ad3-54689987e0c9"));

            migrationBuilder.DeleteData(
                table: "Creatures",
                keyColumn: "Id",
                keyValue: new Guid("43195580-bf73-4747-a12a-9387b1e07873"));

            migrationBuilder.DeleteData(
                table: "Creatures",
                keyColumn: "Id",
                keyValue: new Guid("7d1a9aac-7028-4760-a3ac-95b0a30997ce"));

            migrationBuilder.DeleteData(
                table: "Creatures",
                keyColumn: "Id",
                keyValue: new Guid("978d2cfa-e833-468c-9354-de0496412f10"));

            migrationBuilder.DeleteData(
                table: "Creatures",
                keyColumn: "Id",
                keyValue: new Guid("aff088c8-8ac3-4c72-9497-c44a0faa621e"));

            migrationBuilder.DeleteData(
                table: "Encounters",
                keyColumn: "Id",
                keyValue: new Guid("38ea5e75-0dac-4f30-9ad1-ffe2dc050c1f"));

            migrationBuilder.RenameColumn(
                name: "ActionsUsed",
                table: "EncounterItems",
                newName: "Action4");

            migrationBuilder.AddColumn<bool>(
                name: "Action1",
                table: "EncounterItems",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Action2",
                table: "EncounterItems",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Action3",
                table: "EncounterItems",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "Creatures",
                columns: new[] { "Id", "AcrobaticsMastery", "ActionPoints", "Agility", "AgilitySave", "AnimalMastery", "ArcanaMastery", "AthleticsMastery", "AwarenessMastery", "Charisma", "CharismaSave", "CustomKnowledge1Mastery", "CustomKnowledge1Name", "CustomKnowledge2Mastery", "CustomKnowledge2Name", "Discriminator", "HistoryMastery", "InfluenceMastery", "InsightMastery", "Intelligence", "IntelligenceSave", "IntimidationMastery", "InvestigationMastery", "Level", "MD", "MDR", "MaxHP", "MaxMana", "MaxStamina", "MedicineMastery", "Might", "MightSave", "Name", "NatureMastery", "OccultismMastery", "PD", "PDR", "PlayerName", "ReligionMastery", "StealthMastery", "SurvivalMastery", "TrickeryMastery" },
                values: new object[,]
                {
                    { new Guid("15abf7c3-2780-4cec-b672-1af0bc17b486"), 0, 4, 0, false, 0, 0, 0, 0, 0, false, 0, "", 0, "", "Character", 0, 0, 0, 0, false, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, false, "The Bear Dru", 0, 0, 0, 0, "Nate", 0, 0, 0, 0 },
                    { new Guid("72b54097-0782-465a-a0d4-d338d721420d"), 0, 4, 0, false, 0, 0, 0, 0, 0, false, 0, "", 0, "", "Character", 0, 0, 0, 0, false, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, false, "Marf", 0, 0, 0, 0, "Spence", 0, 0, 0, 0 },
                    { new Guid("bb9eabbf-5d14-4646-8f51-c4019da03600"), 0, 4, 0, false, 0, 0, 0, 0, 0, false, 0, "", 0, "", "Character", 0, 0, 0, 0, false, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, false, "Kerf", 0, 0, 0, 0, "Alex", 0, 0, 0, 0 },
                    { new Guid("e0f124e0-7ef5-4b11-a09a-15c2b8f0605f"), 0, 4, 0, false, 0, 0, 0, 0, 0, false, 0, "", 0, "", "Character", 0, 0, 0, 0, false, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, false, "Ishraq", 0, 0, 0, 0, "James", 0, 0, 0, 0 }
                });

            migrationBuilder.InsertData(
                table: "Encounters",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("748ed191-0a60-478c-82fa-8c96137c1db7"), "First Encounter" });

            migrationBuilder.InsertData(
                table: "EncounterItems",
                columns: new[] { "Id", "Action1", "Action2", "Action3", "Action4", "Conditions", "ConditionsOpen", "CreatureId", "CurrentHP", "CurrentMana", "CurrentStamina", "EncounterId", "Hidden", "Initiative" },
                values: new object[,]
                {
                    { new Guid("0ecb2f3b-4624-4d9d-8497-28f24a6fdf33"), false, false, false, false, "[]", false, new Guid("72b54097-0782-465a-a0d4-d338d721420d"), 0, 0, 0, new Guid("748ed191-0a60-478c-82fa-8c96137c1db7"), false, 0 },
                    { new Guid("1d11fba5-e645-4427-a620-8778972794be"), false, false, false, false, "[]", false, new Guid("bb9eabbf-5d14-4646-8f51-c4019da03600"), 0, 0, 0, new Guid("748ed191-0a60-478c-82fa-8c96137c1db7"), false, 0 },
                    { new Guid("4f7238c8-2b0e-4b6e-abee-f8d5aa6ee777"), false, false, false, false, "[]", false, new Guid("15abf7c3-2780-4cec-b672-1af0bc17b486"), 0, 0, 0, new Guid("748ed191-0a60-478c-82fa-8c96137c1db7"), false, 0 },
                    { new Guid("93bae85a-37c4-406e-b6e9-6970e1166e41"), false, false, false, false, "[]", false, new Guid("e0f124e0-7ef5-4b11-a09a-15c2b8f0605f"), 0, 0, 0, new Guid("748ed191-0a60-478c-82fa-8c96137c1db7"), false, 0 }
                });
        }
    }
}
