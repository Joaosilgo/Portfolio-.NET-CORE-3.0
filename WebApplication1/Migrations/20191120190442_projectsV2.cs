using Microsoft.EntityFrameworkCore.Migrations;

namespace infoSys.Migrations
{
    public partial class projectsV2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Difficulties",
                table: "Project",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Features",
                table: "Project",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Intent",
                table: "Project",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Solution",
                table: "Project",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Difficulties",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "Features",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "Intent",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "Solution",
                table: "Project");
        }
    }
}
