using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class UpdatedRequestComments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequest",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequest",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d0cfcdff-acb8-424a-b498-f983d89e40c0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7becb8d3-e283-4b07-90f6-d5a745dd3f47", "AQAAAAEAACcQAAAAEFX+Ic7o/4jvhBBvDFgeedEkCtuxOW3bKw8pelqd7HgspTYsBywiciBi53tHMrYb3A==", "e3207719-d675-4e01-8bfc-0d09cb96ea7f" });
        }
    }
}
