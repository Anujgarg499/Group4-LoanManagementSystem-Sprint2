using Microsoft.EntityFrameworkCore.Migrations;

namespace LoanManagementSystem.API.DBAccess.Migrations
{
    public partial class mig6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LoanDetails_Employee_EmpId",
                table: "LoanDetails");

            migrationBuilder.AlterColumn<string>(
                name: "EmpId",
                table: "LoanDetails",
                type: "varchar(30)",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AddForeignKey(
                name: "FK_LoanDetails_Employee_EmpId",
                table: "LoanDetails",
                column: "EmpId",
                principalTable: "Employee",
                principalColumn: "EmpId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LoanDetails_Employee_EmpId",
                table: "LoanDetails");

            migrationBuilder.AlterColumn<string>(
                name: "EmpId",
                table: "LoanDetails",
                type: "varchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(30)",
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_LoanDetails_Employee_EmpId",
                table: "LoanDetails",
                column: "EmpId",
                principalTable: "Employee",
                principalColumn: "EmpId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
