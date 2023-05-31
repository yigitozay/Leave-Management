using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedDefaultUsersAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "LeaveTypes",
                newName: "id");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d0cfcdff-acb8-4245-b492-f983d89e40c0", "662f2cd8-8f40-45c5-bb65-0e0ff645994a", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d0cfcdff-acb8-s245-a492-f983d89e40c0", "2f39ca7b-4679-496d-ba9c-4114ad90ca0c", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[] { "d0cfcdff-acb8-424a-b498-f983d89e40c0", 0, "b8a581de-65f2-450d-9533-c9dae1399c1c", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@local.test", false, "admin", "test", false, null, "ADMIN@LOCAL.TEST", null, "AQAAAAEAACcQAAAAEETBHosZJMUYCrPuvE/B8mGwzXv6pxqkTSreRO9zAw6aA6IgLG9llDDKwWRljWZ9Pg==", null, false, "e46705f1-9932-4f88-8113-099aa915c826", null, false, null });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "d0cfcdff-acb8-4245-b492-f983d89e40c0", "d0cfcdff-acb8-424a-b498-f983d89e40c0" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d0cfcdff-acb8-s245-a492-f983d89e40c0");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d0cfcdff-acb8-4245-b492-f983d89e40c0", "d0cfcdff-acb8-424a-b498-f983d89e40c0" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d0cfcdff-acb8-4245-b492-f983d89e40c0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d0cfcdff-acb8-424a-b498-f983d89e40c0");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "LeaveTypes",
                newName: "Id");
        }
    }
}
