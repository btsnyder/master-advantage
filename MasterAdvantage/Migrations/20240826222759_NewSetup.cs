using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MasterAdvantage.Migrations
{
    /// <inheritdoc />
    public partial class NewSetup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
