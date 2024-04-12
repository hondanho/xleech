using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace XLeech.Data.Migrations
{
    public partial class update_site_config_v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsTryTest",
                table: "Sites",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsTryTest",
                table: "Sites");
        }
    }
}
