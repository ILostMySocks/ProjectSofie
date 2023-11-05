using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFDal.Migrations
{
    /// <inheritdoc />
    public partial class dbcontextFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MyFoods_MyHealthCalendars_DayId",
                table: "MyFoods");

            migrationBuilder.DropForeignKey(
                name: "FK_MyHealthyPeople_Calendar_HealthCalendarId",
                table: "MyHealthyPeople");

            migrationBuilder.DropForeignKey(
                name: "FK_MyWorkouts_MyHealthCalendars_DayId",
                table: "MyWorkouts");

            migrationBuilder.DropTable(
                name: "Calendar");

            migrationBuilder.DropColumn(
                name: "Today",
                table: "MyHealthCalendars");

            migrationBuilder.AddColumn<int>(
                name: "MyHealthyDayId",
                table: "MyHealthCalendars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Day",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Today = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Day", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MyHealthCalendars_MyHealthyDayId",
                table: "MyHealthCalendars",
                column: "MyHealthyDayId");

            migrationBuilder.AddForeignKey(
                name: "FK_MyFoods_Day_DayId",
                table: "MyFoods",
                column: "DayId",
                principalTable: "Day",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MyHealthCalendars_Day_MyHealthyDayId",
                table: "MyHealthCalendars",
                column: "MyHealthyDayId",
                principalTable: "Day",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MyHealthyPeople_MyHealthCalendars_HealthCalendarId",
                table: "MyHealthyPeople",
                column: "HealthCalendarId",
                principalTable: "MyHealthCalendars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MyWorkouts_Day_DayId",
                table: "MyWorkouts",
                column: "DayId",
                principalTable: "Day",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MyFoods_Day_DayId",
                table: "MyFoods");

            migrationBuilder.DropForeignKey(
                name: "FK_MyHealthCalendars_Day_MyHealthyDayId",
                table: "MyHealthCalendars");

            migrationBuilder.DropForeignKey(
                name: "FK_MyHealthyPeople_MyHealthCalendars_HealthCalendarId",
                table: "MyHealthyPeople");

            migrationBuilder.DropForeignKey(
                name: "FK_MyWorkouts_Day_DayId",
                table: "MyWorkouts");

            migrationBuilder.DropTable(
                name: "Day");

            migrationBuilder.DropIndex(
                name: "IX_MyHealthCalendars_MyHealthyDayId",
                table: "MyHealthCalendars");

            migrationBuilder.DropColumn(
                name: "MyHealthyDayId",
                table: "MyHealthCalendars");

            migrationBuilder.AddColumn<DateTime>(
                name: "Today",
                table: "MyHealthCalendars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "Calendar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MyHealthyDayId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calendar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Calendar_MyHealthCalendars_MyHealthyDayId",
                        column: x => x.MyHealthyDayId,
                        principalTable: "MyHealthCalendars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Calendar_MyHealthyDayId",
                table: "Calendar",
                column: "MyHealthyDayId");

            migrationBuilder.AddForeignKey(
                name: "FK_MyFoods_MyHealthCalendars_DayId",
                table: "MyFoods",
                column: "DayId",
                principalTable: "MyHealthCalendars",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MyHealthyPeople_Calendar_HealthCalendarId",
                table: "MyHealthyPeople",
                column: "HealthCalendarId",
                principalTable: "Calendar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MyWorkouts_MyHealthCalendars_DayId",
                table: "MyWorkouts",
                column: "DayId",
                principalTable: "MyHealthCalendars",
                principalColumn: "Id");
        }
    }
}
