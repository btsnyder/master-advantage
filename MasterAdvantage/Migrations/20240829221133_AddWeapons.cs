using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MasterAdvantage.Migrations
{
    /// <inheritdoc />
    public partial class AddWeapons : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WeaponProperty",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Effects = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeaponProperty", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WeaponStyle",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeaponStyle", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Weapon",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    WeaponStyleId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Damage = table.Column<int>(type: "INTEGER", nullable: false),
                    DamageType = table.Column<int>(type: "INTEGER", nullable: false),
                    Melee = table.Column<bool>(type: "INTEGER", nullable: false),
                    Type = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weapon", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Weapon_WeaponStyle_WeaponStyleId",
                        column: x => x.WeaponStyleId,
                        principalTable: "WeaponStyle",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CreatureWeapon",
                columns: table => new
                {
                    CreaturesId = table.Column<Guid>(type: "TEXT", nullable: false),
                    WeaponsId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreatureWeapon", x => new { x.CreaturesId, x.WeaponsId });
                    table.ForeignKey(
                        name: "FK_CreatureWeapon_Creatures_CreaturesId",
                        column: x => x.CreaturesId,
                        principalTable: "Creatures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CreatureWeapon_Weapon_WeaponsId",
                        column: x => x.WeaponsId,
                        principalTable: "Weapon",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WeaponWeaponProperty",
                columns: table => new
                {
                    WeaponPropertiesId = table.Column<Guid>(type: "TEXT", nullable: false),
                    WeaponsId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeaponWeaponProperty", x => new { x.WeaponPropertiesId, x.WeaponsId });
                    table.ForeignKey(
                        name: "FK_WeaponWeaponProperty_WeaponProperty_WeaponPropertiesId",
                        column: x => x.WeaponPropertiesId,
                        principalTable: "WeaponProperty",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WeaponWeaponProperty_Weapon_WeaponsId",
                        column: x => x.WeaponsId,
                        principalTable: "Weapon",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CreatureWeapon_WeaponsId",
                table: "CreatureWeapon",
                column: "WeaponsId");

            migrationBuilder.CreateIndex(
                name: "IX_Weapon_WeaponStyleId",
                table: "Weapon",
                column: "WeaponStyleId");

            migrationBuilder.CreateIndex(
                name: "IX_WeaponWeaponProperty_WeaponsId",
                table: "WeaponWeaponProperty",
                column: "WeaponsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CreatureWeapon");

            migrationBuilder.DropTable(
                name: "WeaponWeaponProperty");

            migrationBuilder.DropTable(
                name: "WeaponProperty");

            migrationBuilder.DropTable(
                name: "Weapon");

            migrationBuilder.DropTable(
                name: "WeaponStyle");
        }
    }
}
