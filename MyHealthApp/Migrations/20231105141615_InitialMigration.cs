using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFDal.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MyHealthyPeople",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GenderIdentity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyHealthyPeople", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MyHealthCalendars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Today = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PersonId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyHealthCalendars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MyHealthCalendars_MyHealthyPeople_PersonId",
                        column: x => x.PersonId,
                        principalTable: "MyHealthyPeople",
                        principalColumn: "Id");
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
                        name: "FK_MyFoods_MyHealthCalendars_DayId",
                        column: x => x.DayId,
                        principalTable: "MyHealthCalendars",
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
                        name: "FK_MyWorkouts_MyHealthCalendars_DayId",
                        column: x => x.DayId,
                        principalTable: "MyHealthCalendars",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_MyFoods_DayId",
                table: "MyFoods",
                column: "DayId");

            migrationBuilder.CreateIndex(
                name: "IX_MyHealthCalendars_PersonId",
                table: "MyHealthCalendars",
                column: "PersonId");

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
                name: "MyWorkouts");

            migrationBuilder.DropTable(
                name: "MyHealthCalendars");

            migrationBuilder.DropTable(
                name: "MyHealthyPeople");
        }
    }
}
