using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RentConstructionMach.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Customers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MachineRequests_Customers_CustomerID",
                table: "MachineRequests");

            migrationBuilder.DropForeignKey(
                name: "FK_Machines_Brands_BrandId",
                table: "Machines");

            migrationBuilder.DropIndex(
                name: "IX_MachineRequests_CustomerID",
                table: "MachineRequests");

            migrationBuilder.DropColumn(
                name: "CustomerID",
                table: "MachineRequests");

            migrationBuilder.RenameColumn(
                name: "BrandId",
                table: "Machines",
                newName: "BrandID");

            migrationBuilder.RenameIndex(
                name: "IX_Machines_BrandId",
                table: "Machines",
                newName: "IX_Machines_BrandID");

            migrationBuilder.AddColumn<string>(
                name: "CompanyName",
                table: "MachineRequests",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "CustomerName",
                table: "MachineRequests",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "CustomerSurname",
                table: "MachineRequests",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "MachineRequests",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "MachineRequests",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddForeignKey(
                name: "FK_Machines_Brands_BrandID",
                table: "Machines",
                column: "BrandID",
                principalTable: "Brands",
                principalColumn: "BrandID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Machines_Brands_BrandID",
                table: "Machines");

            migrationBuilder.DropColumn(
                name: "CompanyName",
                table: "MachineRequests");

            migrationBuilder.DropColumn(
                name: "CustomerName",
                table: "MachineRequests");

            migrationBuilder.DropColumn(
                name: "CustomerSurname",
                table: "MachineRequests");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "MachineRequests");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "MachineRequests");

            migrationBuilder.RenameColumn(
                name: "BrandID",
                table: "Machines",
                newName: "BrandId");

            migrationBuilder.RenameIndex(
                name: "IX_Machines_BrandID",
                table: "Machines",
                newName: "IX_Machines_BrandId");

            migrationBuilder.AddColumn<int>(
                name: "CustomerID",
                table: "MachineRequests",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_MachineRequests_CustomerID",
                table: "MachineRequests",
                column: "CustomerID");

            migrationBuilder.AddForeignKey(
                name: "FK_MachineRequests_Customers_CustomerID",
                table: "MachineRequests",
                column: "CustomerID",
                principalTable: "Customers",
                principalColumn: "CustomerID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Machines_Brands_BrandId",
                table: "Machines",
                column: "BrandId",
                principalTable: "Brands",
                principalColumn: "BrandID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
