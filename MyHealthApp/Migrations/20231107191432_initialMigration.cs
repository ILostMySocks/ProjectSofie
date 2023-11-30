using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyHealthApp.Migrations
{
    /// <inheritdoc />
    public partial class initialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MyHealthCalendars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyHealthCalendars", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MyDays",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Today = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MyHealthCalendarId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyDays", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MyDays_MyHealthCalendars_MyHealthCalendarId",
                        column: x => x.MyHealthCalendarId,
                        principalTable: "MyHealthCalendars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MyHealthyPeople",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GenderIdentity = table.Column<int>(type: "int", nullable: false),
                    HealthCalendarId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyHealthyPeople", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MyHealthyPeople_MyHealthCalendars_HealthCalendarId",
                        column: x => x.HealthCalendarId,
                        principalTable: "MyHealthCalendars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MyFoods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FoodName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CalorieCount = table.Column<int>(type: "int", nullable: false),
                    DayId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyFoods", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MyFoods_MyDays_DayId",
                        column: x => x.DayId,
                        principalTable: "MyDays",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MyWorkouts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WorkoutName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CaloriesBurnt = table.Column<int>(type: "int", nullable: false),
                    DayId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyWorkouts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MyWorkouts_MyDays_DayId",
                        column: x => x.DayId,
                        principalTable: "MyDays",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_MyDays_MyHealthCalendarId",
                table: "MyDays",
                column: "MyHealthCalendarId");

            migrationBuilder.CreateIndex(
                name: "IX_MyFoods_DayId",
                table: "MyFoods",
                column: "DayId");

            migrationBuilder.CreateIndex(
                name: "IX_MyHealthyPeople_HealthCalendarId",
                table: "MyHealthyPeople",
                column: "HealthCalendarId");

            migrationBuilder.CreateIndex(
                name: "IX_MyWorkouts_DayId",
                table: "MyWorkouts",
                column: "DayId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MyFoods");

            migrationBuilder.DropTable(
                name: "MyHealthyPeople");

            migrationBuilder.DropTable(
                name: "MyWorkouts");

            migrationBuilder.DropTable(
                name: "MyDays");

            migrationBuilder.DropTable(
                name: "MyHealthCalendars");
        }
    }
}
