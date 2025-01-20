using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RentConstructionMach.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class nototalprice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalPrice",
                table: "MachineRequests");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "TotalPrice",
                table: "MachineRequests",
                type: "decimal(65,30)",
                nullable: true);
        }
    }
}
