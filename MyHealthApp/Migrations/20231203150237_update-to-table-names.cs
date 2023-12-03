using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyHealthApp.Migrations
{
    /// <inheritdoc />
    public partial class updatetotablenames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropForeignKey(
                name: "FK_MyWorkouts_MyDays_DayId",
                table: "MyWorkouts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MyWorkouts",
                table: "MyWorkouts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MyHealthyPeople",
                table: "MyHealthyPeople");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MyHealthCalendars",
                table: "MyHealthCalendars");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MyFoods",
                table: "MyFoods");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MyDays",
                table: "MyDays");

            migrationBuilder.RenameTable(
                name: "MyWorkouts",
                newName: "Workouts");

            migrationBuilder.RenameTable(
                name: "MyHealthyPeople",
                newName: "People");

            migrationBuilder.RenameTable(
                name: "MyHealthCalendars",
                newName: "Calendars");

            migrationBuilder.RenameTable(
                name: "MyFoods",
                newName: "Foods");

            migrationBuilder.RenameTable(
                name: "MyDays",
                newName: "Days");

            migrationBuilder.RenameIndex(
                name: "IX_MyWorkouts_DayId",
                table: "Workouts",
                newName: "IX_Workouts_DayId");

            migrationBuilder.RenameIndex(
                name: "IX_MyHealthCalendars_PersonId",
                table: "Calendars",
                newName: "IX_Calendars_PersonId");

            migrationBuilder.RenameIndex(
                name: "IX_MyDays_CalendarId",
                table: "Days",
                newName: "IX_Days_CalendarId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Workouts",
                table: "Workouts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_People",
                table: "People",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Calendars",
                table: "Calendars",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Foods",
                table: "Foods",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Days",
                table: "Days",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Calendars_People_PersonId",
                table: "Calendars",
                column: "PersonId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DayFood_Days_DaysId",
                table: "DayFood",
                column: "DaysId",
                principalTable: "Days",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DayFood_Foods_FoodId",
                table: "DayFood",
                column: "FoodId",
                principalTable: "Foods",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Days_Calendars_CalendarId",
                table: "Days",
                column: "CalendarId",
                principalTable: "Calendars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Workouts_Days_DayId",
                table: "Workouts",
                column: "DayId",
                principalTable: "Days",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Calendars_People_PersonId",
                table: "Calendars");

            migrationBuilder.DropForeignKey(
                name: "FK_DayFood_Days_DaysId",
                table: "DayFood");

            migrationBuilder.DropForeignKey(
                name: "FK_DayFood_Foods_FoodId",
                table: "DayFood");

            migrationBuilder.DropForeignKey(
                name: "FK_Days_Calendars_CalendarId",
                table: "Days");

            migrationBuilder.DropForeignKey(
                name: "FK_Workouts_Days_DayId",
                table: "Workouts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Workouts",
                table: "Workouts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_People",
                table: "People");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Foods",
                table: "Foods");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Days",
                table: "Days");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Calendars",
                table: "Calendars");

            migrationBuilder.RenameTable(
                name: "Workouts",
                newName: "MyWorkouts");

            migrationBuilder.RenameTable(
                name: "People",
                newName: "MyHealthyPeople");

            migrationBuilder.RenameTable(
                name: "Foods",
                newName: "MyFoods");

            migrationBuilder.RenameTable(
                name: "Days",
                newName: "MyDays");

            migrationBuilder.RenameTable(
                name: "Calendars",
                newName: "MyHealthCalendars");

            migrationBuilder.RenameIndex(
                name: "IX_Workouts_DayId",
                table: "MyWorkouts",
                newName: "IX_MyWorkouts_DayId");

            migrationBuilder.RenameIndex(
                name: "IX_Days_CalendarId",
                table: "MyDays",
                newName: "IX_MyDays_CalendarId");

            migrationBuilder.RenameIndex(
                name: "IX_Calendars_PersonId",
                table: "MyHealthCalendars",
                newName: "IX_MyHealthCalendars_PersonId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MyWorkouts",
                table: "MyWorkouts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MyHealthyPeople",
                table: "MyHealthyPeople",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MyFoods",
                table: "MyFoods",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MyDays",
                table: "MyDays",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MyHealthCalendars",
                table: "MyHealthCalendars",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_MyWorkouts_MyDays_DayId",
                table: "MyWorkouts",
                column: "DayId",
                principalTable: "MyDays",
                principalColumn: "Id");
        }
    }
}
