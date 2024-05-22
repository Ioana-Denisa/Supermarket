using Microsoft.EntityFrameworkCore.Migrations;

namespace SupermarketProject.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var procedure = @"CREATE PROCEDURE [dbo].[GetAllUsers]
                AS
                BEGIN
                    SET NOCOUNT ON;
                    SELECT * FROM Users where IsActive=1
                END";
            migrationBuilder.Sql(procedure);

            var procedure2 = @"CREATE PROCEDURE [dbo].[GetAllCategories]
                AS
                BEGIN
                    SET NOCOUNT ON;
                    SELECT * FROM Categories where IsActive=1
                END";
            migrationBuilder.Sql(procedure2);

           

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
