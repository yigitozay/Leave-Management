using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class afsg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LeaveRequest_LeaveTypes_LeaveTypeId",
                table: "LeaveRequest");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LeaveRequest",
                table: "LeaveRequest");

            migrationBuilder.RenameTable(
                name: "LeaveRequest",
                newName: "LeaveRequests");

            migrationBuilder.RenameIndex(
                name: "IX_LeaveRequest_LeaveTypeId",
                table: "LeaveRequests",
                newName: "IX_LeaveRequests_LeaveTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LeaveRequests",
                table: "LeaveRequests",
                column: "id");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d0cfcdff-acb8-4245-b492-f983d89e40c0",
                column: "ConcurrencyStamp",
                value: "65c190e8-2616-4466-b72d-fd76f896b2ee");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d0cfcdff-acb8-s245-a492-f983d89e40c0",
                column: "ConcurrencyStamp",
                value: "224e7d15-bb1e-49db-8cce-dfa0f3e651df");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d0cfcdff-acb8-424a-b498-f983d89e40c0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "87dd09f2-f555-48c4-9d9a-354d89383377", "AQAAAAEAACcQAAAAEDo577dNyL05QZYBIlmxASGzh2GTPkN0aNF+Me5/mMI4PZk4x3S/lQ/GTEcmbYyJPA==", "c66c4b1f-2401-4460-beb9-ccc215f12b60" });

            migrationBuilder.AddForeignKey(
                name: "FK_LeaveRequests_LeaveTypes_LeaveTypeId",
                table: "LeaveRequests",
                column: "LeaveTypeId",
                principalTable: "LeaveTypes",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LeaveRequests_LeaveTypes_LeaveTypeId",
                table: "LeaveRequests");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LeaveRequests",
                table: "LeaveRequests");

            migrationBuilder.RenameTable(
                name: "LeaveRequests",
                newName: "LeaveRequest");

            migrationBuilder.RenameIndex(
                name: "IX_LeaveRequests_LeaveTypeId",
                table: "LeaveRequest",
                newName: "IX_LeaveRequest_LeaveTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LeaveRequest",
                table: "LeaveRequest",
                column: "id");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d0cfcdff-acb8-4245-b492-f983d89e40c0",
                column: "ConcurrencyStamp",
                value: "3b8d88fe-3fbf-44c5-9ba1-a3ac72f58266");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d0cfcdff-acb8-s245-a492-f983d89e40c0",
                column: "ConcurrencyStamp",
                value: "a90dd236-b94e-423a-b1db-7009ac7f5ca0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d0cfcdff-acb8-424a-b498-f983d89e40c0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "acbbc0aa-9820-4d44-becf-8e5de965eafa", "AQAAAAEAACcQAAAAEJnJyINDM4Jdf+INQzDhvJTcOByjnV42tYcoUcaGHSstJwZ/fZsycsIDn0t3NByw2A==", "fe4dcd1a-4112-429b-832f-25790882c313" });

            migrationBuilder.AddForeignKey(
                name: "FK_LeaveRequest_LeaveTypes_LeaveTypeId",
                table: "LeaveRequest",
                column: "LeaveTypeId",
                principalTable: "LeaveTypes",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
