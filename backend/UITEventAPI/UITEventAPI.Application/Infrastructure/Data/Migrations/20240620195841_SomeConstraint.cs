using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UITEventAPI.Application.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class SomeConstraint : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Student_StudentId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_UniversityUnit_UniversityUnitId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Event_AspNetUsers_CreatedByUserId",
                table: "Event");

            migrationBuilder.DropForeignKey(
                name: "FK_Event_AspNetUsers_LastModifiedByUserId",
                table: "Event");

            migrationBuilder.DropForeignKey(
                name: "FK_Event_UniversityUnit_UniversityUnitId",
                table: "Event");

            migrationBuilder.DropForeignKey(
                name: "FK_EventImage_Event_EventId",
                table: "EventImage");

            migrationBuilder.DropForeignKey(
                name: "FK_EventRegistration_AspNetUsers_CreatedByUserId",
                table: "EventRegistration");

            migrationBuilder.DropForeignKey(
                name: "FK_EventRegistration_AspNetUsers_LastModifiedByUserId",
                table: "EventRegistration");

            migrationBuilder.DropForeignKey(
                name: "FK_EventRegistration_Event_EventId",
                table: "EventRegistration");

            migrationBuilder.DropForeignKey(
                name: "FK_EventRegistration_Student_StudentId",
                table: "EventRegistration");

            migrationBuilder.DropForeignKey(
                name: "FK_Student_AspNetUsers_CreatedByUserId",
                table: "Student");

            migrationBuilder.DropForeignKey(
                name: "FK_Student_AspNetUsers_LastModifiedByUserId",
                table: "Student");

            migrationBuilder.DropForeignKey(
                name: "FK_Student_AspNetUsers_UserId",
                table: "Student");

            migrationBuilder.DropForeignKey(
                name: "FK_UniversityUnit_AspNetUsers_CreatedByUserId",
                table: "UniversityUnit");

            migrationBuilder.DropForeignKey(
                name: "FK_UniversityUnit_AspNetUsers_LastModifiedByUserId",
                table: "UniversityUnit");

            migrationBuilder.DropForeignKey(
                name: "FK_UniversityUnit_AspNetUsers_UserId",
                table: "UniversityUnit");

            migrationBuilder.RenameTable(
                name: "UniversityUnit",
                newName: "UniversityUnits");

            migrationBuilder.RenameTable(
                name: "Student",
                newName: "Students");

            migrationBuilder.RenameTable(
                name: "EventRegistration",
                newName: "EventRegistrations");

            migrationBuilder.RenameTable(
                name: "EventImage",
                newName: "EventImages");

            migrationBuilder.RenameTable(
                name: "Event",
                newName: "Events");

            migrationBuilder.RenameIndex(
                name: "IX_UniversityUnit_UserId",
                table: "UniversityUnits",
                newName: "IX_UniversityUnits_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UniversityUnit_LastModifiedByUserId",
                table: "UniversityUnits",
                newName: "IX_UniversityUnits_LastModifiedByUserId");

            migrationBuilder.RenameIndex(
                name: "IX_UniversityUnit_CreatedByUserId",
                table: "UniversityUnits",
                newName: "IX_UniversityUnits_CreatedByUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Student_UserId",
                table: "Students",
                newName: "IX_Students_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Student_StudentCode",
                table: "Students",
                newName: "IX_Students_StudentCode");

            migrationBuilder.RenameIndex(
                name: "IX_Student_LastModifiedByUserId",
                table: "Students",
                newName: "IX_Students_LastModifiedByUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Student_CreatedByUserId",
                table: "Students",
                newName: "IX_Students_CreatedByUserId");

            migrationBuilder.RenameIndex(
                name: "IX_EventRegistration_StudentId",
                table: "EventRegistrations",
                newName: "IX_EventRegistrations_StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_EventRegistration_LastModifiedByUserId",
                table: "EventRegistrations",
                newName: "IX_EventRegistrations_LastModifiedByUserId");

            migrationBuilder.RenameIndex(
                name: "IX_EventRegistration_EventId",
                table: "EventRegistrations",
                newName: "IX_EventRegistrations_EventId");

            migrationBuilder.RenameIndex(
                name: "IX_EventRegistration_CreatedByUserId",
                table: "EventRegistrations",
                newName: "IX_EventRegistrations_CreatedByUserId");

            migrationBuilder.RenameIndex(
                name: "IX_EventImage_EventId",
                table: "EventImages",
                newName: "IX_EventImages_EventId");

            migrationBuilder.RenameIndex(
                name: "IX_Event_UniversityUnitId",
                table: "Events",
                newName: "IX_Events_UniversityUnitId");

            migrationBuilder.RenameIndex(
                name: "IX_Event_LastModifiedByUserId",
                table: "Events",
                newName: "IX_Events_LastModifiedByUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Event_CreatedByUserId",
                table: "Events",
                newName: "IX_Events_CreatedByUserId");

            migrationBuilder.AddCheckConstraint(
                name: "CK_EventRegistration_AttendedDate_GreaterThan_RegistrationDate",
                table: "EventRegistrations",
                sql: "AttendedDate IS NULL OR RegisterDate IS NULL OR AttendedDate >= RegisterDate");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Students_StudentId",
                table: "AspNetUsers",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_UniversityUnits_UniversityUnitId",
                table: "AspNetUsers",
                column: "UniversityUnitId",
                principalTable: "UniversityUnits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EventImages_Events_EventId",
                table: "EventImages",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EventRegistrations_AspNetUsers_CreatedByUserId",
                table: "EventRegistrations",
                column: "CreatedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EventRegistrations_AspNetUsers_LastModifiedByUserId",
                table: "EventRegistrations",
                column: "LastModifiedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EventRegistrations_Events_EventId",
                table: "EventRegistrations",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EventRegistrations_Students_StudentId",
                table: "EventRegistrations",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Events_AspNetUsers_CreatedByUserId",
                table: "Events",
                column: "CreatedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Events_AspNetUsers_LastModifiedByUserId",
                table: "Events",
                column: "LastModifiedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Events_UniversityUnits_UniversityUnitId",
                table: "Events",
                column: "UniversityUnitId",
                principalTable: "UniversityUnits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_AspNetUsers_CreatedByUserId",
                table: "Students",
                column: "CreatedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_AspNetUsers_LastModifiedByUserId",
                table: "Students",
                column: "LastModifiedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_AspNetUsers_UserId",
                table: "Students",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UniversityUnits_AspNetUsers_CreatedByUserId",
                table: "UniversityUnits",
                column: "CreatedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UniversityUnits_AspNetUsers_LastModifiedByUserId",
                table: "UniversityUnits",
                column: "LastModifiedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UniversityUnits_AspNetUsers_UserId",
                table: "UniversityUnits",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Students_StudentId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_UniversityUnits_UniversityUnitId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_EventImages_Events_EventId",
                table: "EventImages");

            migrationBuilder.DropForeignKey(
                name: "FK_EventRegistrations_AspNetUsers_CreatedByUserId",
                table: "EventRegistrations");

            migrationBuilder.DropForeignKey(
                name: "FK_EventRegistrations_AspNetUsers_LastModifiedByUserId",
                table: "EventRegistrations");

            migrationBuilder.DropForeignKey(
                name: "FK_EventRegistrations_Events_EventId",
                table: "EventRegistrations");

            migrationBuilder.DropForeignKey(
                name: "FK_EventRegistrations_Students_StudentId",
                table: "EventRegistrations");

            migrationBuilder.DropForeignKey(
                name: "FK_Events_AspNetUsers_CreatedByUserId",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_Events_AspNetUsers_LastModifiedByUserId",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_Events_UniversityUnits_UniversityUnitId",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_AspNetUsers_CreatedByUserId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_AspNetUsers_LastModifiedByUserId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_AspNetUsers_UserId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_UniversityUnits_AspNetUsers_CreatedByUserId",
                table: "UniversityUnits");

            migrationBuilder.DropForeignKey(
                name: "FK_UniversityUnits_AspNetUsers_LastModifiedByUserId",
                table: "UniversityUnits");

            migrationBuilder.DropForeignKey(
                name: "FK_UniversityUnits_AspNetUsers_UserId",
                table: "UniversityUnits");

            migrationBuilder.DropCheckConstraint(
                name: "CK_EventRegistration_AttendedDate_GreaterThan_RegistrationDate",
                table: "EventRegistrations");

            migrationBuilder.RenameTable(
                name: "UniversityUnits",
                newName: "UniversityUnit");

            migrationBuilder.RenameTable(
                name: "Students",
                newName: "Student");

            migrationBuilder.RenameTable(
                name: "Events",
                newName: "Event");

            migrationBuilder.RenameTable(
                name: "EventRegistrations",
                newName: "EventRegistration");

            migrationBuilder.RenameTable(
                name: "EventImages",
                newName: "EventImage");

            migrationBuilder.RenameIndex(
                name: "IX_UniversityUnits_UserId",
                table: "UniversityUnit",
                newName: "IX_UniversityUnit_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UniversityUnits_LastModifiedByUserId",
                table: "UniversityUnit",
                newName: "IX_UniversityUnit_LastModifiedByUserId");

            migrationBuilder.RenameIndex(
                name: "IX_UniversityUnits_CreatedByUserId",
                table: "UniversityUnit",
                newName: "IX_UniversityUnit_CreatedByUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Students_UserId",
                table: "Student",
                newName: "IX_Student_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Students_StudentCode",
                table: "Student",
                newName: "IX_Student_StudentCode");

            migrationBuilder.RenameIndex(
                name: "IX_Students_LastModifiedByUserId",
                table: "Student",
                newName: "IX_Student_LastModifiedByUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Students_CreatedByUserId",
                table: "Student",
                newName: "IX_Student_CreatedByUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Events_UniversityUnitId",
                table: "Event",
                newName: "IX_Event_UniversityUnitId");

            migrationBuilder.RenameIndex(
                name: "IX_Events_LastModifiedByUserId",
                table: "Event",
                newName: "IX_Event_LastModifiedByUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Events_CreatedByUserId",
                table: "Event",
                newName: "IX_Event_CreatedByUserId");

            migrationBuilder.RenameIndex(
                name: "IX_EventRegistrations_StudentId",
                table: "EventRegistration",
                newName: "IX_EventRegistration_StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_EventRegistrations_LastModifiedByUserId",
                table: "EventRegistration",
                newName: "IX_EventRegistration_LastModifiedByUserId");

            migrationBuilder.RenameIndex(
                name: "IX_EventRegistrations_EventId",
                table: "EventRegistration",
                newName: "IX_EventRegistration_EventId");

            migrationBuilder.RenameIndex(
                name: "IX_EventRegistrations_CreatedByUserId",
                table: "EventRegistration",
                newName: "IX_EventRegistration_CreatedByUserId");

            migrationBuilder.RenameIndex(
                name: "IX_EventImages_EventId",
                table: "EventImage",
                newName: "IX_EventImage_EventId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Student_StudentId",
                table: "AspNetUsers",
                column: "StudentId",
                principalTable: "Student",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_UniversityUnit_UniversityUnitId",
                table: "AspNetUsers",
                column: "UniversityUnitId",
                principalTable: "UniversityUnit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Event_AspNetUsers_CreatedByUserId",
                table: "Event",
                column: "CreatedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Event_AspNetUsers_LastModifiedByUserId",
                table: "Event",
                column: "LastModifiedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Event_UniversityUnit_UniversityUnitId",
                table: "Event",
                column: "UniversityUnitId",
                principalTable: "UniversityUnit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EventImage_Event_EventId",
                table: "EventImage",
                column: "EventId",
                principalTable: "Event",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EventRegistration_AspNetUsers_CreatedByUserId",
                table: "EventRegistration",
                column: "CreatedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EventRegistration_AspNetUsers_LastModifiedByUserId",
                table: "EventRegistration",
                column: "LastModifiedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EventRegistration_Event_EventId",
                table: "EventRegistration",
                column: "EventId",
                principalTable: "Event",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EventRegistration_Student_StudentId",
                table: "EventRegistration",
                column: "StudentId",
                principalTable: "Student",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Student_AspNetUsers_CreatedByUserId",
                table: "Student",
                column: "CreatedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Student_AspNetUsers_LastModifiedByUserId",
                table: "Student",
                column: "LastModifiedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Student_AspNetUsers_UserId",
                table: "Student",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UniversityUnit_AspNetUsers_CreatedByUserId",
                table: "UniversityUnit",
                column: "CreatedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UniversityUnit_AspNetUsers_LastModifiedByUserId",
                table: "UniversityUnit",
                column: "LastModifiedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UniversityUnit_AspNetUsers_UserId",
                table: "UniversityUnit",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
