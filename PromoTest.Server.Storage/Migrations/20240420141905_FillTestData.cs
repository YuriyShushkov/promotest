using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PromoTest.Server.Storage.Migrations
{
    /// <inheritdoc />
    public partial class FillTestData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                INSERT INTO ""Countries"" VALUES 
                (1, 'Country 1'),
                (2, 'Country 2')");

            migrationBuilder.Sql(@"
                INSERT INTO ""Provinces"" VALUES
                (1, 1, 'Province 1.1'),
                (2, 1, 'Province 1.2'),
                (3, 2, 'Province 2.1'),
                (4, 2, 'Province 2.2'),
                (5, 2, 'Province 2.2')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
