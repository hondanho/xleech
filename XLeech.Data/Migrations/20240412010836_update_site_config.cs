using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace XLeech.Data.Migrations
{
    public partial class update_site_config : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "ActiveForPostSpinning",
                table: "Sites",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ActiveForPostTranslation",
                table: "Sites",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ActiveForPostSpinning",
                table: "Sites");

            migrationBuilder.DropColumn(
                name: "ActiveForPostTranslation",
                table: "Sites");
        }
    }
}
