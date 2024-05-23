using Microsoft.EntityFrameworkCore.Migrations;

namespace SupermarketProject.Migrations
{
    public partial class SecondMigrationAgain : Migration
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

            //var procedure12 = @"CREATE PROCEDURE [dbo].[CategoryTotalPrice]
            //        @Name nvarchar(MAX) OUTPUT
            //    AS
            //    BEGIN
            //        SELECT @Name=c.Name
            //               SUM(s.SellingPrice*s.Quantity) AS TotalPrice 
            //        FROM Products p
            //        INNER JOIN Stock s ON p.ProductID=s.ProductID
            //        INNER JOIN Categories c ON p.CategoryID=c.CategoryID
            //        WHERE s.SellingPrice IS NOT NULL AND p.IsActive=1
            //        GROUP BY c.Name
            //    END";
            //migrationBuilder.Sql(procedure12);

            var procedure13 = @"
            CREATE PROCEDURE [dbo].[DailyTotalCashier] 
                @CashierID int,
                @SelectedMonth DateTime
            AS
            BEGIN
                SET NOCOUNT ON;
                DECLARE @StartDate DateTime;
                DECLARE @EndDate DateTime;
                SET @StartDate = DATEFROMPARTS(YEAR(@SelectedMonth), MONTH(@SelectedMonth), 1);
                SET @EndDate = DATEADD(MONTH, 1, @StartDate);
                SELECT 
                    DAY(ReleseDate) AS Day,
                    SUM(Total) AS Total
                FROM Receipts
                WHERE
                    UserID = @CashierID AND
                    ReleseDate >= @StartDate AND
                    ReleseDate < @EndDate
                GROUP BY DAY(ReleseDate)
                ORDER BY DAY(ReleseDate);
            END";
            migrationBuilder.Sql(procedure13);


            var procedure14 = @"CREATE PROCEDURE [dbo].[GetLargestReceiptOfDay]
                        @SelectedDate DateTime
                    AS
                    BEGIN
                        SELECT TOP 1 * FROM Receipts WHERE CAST(ReleseDate AS DATE)=@SelectedDate
                ORDER BY Total DESC;

                    END";
            migrationBuilder.Sql(procedure14);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }  
}
