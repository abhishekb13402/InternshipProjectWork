using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InternshipProjectWork.Migrations
{
    /// <inheritdoc />
    public partial class EmpTblIdDataTypeChange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Employees",
                type: "nvarchar(30)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "nvarchar(30");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Email",
                table: "Employees",
                type: "nvarchar(30",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)");
        }
    }
}
