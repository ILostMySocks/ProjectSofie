using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyHealthApp.Migrations
{
    /// <inheritdoc />
    public partial class updatetonamesandrepos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DayFood_MyDays_DaysEatenId",
                table: "DayFood");

            migrationBuilder.DropForeignKey(
                name: "FK_DayFood_MyFoods_MyFoodTodayId",
                table: "DayFood");

            migrationBuilder.DropForeignKey(
                name: "FK_MyDays_MyHealthCalendars_MyHealthCalendarId",
                table: "MyDays");

            migrationBuilder.DropForeignKey(
                name: "FK_MyHealthCalendars_MyHealthyPeople_MyHealthyPersonId",
                table: "MyHealthCalendars");

            migrationBuilder.RenameColumn(
                name: "MyHealthyPersonId",
                table: "MyHealthCalendars",
                newName: "PersonId");

            migrationBuilder.RenameIndex(
                name: "IX_MyHealthCalendars_MyHealthyPersonId",
                table: "MyHealthCalendars",
                newName: "IX_MyHealthCalendars_PersonId");

            migrationBuilder.RenameColumn(
                name: "MyHealthCalendarId",
                table: "MyDays",
                newName: "CalendarId");

            migrationBuilder.RenameIndex(
                name: "IX_MyDays_MyHealthCalendarId",
                table: "MyDays",
                newName: "IX_MyDays_CalendarId");

            migrationBuilder.RenameColumn(
                name: "MyFoodTodayId",
                table: "DayFood",
                newName: "FoodId");

            migrationBuilder.RenameColumn(
                name: "DaysEatenId",
                table: "DayFood",
                newName: "DaysId");

            migrationBuilder.RenameIndex(
                name: "IX_DayFood_MyFoodTodayId",
                table: "DayFood",
                newName: "IX_DayFood_FoodId");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "MyHealthyPeople",
                type: "nvarchar(254)",
                maxLength: 254,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_DayFood_MyDays_DaysId",
                table: "DayFood",
                column: "DaysId",
                principalTable: "MyDays",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DayFood_MyFoods_FoodId",
                table: "DayFood",
                column: "FoodId",
                principalTable: "MyFoods",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MyDays_MyHealthCalendars_CalendarId",
                table: "MyDays",
                column: "CalendarId",
                principalTable: "MyHealthCalendars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MyHealthCalendars_MyHealthyPeople_PersonId",
                table: "MyHealthCalendars",
                column: "PersonId",
                principalTable: "MyHealthyPeople",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DayFood_MyDays_DaysId",
                table: "DayFood");

            migrationBuilder.DropForeignKey(
                name: "FK_DayFood_MyFoods_FoodId",
                table: "DayFood");

            migrationBuilder.DropForeignKey(
                name: "FK_MyDays_MyHealthCalendars_CalendarId",
                table: "MyDays");

            migrationBuilder.DropForeignKey(
                name: "FK_MyHealthCalendars_MyHealthyPeople_PersonId",
                table: "MyHealthCalendars");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "MyHealthyPeople");

            migrationBuilder.RenameColumn(
                name: "PersonId",
                table: "MyHealthCalendars",
                newName: "MyHealthyPersonId");

            migrationBuilder.RenameIndex(
                name: "IX_MyHealthCalendars_PersonId",
                table: "MyHealthCalendars",
                newName: "IX_MyHealthCalendars_MyHealthyPersonId");

            migrationBuilder.RenameColumn(
                name: "CalendarId",
                table: "MyDays",
                newName: "MyHealthCalendarId");

            migrationBuilder.RenameIndex(
                name: "IX_MyDays_CalendarId",
                table: "MyDays",
                newName: "IX_MyDays_MyHealthCalendarId");

            migrationBuilder.RenameColumn(
                name: "FoodId",
                table: "DayFood",
                newName: "MyFoodTodayId");

            migrationBuilder.RenameColumn(
                name: "DaysId",
                table: "DayFood",
                newName: "DaysEatenId");

            migrationBuilder.RenameIndex(
                name: "IX_DayFood_FoodId",
                table: "DayFood",
                newName: "IX_DayFood_MyFoodTodayId");

            migrationBuilder.AddForeignKey(
                name: "FK_DayFood_MyDays_DaysEatenId",
                table: "DayFood",
                column: "DaysEatenId",
                principalTable: "MyDays",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DayFood_MyFoods_MyFoodTodayId",
                table: "DayFood",
                column: "MyFoodTodayId",
                principalTable: "MyFoods",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MyDays_MyHealthCalendars_MyHealthCalendarId",
                table: "MyDays",
                column: "MyHealthCalendarId",
                principalTable: "MyHealthCalendars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MyHealthCalendars_MyHealthyPeople_MyHealthyPersonId",
                table: "MyHealthCalendars",
                column: "MyHealthyPersonId",
                principalTable: "MyHealthyPeople",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
