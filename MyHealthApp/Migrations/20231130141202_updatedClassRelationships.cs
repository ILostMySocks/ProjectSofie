using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyHealthApp.Migrations
{
    /// <inheritdoc />
    public partial class updatedClassRelationships : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MyFoods_MyDays_DayId",
                table: "MyFoods");

            migrationBuilder.DropForeignKey(
                name: "FK_MyHealthyPeople_MyHealthCalendars_MyHealthCalendarId",
                table: "MyHealthyPeople");

            migrationBuilder.DropIndex(
                name: "IX_MyHealthyPeople_MyHealthCalendarId",
                table: "MyHealthyPeople");

            migrationBuilder.DropIndex(
                name: "IX_MyFoods_DayId",
                table: "MyFoods");

            migrationBuilder.DropColumn(
                name: "MyHealthCalendarId",
                table: "MyHealthyPeople");

            migrationBuilder.DropColumn(
                name: "DayId",
                table: "MyFoods");

            migrationBuilder.CreateTable(
                name: "DayFood",
                columns: table => new
                {
                    DaysEatenId = table.Column<int>(type: "int", nullable: false),
                    MyFoodTodayId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DayFood", x => new { x.DaysEatenId, x.MyFoodTodayId });
                    table.ForeignKey(
                        name: "FK_DayFood_MyDays_DaysEatenId",
                        column: x => x.DaysEatenId,
                        principalTable: "MyDays",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DayFood_MyFoods_MyFoodTodayId",
                        column: x => x.MyFoodTodayId,
                        principalTable: "MyFoods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MyHealthCalendars_MyHealthyPersonId",
                table: "MyHealthCalendars",
                column: "MyHealthyPersonId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DayFood_MyFoodTodayId",
                table: "DayFood",
                column: "MyFoodTodayId");

            migrationBuilder.AddForeignKey(
                name: "FK_MyHealthCalendars_MyHealthyPeople_MyHealthyPersonId",
                table: "MyHealthCalendars",
                column: "MyHealthyPersonId",
                principalTable: "MyHealthyPeople",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MyHealthCalendars_MyHealthyPeople_MyHealthyPersonId",
                table: "MyHealthCalendars");

            migrationBuilder.DropTable(
                name: "DayFood");

            migrationBuilder.DropIndex(
                name: "IX_MyHealthCalendars_MyHealthyPersonId",
                table: "MyHealthCalendars");

            migrationBuilder.AddColumn<int>(
                name: "MyHealthCalendarId",
                table: "MyHealthyPeople",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DayId",
                table: "MyFoods",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_MyHealthyPeople_MyHealthCalendarId",
                table: "MyHealthyPeople",
                column: "MyHealthCalendarId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MyFoods_DayId",
                table: "MyFoods",
                column: "DayId");

            migrationBuilder.AddForeignKey(
                name: "FK_MyFoods_MyDays_DayId",
                table: "MyFoods",
                column: "DayId",
                principalTable: "MyDays",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MyHealthyPeople_MyHealthCalendars_MyHealthCalendarId",
                table: "MyHealthyPeople",
                column: "MyHealthCalendarId",
                principalTable: "MyHealthCalendars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
