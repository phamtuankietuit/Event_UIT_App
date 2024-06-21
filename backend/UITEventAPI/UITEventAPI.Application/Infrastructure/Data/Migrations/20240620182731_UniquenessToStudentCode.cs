using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UITEventAPI.Application.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class UniquenessToStudentCode : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Role",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "StudentId",
                table: "Student",
                newName: "StudentCode");

            migrationBuilder.CreateIndex(
                name: "IX_Student_StudentCode",
                table: "Student",
                column: "StudentCode",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Student_StudentCode",
                table: "Student");

            migrationBuilder.RenameColumn(
                name: "StudentCode",
                table: "Student",
                newName: "StudentId");

            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
