using Microsoft.EntityFrameworkCore.Migrations;

namespace Reachis.Migrations
{
    public partial class Forst3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Area",
                columns: table => new
                {
                    AreaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AreaName = table.Column<string>(nullable: true),
                    AreaColor = table.Column<string>(nullable: true),
                    AreaTimeInMin = table.Column<int>(nullable: false),
                    PlannerId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Area", x => x.AreaId);
                    table.ForeignKey(
                        name: "FK_Area_PlannersTable_PlannerId",
                        column: x => x.PlannerId,
                        principalTable: "PlannersTable",
                        principalColumn: "PlannerId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Task",
                columns: table => new
                {
                    TaskId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaskDesc = table.Column<string>(nullable: true),
                    DayToDay = table.Column<string>(nullable: true),
                    TimeInMin = table.Column<int>(nullable: false),
                    Check = table.Column<int>(nullable: false),
                    AreaId = table.Column<int>(nullable: true),
                    PlannerId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Task", x => x.TaskId);
                    table.ForeignKey(
                        name: "FK_Task_Area_AreaId",
                        column: x => x.AreaId,
                        principalTable: "Area",
                        principalColumn: "AreaId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Task_PlannersTable_PlannerId",
                        column: x => x.PlannerId,
                        principalTable: "PlannersTable",
                        principalColumn: "PlannerId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Area_PlannerId",
                table: "Area",
                column: "PlannerId");

            migrationBuilder.CreateIndex(
                name: "IX_Task_AreaId",
                table: "Task",
                column: "AreaId");

            migrationBuilder.CreateIndex(
                name: "IX_Task_PlannerId",
                table: "Task",
                column: "PlannerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Task");

            migrationBuilder.DropTable(
                name: "Area");
        }
    }
}
