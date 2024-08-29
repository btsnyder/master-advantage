using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MasterAdvantage.Migrations
{
    /// <inheritdoc />
    public partial class AddConditions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EncounterItems",
                keyColumn: "Id",
                keyValue: new Guid("b6582be8-3c6b-46d5-a419-7c3acb4b3f57"));

            migrationBuilder.DeleteData(
                table: "EncounterItems",
                keyColumn: "Id",
                keyValue: new Guid("c4bea63c-aea7-4b4b-9d9c-db6c0a5a05f5"));

            migrationBuilder.DeleteData(
                table: "EncounterItems",
                keyColumn: "Id",
                keyValue: new Guid("cd11db8f-21d1-4e12-8a04-207c59140b84"));

            migrationBuilder.DeleteData(
                table: "EncounterItems",
                keyColumn: "Id",
                keyValue: new Guid("f5ac6493-a4ac-4744-8339-a88645e8fae9"));

            migrationBuilder.DeleteData(
                table: "Creatures",
                keyColumn: "Id",
                keyValue: new Guid("387e06bd-b983-43dd-8ba8-c824d504f8cd"));

            migrationBuilder.DeleteData(
                table: "Creatures",
                keyColumn: "Id",
                keyValue: new Guid("3f1a814b-746d-45f8-b798-5239b190af9c"));

            migrationBuilder.DeleteData(
                table: "Creatures",
                keyColumn: "Id",
                keyValue: new Guid("67f44a51-daed-4acf-87f9-d479d9df0d43"));

            migrationBuilder.DeleteData(
                table: "Creatures",
                keyColumn: "Id",
                keyValue: new Guid("d6f81d5c-b3ea-4ea9-a090-a4c7e6e36280"));

            migrationBuilder.DeleteData(
                table: "Encounters",
                keyColumn: "Id",
                keyValue: new Guid("753d6911-d8ae-41cb-8f5b-bcd2227b66c5"));

            migrationBuilder.AddColumn<string>(
                name: "Conditions",
                table: "Creatures",
                type: "TEXT",
                nullable: false,
                defaultValue: "[]");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Creatures",
                columns: new[] { "Id", "AcrobaticsMastery", "ActionPoints", "Agility", "AgilitySave", "AnimalMastery", "ArcanaMastery", "AthleticsMastery", "AwarenessMastery", "Charisma", "CharismaSave", "CustomKnowledge1Mastery", "CustomKnowledge1Name", "CustomKnowledge2Mastery", "CustomKnowledge2Name", "Discriminator", "HistoryMastery", "InfluenceMastery", "InsightMastery", "Intelligence", "IntelligenceSave", "IntimidationMastery", "InvestigationMastery", "Level", "MD", "MDR", "MaxHP", "MaxMana", "MaxStamina", "MedicineMastery", "Might", "MightSave", "Name", "NatureMastery", "OccultismMastery", "PD", "PDR", "PlayerName", "ReligionMastery", "StealthMastery", "SurvivalMastery", "TrickeryMastery" },
                values: new object[,]
                {
                    { new Guid("387e06bd-b983-43dd-8ba8-c824d504f8cd"), 0, 4, 0, false, 0, 0, 0, 0, 0, false, 0, "", 0, "", "Character", 0, 0, 0, 0, false, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, false, "Marf", 0, 0, 0, 0, "Spence", 0, 0, 0, 0 },
                    { new Guid("3f1a814b-746d-45f8-b798-5239b190af9c"), 0, 4, 0, false, 0, 0, 0, 0, 0, false, 0, "", 0, "", "Character", 0, 0, 0, 0, false, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, false, "Ishraq", 0, 0, 0, 0, "James", 0, 0, 0, 0 },
                    { new Guid("67f44a51-daed-4acf-87f9-d479d9df0d43"), 0, 4, 0, false, 0, 0, 0, 0, 0, false, 0, "", 0, "", "Character", 0, 0, 0, 0, false, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, false, "The Bear Dru", 0, 0, 0, 0, "Nate", 0, 0, 0, 0 },
                    { new Guid("d6f81d5c-b3ea-4ea9-a090-a4c7e6e36280"), 0, 4, 0, false, 0, 0, 0, 0, 0, false, 0, "", 0, "", "Character", 0, 0, 0, 0, false, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, false, "Kerf", 0, 0, 0, 0, "Alex", 0, 0, 0, 0 }
                });

            migrationBuilder.InsertData(
                table: "Encounters",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("753d6911-d8ae-41cb-8f5b-bcd2227b66c5"), "First Encounter" });

            migrationBuilder.InsertData(
                table: "EncounterItems",
                columns: new[] { "Id", "Action1", "Action2", "Action3", "Action4", "ConditionsOpen", "CreatureId", "CurrentHP", "CurrentMana", "CurrentStamina", "EncounterId", "Hidden", "Initiative" },
                values: new object[,]
                {
                    { new Guid("b6582be8-3c6b-46d5-a419-7c3acb4b3f57"), false, false, false, false, false, new Guid("67f44a51-daed-4acf-87f9-d479d9df0d43"), 0, 0, 0, new Guid("753d6911-d8ae-41cb-8f5b-bcd2227b66c5"), false, 0 },
                    { new Guid("c4bea63c-aea7-4b4b-9d9c-db6c0a5a05f5"), false, false, false, false, false, new Guid("3f1a814b-746d-45f8-b798-5239b190af9c"), 0, 0, 0, new Guid("753d6911-d8ae-41cb-8f5b-bcd2227b66c5"), false, 0 },
                    { new Guid("cd11db8f-21d1-4e12-8a04-207c59140b84"), false, false, false, false, false, new Guid("d6f81d5c-b3ea-4ea9-a090-a4c7e6e36280"), 0, 0, 0, new Guid("753d6911-d8ae-41cb-8f5b-bcd2227b66c5"), false, 0 },
                    { new Guid("f5ac6493-a4ac-4744-8339-a88645e8fae9"), false, false, false, false, false, new Guid("387e06bd-b983-43dd-8ba8-c824d504f8cd"), 0, 0, 0, new Guid("753d6911-d8ae-41cb-8f5b-bcd2227b66c5"), false, 0 }
                });
        }
    }
}
