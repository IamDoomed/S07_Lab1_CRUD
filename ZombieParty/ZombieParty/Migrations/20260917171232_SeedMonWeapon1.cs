using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZombieParty.Migrations
{
    /// <inheritdoc />
    public partial class SeedMonWeapon1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Weapons",
                keyColumn: "WeaponId",
                keyValue: 3,
                column: "Image",
                value: "https://limbuscompany.wiki.gg/wiki/Ry%C5%8Dsh%C5%AB#/media/File:Ryoshufull.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Weapons",
                keyColumn: "WeaponId",
                keyValue: 3,
                column: "Image",
                value: "https://publicdomainvectors.org/photos/Shield-ClassicMedieval1.png");
        }
    }
}
