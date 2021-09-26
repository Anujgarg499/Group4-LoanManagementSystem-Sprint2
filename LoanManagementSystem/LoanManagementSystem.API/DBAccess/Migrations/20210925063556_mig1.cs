using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LoanManagementSystem.API.DBAccess.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreditLimit",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "LastUpdatedCreditDate",
                table: "Customer");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "CreditLimit",
                table: "Customer",
                type: "numeric",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdatedCreditDate",
                table: "Customer",
                type: "datetime2",
                nullable: true);
        }
    }
}
