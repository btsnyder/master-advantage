using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MasterAdvantage.Migrations
{
    /// <inheritdoc />
    public partial class AddConditionsOpen : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EncounterItems",
                keyColumn: "Id",
                keyValue: new Guid("4750139b-7bb0-4c7b-8e52-b95ee1c9a126"));

            migrationBuilder.DeleteData(
                table: "EncounterItems",
                keyColumn: "Id",
                keyValue: new Guid("5795d4dd-9394-449d-ae09-c98794fe6d92"));

            migrationBuilder.DeleteData(
                table: "EncounterItems",
                keyColumn: "Id",
                keyValue: new Guid("b0d0f262-19cb-48ef-8629-65b5db2c0215"));

            migrationBuilder.DeleteData(
                table: "EncounterItems",
                keyColumn: "Id",
                keyValue: new Guid("f17466cf-71d5-4ae6-831d-e7787ef52590"));

            migrationBuilder.DeleteData(
                table: "Creatures",
                keyColumn: "Id",
                keyValue: new Guid("5661a980-7795-434f-aa55-7667218fa57c"));

            migrationBuilder.DeleteData(
                table: "Creatures",
                keyColumn: "Id",
                keyValue: new Guid("66c9607d-a3cf-4be9-bacc-fc2834c15caf"));

            migrationBuilder.DeleteData(
                table: "Creatures",
                keyColumn: "Id",
                keyValue: new Guid("90984c5e-148c-4601-84de-7d7bb8eda860"));

            migrationBuilder.DeleteData(
                table: "Creatures",
                keyColumn: "Id",
                keyValue: new Guid("93d0e116-837e-490d-a1f7-bf415ac0dd73"));

            migrationBuilder.DeleteData(
                table: "Encounters",
                keyColumn: "Id",
                keyValue: new Guid("b31179df-3985-45fd-9c33-33acfef01ef6"));

            migrationBuilder.AddColumn<bool>(
                name: "ConditionsOpen",
                table: "EncounterItems",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "ConditionsOpen",
                table: "EncounterItems");

            migrationBuilder.InsertData(
                table: "Creatures",
                columns: new[] { "Id", "AcrobaticsMastery", "ActionPoints", "Agility", "AgilitySave", "AnimalMastery", "ArcanaMastery", "AthleticsMastery", "AwarenessMastery", "Charisma", "CharismaSave", "CustomKnowledge1Mastery", "CustomKnowledge1Name", "CustomKnowledge2Mastery", "CustomKnowledge2Name", "Discriminator", "HistoryMastery", "InfluenceMastery", "InsightMastery", "Intelligence", "IntelligenceSave", "IntimidationMastery", "InvestigationMastery", "Level", "MD", "MDR", "MaxHP", "MaxMana", "MaxStamina", "MedicineMastery", "Might", "MightSave", "Name", "NatureMastery", "OccultismMastery", "PD", "PDR", "PlayerName", "ReligionMastery", "StealthMastery", "SurvivalMastery", "TrickeryMastery" },
                values: new object[,]
                {
                    { new Guid("5661a980-7795-434f-aa55-7667218fa57c"), 0, 4, 0, false, 0, 0, 0, 0, 0, false, 0, "", 0, "", "Character", 0, 0, 0, 0, false, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, false, "Marf", 0, 0, 0, 0, "Spence", 0, 0, 0, 0 },
                    { new Guid("66c9607d-a3cf-4be9-bacc-fc2834c15caf"), 0, 4, 0, false, 0, 0, 0, 0, 0, false, 0, "", 0, "", "Character", 0, 0, 0, 0, false, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, false, "Ishraq", 0, 0, 0, 0, "James", 0, 0, 0, 0 },
                    { new Guid("90984c5e-148c-4601-84de-7d7bb8eda860"), 0, 4, 0, false, 0, 0, 0, 0, 0, false, 0, "", 0, "", "Character", 0, 0, 0, 0, false, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, false, "The Bear Dru", 0, 0, 0, 0, "Nate", 0, 0, 0, 0 },
                    { new Guid("93d0e116-837e-490d-a1f7-bf415ac0dd73"), 0, 4, 0, false, 0, 0, 0, 0, 0, false, 0, "", 0, "", "Character", 0, 0, 0, 0, false, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, false, "Kerf", 0, 0, 0, 0, "Alex", 0, 0, 0, 0 }
                });

            migrationBuilder.InsertData(
                table: "Encounters",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("b31179df-3985-45fd-9c33-33acfef01ef6"), "First Encounter" });

            migrationBuilder.InsertData(
                table: "EncounterItems",
                columns: new[] { "Id", "Action1", "Action2", "Action3", "Action4", "CreatureId", "CurrentHP", "CurrentMana", "CurrentStamina", "EncounterId", "Hidden", "Initiative" },
                values: new object[,]
                {
                    { new Guid("4750139b-7bb0-4c7b-8e52-b95ee1c9a126"), false, false, false, false, new Guid("90984c5e-148c-4601-84de-7d7bb8eda860"), 0, 0, 0, new Guid("b31179df-3985-45fd-9c33-33acfef01ef6"), false, 0 },
                    { new Guid("5795d4dd-9394-449d-ae09-c98794fe6d92"), false, false, false, false, new Guid("93d0e116-837e-490d-a1f7-bf415ac0dd73"), 0, 0, 0, new Guid("b31179df-3985-45fd-9c33-33acfef01ef6"), false, 0 },
                    { new Guid("b0d0f262-19cb-48ef-8629-65b5db2c0215"), false, false, false, false, new Guid("66c9607d-a3cf-4be9-bacc-fc2834c15caf"), 0, 0, 0, new Guid("b31179df-3985-45fd-9c33-33acfef01ef6"), false, 0 },
                    { new Guid("f17466cf-71d5-4ae6-831d-e7787ef52590"), false, false, false, false, new Guid("5661a980-7795-434f-aa55-7667218fa57c"), 0, 0, 0, new Guid("b31179df-3985-45fd-9c33-33acfef01ef6"), false, 0 }
                });
        }
    }
}
