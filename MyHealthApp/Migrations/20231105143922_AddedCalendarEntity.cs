using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFDal.Migrations
{
    /// <inheritdoc />
    public partial class AddedCalendarEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MyHealthCalendars_MyHealthyPeople_PersonId",
                table: "MyHealthCalendars");

            migrationBuilder.DropIndex(
                name: "IX_MyHealthCalendars_PersonId",
                table: "MyHealthCalendars");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "MyHealthCalendars");

            migrationBuilder.AddColumn<int>(
                name: "HealthCalendarId",
                table: "MyHealthyPeople",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                name: "IX_MyHealthyPeople_HealthCalendarId",
                table: "MyHealthyPeople",
                column: "HealthCalendarId");

            migrationBuilder.CreateIndex(
                name: "IX_Calendar_MyHealthyDayId",
                table: "Calendar",
                column: "MyHealthyDayId");

            migrationBuilder.AddForeignKey(
                name: "FK_MyHealthyPeople_Calendar_HealthCalendarId",
                table: "MyHealthyPeople",
                column: "HealthCalendarId",
                principalTable: "Calendar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MyHealthyPeople_Calendar_HealthCalendarId",
                table: "MyHealthyPeople");

            migrationBuilder.DropTable(
                name: "Calendar");

            migrationBuilder.DropIndex(
                name: "IX_MyHealthyPeople_HealthCalendarId",
                table: "MyHealthyPeople");

            migrationBuilder.DropColumn(
                name: "HealthCalendarId",
                table: "MyHealthyPeople");

            migrationBuilder.AddColumn<int>(
                name: "PersonId",
                table: "MyHealthCalendars",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_MyHealthCalendars_PersonId",
                table: "MyHealthCalendars",
                column: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_MyHealthCalendars_MyHealthyPeople_PersonId",
                table: "MyHealthCalendars",
                column: "PersonId",
                principalTable: "MyHealthyPeople",
                principalColumn: "Id");
        }
    }
}
