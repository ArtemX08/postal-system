using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PostalSystem.Migrations
{
    /// <inheritdoc />
    public partial class AddCityNameToPostOffice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CityName",
                table: "PostOffices",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CityName",
                table: "PostOffices");
        }
    }
}
