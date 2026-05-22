using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PostalSystem.Migrations
{
    /// <inheritdoc />
    public partial class AddReceiverName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ReceiverName",
                table: "Parcels",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReceiverName",
                table: "Parcels");
        }
    }
}
