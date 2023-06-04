using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedLeaveRequestTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LeaveRequest",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeaveTypeId = table.Column<int>(type: "int", nullable: false),
                    DateRequested = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestComments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Approved = table.Column<bool>(type: "bit", nullable: true),
                    Cancelled = table.Column<bool>(type: "bit", nullable: false),
                    RequestingEmployeeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveRequest", x => x.id);
                    table.ForeignKey(
                        name: "FK_LeaveRequest_LeaveTypes_LeaveTypeId",
                        column: x => x.LeaveTypeId,
                        principalTable: "LeaveTypes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d0cfcdff-acb8-4245-b492-f983d89e40c0",
                column: "ConcurrencyStamp",
                value: "57019dc0-fa45-4096-b20e-a706a67b5054");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d0cfcdff-acb8-s245-a492-f983d89e40c0",
                column: "ConcurrencyStamp",
                value: "ca7b39ab-241a-44bb-b74a-1fb46e2719bd");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "d0cfcdff-acb8-s245-a492-f983d89e40c0", "d0cfcdff-acb8-424a-b498-f983d89e40c0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d0cfcdff-acb8-424a-b498-f983d89e40c0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7becb8d3-e283-4b07-90f6-d5a745dd3f47", "AQAAAAEAACcQAAAAEFX+Ic7o/4jvhBBvDFgeedEkCtuxOW3bKw8pelqd7HgspTYsBywiciBi53tHMrYb3A==", "e3207719-d675-4e01-8bfc-0d09cb96ea7f" });

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequest_LeaveTypeId",
                table: "LeaveRequest",
                column: "LeaveTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeaveRequest");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d0cfcdff-acb8-s245-a492-f983d89e40c0", "d0cfcdff-acb8-424a-b498-f983d89e40c0" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d0cfcdff-acb8-4245-b492-f983d89e40c0",
                column: "ConcurrencyStamp",
                value: "97b5bfc4-c0d3-48b7-889b-43bb860948c5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d0cfcdff-acb8-s245-a492-f983d89e40c0",
                column: "ConcurrencyStamp",
                value: "00eb622b-1d72-488e-b9a6-cd0984d0a613");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d0cfcdff-acb8-424a-b498-f983d89e40c0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "05b97550-0149-4a62-8c0b-6558d6855cd4", "AQAAAAEAACcQAAAAEBhBT24SDSE6jSUtFpbn0batIBNpuIMD0WLpdiSfGmkMFnMmZXjfYElHTN/2DLswOQ==", "52a83323-2436-4efd-b136-9c6776db1844" });
        }
    }
}
