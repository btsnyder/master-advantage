using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MasterAdvantage.Migrations
{
    /// <inheritdoc />
    public partial class AddMovement : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CreatureWeapon_Weapon_WeaponsId",
                table: "CreatureWeapon");

            migrationBuilder.DropForeignKey(
                name: "FK_Weapon_WeaponStyle_WeaponStyleId",
                table: "Weapon");

            migrationBuilder.DropForeignKey(
                name: "FK_WeaponWeaponProperty_Weapon_WeaponsId",
                table: "WeaponWeaponProperty");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Weapon",
                table: "Weapon");

            migrationBuilder.RenameTable(
                name: "Weapon",
                newName: "Weapons");

            migrationBuilder.RenameIndex(
                name: "IX_Weapon_WeaponStyleId",
                table: "Weapons",
                newName: "IX_Weapons_WeaponStyleId");

            migrationBuilder.AddColumn<int>(
                name: "Jump",
                table: "Creatures",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Speed",
                table: "Creatures",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Weapons",
                table: "Weapons",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CreatureWeapon_Weapons_WeaponsId",
                table: "CreatureWeapon",
                column: "WeaponsId",
                principalTable: "Weapons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Weapons_WeaponStyle_WeaponStyleId",
                table: "Weapons",
                column: "WeaponStyleId",
                principalTable: "WeaponStyle",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WeaponWeaponProperty_Weapons_WeaponsId",
                table: "WeaponWeaponProperty",
                column: "WeaponsId",
                principalTable: "Weapons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CreatureWeapon_Weapons_WeaponsId",
                table: "CreatureWeapon");

            migrationBuilder.DropForeignKey(
                name: "FK_Weapons_WeaponStyle_WeaponStyleId",
                table: "Weapons");

            migrationBuilder.DropForeignKey(
                name: "FK_WeaponWeaponProperty_Weapons_WeaponsId",
                table: "WeaponWeaponProperty");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Weapons",
                table: "Weapons");

            migrationBuilder.DropColumn(
                name: "Jump",
                table: "Creatures");

            migrationBuilder.DropColumn(
                name: "Speed",
                table: "Creatures");

            migrationBuilder.RenameTable(
                name: "Weapons",
                newName: "Weapon");

            migrationBuilder.RenameIndex(
                name: "IX_Weapons_WeaponStyleId",
                table: "Weapon",
                newName: "IX_Weapon_WeaponStyleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Weapon",
                table: "Weapon",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CreatureWeapon_Weapon_WeaponsId",
                table: "CreatureWeapon",
                column: "WeaponsId",
                principalTable: "Weapon",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Weapon_WeaponStyle_WeaponStyleId",
                table: "Weapon",
                column: "WeaponStyleId",
                principalTable: "WeaponStyle",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WeaponWeaponProperty_Weapon_WeaponsId",
                table: "WeaponWeaponProperty",
                column: "WeaponsId",
                principalTable: "Weapon",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
