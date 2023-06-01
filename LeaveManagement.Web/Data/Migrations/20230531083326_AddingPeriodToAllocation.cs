using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddingPeriodToAllocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "05b97550-0149-4a62-8c0b-6558d6855cd4", "AQAAAAEAACcQAAAAEBhBT24SDSE6jSUtFpbn0batIBNpuIMD0WLpdiSfGmkMFnMmZXjfYElHTN/2DLswOQ==", "52a83323-2436-4efd-b136-9c6776db1844", "admin@local.test" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d0cfcdff-acb8-4245-b492-f983d89e40c0",
                column: "ConcurrencyStamp",
                value: "82630f13-cc19-49f4-b31c-11b9a9d2bf31");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d0cfcdff-acb8-s245-a492-f983d89e40c0",
                column: "ConcurrencyStamp",
                value: "932e8b36-fdf8-4baf-b4ea-228740d81acf");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d0cfcdff-acb8-424a-b498-f983d89e40c0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "31a0c8ae-d560-4e27-8185-2e3c68ef9a4e", "AQAAAAEAACcQAAAAEKLAnjQrhsOs2WgwNXU7yTlotC+S1xap3pzW3nzn6CxB3VTYqG3YALTeOGP82wBy9Q==", "6fa76f96-3dd2-4c13-a7aa-b0eb0c3bd087", "ADMIN@LOCAL.TEST" });
        }
    }
}
