using Microsoft.EntityFrameworkCore.Migrations;

namespace SupermarketProject.Migrations
{
    public partial class NewMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var procedure3 = @"CREATE PROCEDURE [dbo].[CreateCategories]
                    @Name nvarchar(MAX)
                AS
                BEGIN
                    SET NOCOUNT ON;
                    Insert into Categories([Name],[IsActive]) values(@Name, 1)  
                END";
            migrationBuilder.Sql(procedure3);

            var procedure4 = @"CREATE PROCEDURE [dbo].[CreateProducer] 
                    @Name nvarchar(MAX),
                    @Country nvarchar(MAX)
                AS
                BEGIN
                    SET NOCOUNT ON;
                    Insert into Producers([Name],[Country],[IsActive]) values(@Name,@Country,1)
                END";
            migrationBuilder.Sql(procedure4);

            var procedure5 = @"CREATE PROCEDURE [dbo].[UpdateCategory] 
                    @Name nvarchar(MAX),
                    @ID int
                AS
                BEGIN
                    SET NOCOUNT ON;
                    Update Categories set Name = @Name where @ID = CategoryID
                END";
            migrationBuilder.Sql(procedure5);

            var procedure6 = @"CREATE PROCEDURE [dbo].[UpdateProducers]
                    @Name nvarchar(MAX),
                    @Country nvarchar(MAX),
                    @ID int
                AS
                BEGIN
                    SET NOCOUNT ON;
                    Update Producers set Name = @Name, Country = @Country
                    where ProducerID = @ID
                 END";
            migrationBuilder.Sql(procedure6);

            var procedure7 = @"CREATE PROCEDURE [dbo].[DeleteCategory]
                    @ID int
                AS
                BEGIN
                    SET NOCOUNT ON;
                    Update Categories set IsActive = 0 where CategoryID = @ID
                END";
            migrationBuilder.Sql(procedure7);

            var procedure8 = @"CREATE PROCEDURE [dbo].[DeleteProducer]
                    @ID int
                AS
                BEGIN
                    SET NOCOUNT ON;
                    Update Producers set IsActive = 0 where ProducerID = @ID
                END";
            migrationBuilder.Sql(procedure8);

            var procedure9 = @"CREATE PROCEDURE [dbo].[DeleteUser]
                    @ID int
                AS
                BEGIN
                    SET NOCOUNT ON;
                    Update Users set IsActive = 0 where UserID = @ID
                END";
            migrationBuilder.Sql(procedure9);

            var procedure10 = @"CREATE PROCEDURE [dbo].[CreateUser] 
                    @Name nvarchar(MAX),
                    @Password nvarchar(MAX),
                    @Type nvarchar(MAX)
                AS
                BEGIN
                    SET NOCOUNT ON;
                    Insert into Users([Name],[Password],[Type],[IsActive]) values(@Name,@Password,@Type, 1)
                END";
            migrationBuilder.Sql(procedure10);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
