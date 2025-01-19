using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RentConstructionMach.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class migMachine : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tagClouds_Blogs_BlogID",
                table: "tagClouds");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tagClouds",
                table: "tagClouds");

            migrationBuilder.RenameTable(
                name: "tagClouds",
                newName: "TagClouds");

            migrationBuilder.RenameIndex(
                name: "IX_tagClouds_BlogID",
                table: "TagClouds",
                newName: "IX_TagClouds_BlogID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TagClouds",
                table: "TagClouds",
                column: "TagCloudID");

            migrationBuilder.CreateTable(
                name: "AddServices",
                columns: table => new
                {
                    AddServiceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddServices", x => x.AddServiceID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    BrandID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    BrandName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.BrandID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CustomerName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CustomerSurname = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Phone = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CompanyName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    LocationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    City = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.LocationID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "MachCategories",
                columns: table => new
                {
                    MachCategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MachCategories", x => x.MachCategoryID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Pricings",
                columns: table => new
                {
                    PricingID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PricingName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pricings", x => x.PricingID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Machines",
                columns: table => new
                {
                    MachineID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    BrandId = table.Column<int>(type: "int", nullable: false),
                    MachCategoryID = table.Column<int>(type: "int", nullable: false),
                    Model = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    WorkingWeight = table.Column<int>(type: "int", nullable: false),
                    ListLocationID = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AvailabilityStatus = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    BigImgUrl = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    StandartImageUrl = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProductionYear = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    WorkingHours = table.Column<int>(type: "int", nullable: false),
                    TransportCapacity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Machines", x => x.MachineID);
                    table.ForeignKey(
                        name: "FK_Machines_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "BrandID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Machines_MachCategories_MachCategoryID",
                        column: x => x.MachCategoryID,
                        principalTable: "MachCategories",
                        principalColumn: "MachCategoryID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "MachinePricings",
                columns: table => new
                {
                    MachinePricingID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MachineID = table.Column<int>(type: "int", nullable: false),
                    PricingID = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(65,30)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MachinePricings", x => x.MachinePricingID);
                    table.ForeignKey(
                        name: "FK_MachinePricings_Machines_MachineID",
                        column: x => x.MachineID,
                        principalTable: "Machines",
                        principalColumn: "MachineID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MachinePricings_Pricings_PricingID",
                        column: x => x.PricingID,
                        principalTable: "Pricings",
                        principalColumn: "PricingID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "MachineRequests",
                columns: table => new
                {
                    MachineRequestID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MachineID = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    LocationID = table.Column<int>(type: "int", nullable: false),
                    DistrictName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    StartDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CustomerID = table.Column<int>(type: "int", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(65,30)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MachineRequests", x => x.MachineRequestID);
                    table.ForeignKey(
                        name: "FK_MachineRequests_Customers_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customers",
                        principalColumn: "CustomerID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MachineRequests_Locations_LocationID",
                        column: x => x.LocationID,
                        principalTable: "Locations",
                        principalColumn: "LocationID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MachineRequests_Machines_MachineID",
                        column: x => x.MachineID,
                        principalTable: "Machines",
                        principalColumn: "MachineID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "MachineServices",
                columns: table => new
                {
                    MachineServiceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MachineID = table.Column<int>(type: "int", nullable: false),
                    AddServiceID = table.Column<int>(type: "int", nullable: false),
                    Available = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MachineServices", x => x.MachineServiceID);
                    table.ForeignKey(
                        name: "FK_MachineServices_AddServices_AddServiceID",
                        column: x => x.AddServiceID,
                        principalTable: "AddServices",
                        principalColumn: "AddServiceID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MachineServices_Machines_MachineID",
                        column: x => x.MachineID,
                        principalTable: "Machines",
                        principalColumn: "MachineID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_MachinePricings_MachineID",
                table: "MachinePricings",
                column: "MachineID");

            migrationBuilder.CreateIndex(
                name: "IX_MachinePricings_PricingID",
                table: "MachinePricings",
                column: "PricingID");

            migrationBuilder.CreateIndex(
                name: "IX_MachineRequests_CustomerID",
                table: "MachineRequests",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_MachineRequests_LocationID",
                table: "MachineRequests",
                column: "LocationID");

            migrationBuilder.CreateIndex(
                name: "IX_MachineRequests_MachineID",
                table: "MachineRequests",
                column: "MachineID");

            migrationBuilder.CreateIndex(
                name: "IX_Machines_BrandId",
                table: "Machines",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Machines_MachCategoryID",
                table: "Machines",
                column: "MachCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_MachineServices_AddServiceID",
                table: "MachineServices",
                column: "AddServiceID");

            migrationBuilder.CreateIndex(
                name: "IX_MachineServices_MachineID",
                table: "MachineServices",
                column: "MachineID");

            migrationBuilder.AddForeignKey(
                name: "FK_TagClouds_Blogs_BlogID",
                table: "TagClouds",
                column: "BlogID",
                principalTable: "Blogs",
                principalColumn: "BlogID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TagClouds_Blogs_BlogID",
                table: "TagClouds");

            migrationBuilder.DropTable(
                name: "MachinePricings");

            migrationBuilder.DropTable(
                name: "MachineRequests");

            migrationBuilder.DropTable(
                name: "MachineServices");

            migrationBuilder.DropTable(
                name: "Pricings");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "AddServices");

            migrationBuilder.DropTable(
                name: "Machines");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "MachCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TagClouds",
                table: "TagClouds");

            migrationBuilder.RenameTable(
                name: "TagClouds",
                newName: "tagClouds");

            migrationBuilder.RenameIndex(
                name: "IX_TagClouds_BlogID",
                table: "tagClouds",
                newName: "IX_tagClouds_BlogID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tagClouds",
                table: "tagClouds",
                column: "TagCloudID");

            migrationBuilder.AddForeignKey(
                name: "FK_tagClouds_Blogs_BlogID",
                table: "tagClouds",
                column: "BlogID",
                principalTable: "Blogs",
                principalColumn: "BlogID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
