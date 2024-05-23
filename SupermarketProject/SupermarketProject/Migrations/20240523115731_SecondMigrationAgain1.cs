using Microsoft.EntityFrameworkCore.Migrations;

namespace SupermarketProject.Migrations
{
    public partial class SecondMigrationAgain1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CategoryTotalPrices",
                table: "CategoryTotalPrices");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "CategoryTotalPrices");

            migrationBuilder.AlterColumn<string>(
                name: "CategoryName",
                table: "CategoryTotalPrices",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CategoryTotalPrices",
                table: "CategoryTotalPrices",
                column: "CategoryName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CategoryTotalPrices",
                table: "CategoryTotalPrices");

            migrationBuilder.AlterColumn<string>(
                name: "CategoryName",
                table: "CategoryTotalPrices",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "CategoryTotalPrices",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CategoryTotalPrices",
                table: "CategoryTotalPrices",
                column: "ID");
        }
    }
}
