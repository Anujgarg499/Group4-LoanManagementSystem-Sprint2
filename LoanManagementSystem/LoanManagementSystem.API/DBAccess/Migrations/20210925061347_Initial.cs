using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LoanManagementSystem.API.DBAccess.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    CustomerId = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    FirstName = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    LastName = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    CustomerPassword = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    Address = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    PanNumber = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    AadharNumber = table.Column<decimal>(type: "numeric", nullable: false),
                    ContactNumber = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    Email = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    DOB = table.Column<string>(type: "varchar", nullable: true),
                    CreditLimit = table.Column<decimal>(type: "numeric", nullable: true),
                    LastUpdatedCreditDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    EmpId = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    EmpName = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    EmpPassword = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    ContactNumber = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    Email = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    EmpType = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.EmpId);
                });

            migrationBuilder.CreateTable(
                name: "LoanDetails",
                columns: table => new
                {
                    LoanAccNumber = table.Column<string>(type: "varchar", nullable: false),
                    LoanAmount = table.Column<decimal>(type: "numeric", nullable: false),
                    CustomerId = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    EmpId = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    LoanType = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    LoanApprovedDate = table.Column<DateTime>(type: "datetime2", maxLength: 30, nullable: false),
                    LoanStatus = table.Column<string>(type: "varchar", nullable: true,defaultValueSql: "Pending"),
                    DispersalDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InteresrRate = table.Column<decimal>(type: "numeric", nullable: false),
                    Tenure = table.Column<decimal>(type: "numeric", nullable: true),
                    EmiStartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EmiEndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EmiAmount = table.Column<decimal>(type: "numeric", nullable: true),
                    CreditLimit = table.Column<decimal>(type: "numeric", nullable: true),
                    LastUpdatedCreditDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CustomerAssetId = table.Column<decimal>(type: "numeric", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoanDetails", x => x.LoanAccNumber);
                    table.ForeignKey(
                        name: "FK_LoanDetails_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LoanDetails_Employee_EmpId",
                        column: x => x.EmpId,
                        principalTable: "Employee",
                        principalColumn: "EmpId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LoanDetails_CustomerId",
                table: "LoanDetails",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_LoanDetails_EmpId",
                table: "LoanDetails",
                column: "EmpId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LoanDetails");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Employee");
        }
    }
}
