using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyHealthApp.Migrations
{
    /// <inheritdoc />
    public partial class updateModelBuilders2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_MyHealthyPeople_MyHealthCalendarId",
                table: "MyHealthyPeople");

            migrationBuilder.AlterColumn<string>(
                name: "GenderIdentity",
                table: "MyHealthyPeople",
                type: "nvarchar(11)",
                maxLength: 11,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "MyHealthyPersonId",
                table: "MyHealthCalendars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_MyHealthyPeople_MyHealthCalendarId",
                table: "MyHealthyPeople",
                column: "MyHealthCalendarId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_MyHealthyPeople_MyHealthCalendarId",
                table: "MyHealthyPeople");

            migrationBuilder.DropColumn(
                name: "MyHealthyPersonId",
                table: "MyHealthCalendars");

            migrationBuilder.AlterColumn<int>(
                name: "GenderIdentity",
                table: "MyHealthyPeople",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(11)",
                oldMaxLength: 11);

            migrationBuilder.CreateIndex(
                name: "IX_MyHealthyPeople_MyHealthCalendarId",
                table: "MyHealthyPeople",
                column: "MyHealthCalendarId");
        }
    }
}
