using Microsoft.EntityFrameworkCore.Migrations;

namespace infoSys.Migrations
{
    public partial class transform : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProjectThumbnails_Project_ProjectId",
                table: "ProjectThumbnails");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "ProjectThumbnails");

            migrationBuilder.AlterColumn<int>(
                name: "ProjectId",
                table: "ProjectThumbnails",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectThumbnails_Project_ProjectId",
                table: "ProjectThumbnails",
                column: "ProjectId",
                principalTable: "Project",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProjectThumbnails_Project_ProjectId",
                table: "ProjectThumbnails");

            migrationBuilder.AlterColumn<int>(
                name: "ProjectId",
                table: "ProjectThumbnails",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "ProjectThumbnails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectThumbnails_Project_ProjectId",
                table: "ProjectThumbnails",
                column: "ProjectId",
                principalTable: "Project",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
