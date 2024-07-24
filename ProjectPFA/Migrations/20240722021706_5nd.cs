using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectPFA.Migrations
{
    public partial class _5nd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b7bdab1c-348e-4a45-b14d-36de13f2a09f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f4644dd8-f201-4d37-bfc0-51bb7b8f4bd6");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5a66dea1-64bb-44c9-bf6d-46fdbbaa05eb", "ef77a761-b9c5-45ea-9a1c-21070132e90d", "Demandeur", "DEMANDEUR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "82e34fe5-edd1-4c9b-b0dd-bf5ed2811db7", "52f7d27c-eb67-4236-ab97-652b0e72b9a0", "Assistant", "ASSISTANT" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5a66dea1-64bb-44c9-bf6d-46fdbbaa05eb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "82e34fe5-edd1-4c9b-b0dd-bf5ed2811db7");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b7bdab1c-348e-4a45-b14d-36de13f2a09f", "e86b44a2-27fc-4b43-83b8-6bbdbe2f8958", "Demandeur", "DEMANDEUR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f4644dd8-f201-4d37-bfc0-51bb7b8f4bd6", "de9fd5b5-05d7-469e-8c05-e56c8b679aed", "Assistant", "ASSISTANT" });
        }
    }
}
