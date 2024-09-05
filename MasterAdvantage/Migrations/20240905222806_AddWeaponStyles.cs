using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MasterAdvantage.Migrations
{
    /// <inheritdoc />
    public partial class AddWeaponStyles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Weapons_WeaponStyle_WeaponStyleId",
                table: "Weapons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WeaponStyle",
                table: "WeaponStyle");

            migrationBuilder.RenameTable(
                name: "WeaponStyle",
                newName: "WeaponStyles");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WeaponStyles",
                table: "WeaponStyles",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Weapons_WeaponStyles_WeaponStyleId",
                table: "Weapons",
                column: "WeaponStyleId",
                principalTable: "WeaponStyles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Weapons_WeaponStyles_WeaponStyleId",
                table: "Weapons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WeaponStyles",
                table: "WeaponStyles");

            migrationBuilder.RenameTable(
                name: "WeaponStyles",
                newName: "WeaponStyle");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WeaponStyle",
                table: "WeaponStyle",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Weapons_WeaponStyle_WeaponStyleId",
                table: "Weapons",
                column: "WeaponStyleId",
                principalTable: "WeaponStyle",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
