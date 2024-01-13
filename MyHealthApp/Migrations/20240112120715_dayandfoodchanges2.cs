using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyHealthApp.Migrations
{
    /// <inheritdoc />
    public partial class dayandfoodchanges2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Foods_Days_DayId",
                table: "Foods");

            migrationBuilder.DropIndex(
                name: "IX_Foods_DayId",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "DayId",
                table: "Foods");

            migrationBuilder.CreateTable(
                name: "DayFood",
                columns: table => new
                {
                    DaysId = table.Column<int>(type: "int", nullable: false),
                    FoodsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DayFood", x => new { x.DaysId, x.FoodsId });
                    table.ForeignKey(
                        name: "FK_DayFood_Days_DaysId",
                        column: x => x.DaysId,
                        principalTable: "Days",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DayFood_Foods_FoodsId",
                        column: x => x.FoodsId,
                        principalTable: "Foods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DayFood_FoodsId",
                table: "DayFood",
                column: "FoodsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DayFood");

            migrationBuilder.AddColumn<int>(
                name: "DayId",
                table: "Foods",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Foods_DayId",
                table: "Foods",
                column: "DayId");

            migrationBuilder.AddForeignKey(
                name: "FK_Foods_Days_DayId",
                table: "Foods",
                column: "DayId",
                principalTable: "Days",
                principalColumn: "Id");
        }
    }
}
