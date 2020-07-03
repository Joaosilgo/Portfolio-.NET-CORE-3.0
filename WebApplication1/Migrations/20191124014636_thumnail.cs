using Microsoft.EntityFrameworkCore.Migrations;

namespace infoSys.Migrations
{
    public partial class thumnail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProjectThumbnails",
                columns: table => new
                {
                    ProjectThumbnailId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    imageContent = table.Column<byte[]>(nullable: true),
                    imageMimeType = table.Column<string>(maxLength: 256, nullable: true),
                    imageFileName = table.Column<string>(maxLength: 100, nullable: true),
                    Id = table.Column<int>(nullable: false),
                    ProjectId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectThumbnails", x => x.ProjectThumbnailId);
                    table.ForeignKey(
                        name: "FK_ProjectThumbnails_Project_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Project",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProjectThumbnails_ProjectId",
                table: "ProjectThumbnails",
                column: "ProjectId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProjectThumbnails");
        }
    }
}
