using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFDal.Migrations
{
    /// <inheritdoc />
    public partial class dbcontextFix2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MyFoods_Day_DayId",
                table: "MyFoods");

            migrationBuilder.DropForeignKey(
                name: "FK_MyHealthCalendars_Day_MyHealthyDayId",
                table: "MyHealthCalendars");

            migrationBuilder.DropForeignKey(
                name: "FK_MyWorkouts_Day_DayId",
                table: "MyWorkouts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Day",
                table: "Day");

            migrationBuilder.RenameTable(
                name: "Day",
                newName: "MyDays");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MyDays",
                table: "MyDays",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MyFoods_MyDays_DayId",
                table: "MyFoods",
                column: "DayId",
                principalTable: "MyDays",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MyHealthCalendars_MyDays_MyHealthyDayId",
                table: "MyHealthCalendars",
                column: "MyHealthyDayId",
                principalTable: "MyDays",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MyWorkouts_MyDays_DayId",
                table: "MyWorkouts",
                column: "DayId",
                principalTable: "MyDays",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MyFoods_MyDays_DayId",
                table: "MyFoods");

            migrationBuilder.DropForeignKey(
                name: "FK_MyHealthCalendars_MyDays_MyHealthyDayId",
                table: "MyHealthCalendars");

            migrationBuilder.DropForeignKey(
                name: "FK_MyWorkouts_MyDays_DayId",
                table: "MyWorkouts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MyDays",
                table: "MyDays");

            migrationBuilder.RenameTable(
                name: "MyDays",
                newName: "Day");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Day",
                table: "Day",
                column: "Id");

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
                name: "FK_MyWorkouts_Day_DayId",
                table: "MyWorkouts",
                column: "DayId",
                principalTable: "Day",
                principalColumn: "Id");
        }
    }
}
