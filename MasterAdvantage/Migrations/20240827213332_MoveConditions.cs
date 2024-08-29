using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MasterAdvantage.Migrations
{
    /// <inheritdoc />
    public partial class MoveConditions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EncounterItems",
                keyColumn: "Id",
                keyValue: new Guid("01215a42-20d6-4640-a889-2838c5a15926"));

            migrationBuilder.DeleteData(
                table: "EncounterItems",
                keyColumn: "Id",
                keyValue: new Guid("1585efc7-0693-484a-b966-9893ba142c91"));

            migrationBuilder.DeleteData(
                table: "EncounterItems",
                keyColumn: "Id",
                keyValue: new Guid("c2d60cc0-cb78-4d02-a79a-947d010bce3e"));

            migrationBuilder.DeleteData(
                table: "EncounterItems",
                keyColumn: "Id",
                keyValue: new Guid("ccba4ba0-fe89-4fed-be68-eb9919b72b16"));

            migrationBuilder.DeleteData(
                table: "Creatures",
                keyColumn: "Id",
                keyValue: new Guid("09fb353d-e506-44ee-a7e4-4cd3a09a13bc"));

            migrationBuilder.DeleteData(
                table: "Creatures",
                keyColumn: "Id",
                keyValue: new Guid("0b655dc7-1f5f-4afe-b384-d8b4298b704e"));

            migrationBuilder.DeleteData(
                table: "Creatures",
                keyColumn: "Id",
                keyValue: new Guid("66432fcd-8910-4364-9579-6e9b26417270"));

            migrationBuilder.DeleteData(
                table: "Creatures",
                keyColumn: "Id",
                keyValue: new Guid("8333de00-7bf7-4394-850d-d42c794bdd2d"));

            migrationBuilder.DeleteData(
                table: "Encounters",
                keyColumn: "Id",
                keyValue: new Guid("c6c67300-d0a4-443a-9de6-865846fbd4ef"));

            migrationBuilder.DropColumn(
                name: "Conditions",
                table: "Creatures");

            migrationBuilder.AddColumn<string>(
                name: "Conditions",
                table: "EncounterItems",
                type: "TEXT",
                nullable: false,
                defaultValue: "[]");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "Conditions",
                table: "EncounterItems");

            migrationBuilder.AddColumn<string>(
                name: "Conditions",
                table: "Creatures",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Creatures",
                columns: new[] { "Id", "AcrobaticsMastery", "ActionPoints", "Agility", "AgilitySave", "AnimalMastery", "ArcanaMastery", "AthleticsMastery", "AwarenessMastery", "Charisma", "CharismaSave", "Conditions", "CustomKnowledge1Mastery", "CustomKnowledge1Name", "CustomKnowledge2Mastery", "CustomKnowledge2Name", "Discriminator", "HistoryMastery", "InfluenceMastery", "InsightMastery", "Intelligence", "IntelligenceSave", "IntimidationMastery", "InvestigationMastery", "Level", "MD", "MDR", "MaxHP", "MaxMana", "MaxStamina", "MedicineMastery", "Might", "MightSave", "Name", "NatureMastery", "OccultismMastery", "PD", "PDR", "PlayerName", "ReligionMastery", "StealthMastery", "SurvivalMastery", "TrickeryMastery" },
                values: new object[,]
                {
                    { new Guid("09fb353d-e506-44ee-a7e4-4cd3a09a13bc"), 0, 4, 0, false, 0, 0, 0, 0, 0, false, "[]", 0, "", 0, "", "Character", 0, 0, 0, 0, false, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, false, "Kerf", 0, 0, 0, 0, "Alex", 0, 0, 0, 0 },
                    { new Guid("0b655dc7-1f5f-4afe-b384-d8b4298b704e"), 0, 4, 0, false, 0, 0, 0, 0, 0, false, "[]", 0, "", 0, "", "Character", 0, 0, 0, 0, false, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, false, "Ishraq", 0, 0, 0, 0, "James", 0, 0, 0, 0 },
                    { new Guid("66432fcd-8910-4364-9579-6e9b26417270"), 0, 4, 0, false, 0, 0, 0, 0, 0, false, "[]", 0, "", 0, "", "Character", 0, 0, 0, 0, false, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, false, "The Bear Dru", 0, 0, 0, 0, "Nate", 0, 0, 0, 0 },
                    { new Guid("8333de00-7bf7-4394-850d-d42c794bdd2d"), 0, 4, 0, false, 0, 0, 0, 0, 0, false, "[]", 0, "", 0, "", "Character", 0, 0, 0, 0, false, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, false, "Marf", 0, 0, 0, 0, "Spence", 0, 0, 0, 0 }
                });

            migrationBuilder.InsertData(
                table: "Encounters",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("c6c67300-d0a4-443a-9de6-865846fbd4ef"), "First Encounter" });

            migrationBuilder.InsertData(
                table: "EncounterItems",
                columns: new[] { "Id", "Action1", "Action2", "Action3", "Action4", "ConditionsOpen", "CreatureId", "CurrentHP", "CurrentMana", "CurrentStamina", "EncounterId", "Hidden", "Initiative" },
                values: new object[,]
                {
                    { new Guid("01215a42-20d6-4640-a889-2838c5a15926"), false, false, false, false, false, new Guid("8333de00-7bf7-4394-850d-d42c794bdd2d"), 0, 0, 0, new Guid("c6c67300-d0a4-443a-9de6-865846fbd4ef"), false, 0 },
                    { new Guid("1585efc7-0693-484a-b966-9893ba142c91"), false, false, false, false, false, new Guid("0b655dc7-1f5f-4afe-b384-d8b4298b704e"), 0, 0, 0, new Guid("c6c67300-d0a4-443a-9de6-865846fbd4ef"), false, 0 },
                    { new Guid("c2d60cc0-cb78-4d02-a79a-947d010bce3e"), false, false, false, false, false, new Guid("66432fcd-8910-4364-9579-6e9b26417270"), 0, 0, 0, new Guid("c6c67300-d0a4-443a-9de6-865846fbd4ef"), false, 0 },
                    { new Guid("ccba4ba0-fe89-4fed-be68-eb9919b72b16"), false, false, false, false, false, new Guid("09fb353d-e506-44ee-a7e4-4cd3a09a13bc"), 0, 0, 0, new Guid("c6c67300-d0a4-443a-9de6-865846fbd4ef"), false, 0 }
                });
        }
    }
}
