using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InternshipProjectWork.Migrations
{
    /// <inheritdoc />
    public partial class UPdeptname : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Departments",
                newName: "DeptName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DeptName",
                table: "Departments",
                newName: "Name");
        }
    }
}
