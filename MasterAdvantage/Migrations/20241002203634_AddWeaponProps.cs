using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MasterAdvantage.Migrations
{
    /// <inheritdoc />
    public partial class AddWeaponProps : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WeaponWeaponProperty_WeaponProperty_WeaponPropertiesId",
                table: "WeaponWeaponProperty");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WeaponProperty",
                table: "WeaponProperty");

            migrationBuilder.RenameTable(
                name: "WeaponProperty",
                newName: "WeaponProperties");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WeaponProperties",
                table: "WeaponProperties",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_WeaponWeaponProperty_WeaponProperties_WeaponPropertiesId",
                table: "WeaponWeaponProperty",
                column: "WeaponPropertiesId",
                principalTable: "WeaponProperties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WeaponWeaponProperty_WeaponProperties_WeaponPropertiesId",
                table: "WeaponWeaponProperty");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WeaponProperties",
                table: "WeaponProperties");

            migrationBuilder.RenameTable(
                name: "WeaponProperties",
                newName: "WeaponProperty");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WeaponProperty",
                table: "WeaponProperty",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_WeaponWeaponProperty_WeaponProperty_WeaponPropertiesId",
                table: "WeaponWeaponProperty",
                column: "WeaponPropertiesId",
                principalTable: "WeaponProperty",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
