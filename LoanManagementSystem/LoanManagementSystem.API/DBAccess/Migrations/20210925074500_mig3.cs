using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LoanManagementSystem.API.DBAccess.Migrations
{
    public partial class mig3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LoanStatus",
                table: "LoanDetails",
                type: "varchar(30)",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LoanAccNumber",
                table: "LoanDetails",
                type: "varchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreditLimit",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "LastUpdatedCreditDate",
                table: "Customer");

            migrationBuilder.AlterColumn<string>(
                name: "LoanStatus",
                table: "LoanDetails",
                type: "varchar",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(30)",
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LoanAccNumber",
                table: "LoanDetails",
                type: "varchar",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(30)",
                oldMaxLength: 30);
        }
    }
}
