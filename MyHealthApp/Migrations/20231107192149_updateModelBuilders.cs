using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyHealthApp.Migrations
{
    /// <inheritdoc />
    public partial class updateModelBuilders : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MyHealthyPeople_MyHealthCalendars_HealthCalendarId",
                table: "MyHealthyPeople");

            migrationBuilder.RenameColumn(
                name: "HealthCalendarId",
                table: "MyHealthyPeople",
                newName: "MyHealthCalendarId");

            migrationBuilder.RenameIndex(
                name: "IX_MyHealthyPeople_HealthCalendarId",
                table: "MyHealthyPeople",
                newName: "IX_MyHealthyPeople_MyHealthCalendarId");

            migrationBuilder.AlterColumn<string>(
                name: "WorkoutName",
                table: "MyWorkouts",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FoodName",
                table: "MyFoods",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddForeignKey(
                name: "FK_MyHealthyPeople_MyHealthCalendars_MyHealthCalendarId",
                table: "MyHealthyPeople",
                column: "MyHealthCalendarId",
                principalTable: "MyHealthCalendars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MyHealthyPeople_MyHealthCalendars_MyHealthCalendarId",
                table: "MyHealthyPeople");

            migrationBuilder.RenameColumn(
                name: "MyHealthCalendarId",
                table: "MyHealthyPeople",
                newName: "HealthCalendarId");

            migrationBuilder.RenameIndex(
                name: "IX_MyHealthyPeople_MyHealthCalendarId",
                table: "MyHealthyPeople",
                newName: "IX_MyHealthyPeople_HealthCalendarId");

            migrationBuilder.AlterColumn<string>(
                name: "WorkoutName",
                table: "MyWorkouts",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(300)",
                oldMaxLength: 300);

            migrationBuilder.AlterColumn<string>(
                name: "FoodName",
                table: "MyFoods",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(300)",
                oldMaxLength: 300);

            migrationBuilder.AddForeignKey(
                name: "FK_MyHealthyPeople_MyHealthCalendars_HealthCalendarId",
                table: "MyHealthyPeople",
                column: "HealthCalendarId",
                principalTable: "MyHealthCalendars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
