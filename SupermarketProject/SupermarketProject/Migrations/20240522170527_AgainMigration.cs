using Microsoft.EntityFrameworkCore.Migrations;

namespace SupermarketProject.Migrations
{
    public partial class AgainMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var procedure11 = @"CREATE PROCEDURE [dbo].[SelectProducts] 
                    @ProducerId int,
                    @CategoryId int
                AS
                BEGIN
                    SET NOCOUNT ON;
                    SELECT * FROM Products WHERE CategoryID=@CategoryId AND ProducerID=@ProducerId
                END";
            migrationBuilder.Sql(procedure11);

            var procedure12 = @"CREATE PROCEDURE [dbo].[CategoryTotalPrice]
                AS
                BEGIN
                    SELECT c.Name, SUM(s.SellingPrice) AS TotalPrice 
                    FROM Products p
                    INNER JOIN Stock s ON p.ProductID=s.ProductID
                    INNER JOIN Categories c ON p.CategoryID=c.CategoryID
                    WHERE s.SellingPrice IS NOT NULL AND p.IsActive=1
                    GROUP BY c.Name
                END";
            migrationBuilder.Sql(procedure12);

            var procedure13 = @"CREATE PROCEDURE [dbo].[DailyTotalCashier] 
                        @CashierID int,
                        @StartDate Date,
                        @EndDate Date
                    AS
                    BEGIN
                        SET NOCOUNT ON;
                         SELECT
                            DAY(ReleseDate) AS Day,
                            SUM(Total) AS Total
                        FROM Receipts
                        WHERE
                            UserID = @CashierID AND
                            ReleseDate >= @StartDate AND
                            ReleseDate < @EndDate
                        GROUP BY DAY(ReleseDate)
                        ORDER BY DAY(ReleseDate)
                    END";
            migrationBuilder.Sql(procedure13);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
