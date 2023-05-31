using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedDefaultUserUsernames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "31a0c8ae-d560-4e27-8185-2e3c68ef9a4e", true, "ADMIN@LOCAL.TEST", "AQAAAAEAACcQAAAAEKLAnjQrhsOs2WgwNXU7yTlotC+S1xap3pzW3nzn6CxB3VTYqG3YALTeOGP82wBy9Q==", "6fa76f96-3dd2-4c13-a7aa-b0eb0c3bd087", "ADMIN@LOCAL.TEST" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d0cfcdff-acb8-4245-b492-f983d89e40c0",
                column: "ConcurrencyStamp",
                value: "662f2cd8-8f40-45c5-bb65-0e0ff645994a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d0cfcdff-acb8-s245-a492-f983d89e40c0",
                column: "ConcurrencyStamp",
                value: "2f39ca7b-4679-496d-ba9c-4114ad90ca0c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d0cfcdff-acb8-424a-b498-f983d89e40c0",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "b8a581de-65f2-450d-9533-c9dae1399c1c", false, null, "AQAAAAEAACcQAAAAEETBHosZJMUYCrPuvE/B8mGwzXv6pxqkTSreRO9zAw6aA6IgLG9llDDKwWRljWZ9Pg==", "e46705f1-9932-4f88-8113-099aa915c826", null });
        }
    }
}
