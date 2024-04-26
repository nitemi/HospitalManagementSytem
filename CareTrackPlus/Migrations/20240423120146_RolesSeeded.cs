using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CareTrackPlus.Api.Migrations
{
    /// <inheritdoc />
    public partial class RolesSeeded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "02bf611a-1a0a-4ad3-8884-64f1ebc98729", "4", "Nurse", "Nurse" },
                    { "33ff6e1e-21a5-4134-8608-dace33cfa25c", "6", "Laboratory", "Laboratory" },
                    { "35897d47-42c4-47b1-959c-532b338e5047", "5", "Pharmacy", "Pharmacy" },
                    { "52153bbc-f1b3-4ec4-bd11-f70ee19ebe87", "1", "Admin", "Admin" },
                    { "689e2fa8-2f58-4859-a6b2-21702023de4d", "3", "Doctor", "Doctor" },
                    { "b5d168ea-ed9b-4fa9-a3fe-cc265342d485", "2", "Reception", "Reception" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "02bf611a-1a0a-4ad3-8884-64f1ebc98729");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "33ff6e1e-21a5-4134-8608-dace33cfa25c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "35897d47-42c4-47b1-959c-532b338e5047");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "52153bbc-f1b3-4ec4-bd11-f70ee19ebe87");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "689e2fa8-2f58-4859-a6b2-21702023de4d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b5d168ea-ed9b-4fa9-a3fe-cc265342d485");
        }
    }
}
