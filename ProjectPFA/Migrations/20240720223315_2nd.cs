using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectPFA.Migrations
{
    public partial class _2nd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "862c73fb-d0ad-46ae-a8fa-cd2694234012");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cfe97db5-2930-44ce-a661-a12556302d43");

            migrationBuilder.AddColumn<string>(
                name: "userId",
                table: "Demandes",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "58049c88-68bb-45b0-b8a7-2ee9dc81308d", "5cdd30ae-19ef-44cc-9158-5dcfa9b719ef", "Demandeur", "DEMANDEUR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "96ef3d55-bceb-4799-846d-21c59e603413", "875ce73f-12ca-48c9-aaf4-c3f20a36996d", "Assistant", "ASSISTANT" });

            migrationBuilder.CreateIndex(
                name: "IX_Demandes_userId",
                table: "Demandes",
                column: "userId");

            migrationBuilder.AddForeignKey(
                name: "FK_Demandes_AspNetUsers_userId",
                table: "Demandes",
                column: "userId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Demandes_AspNetUsers_userId",
                table: "Demandes");

            migrationBuilder.DropIndex(
                name: "IX_Demandes_userId",
                table: "Demandes");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "58049c88-68bb-45b0-b8a7-2ee9dc81308d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "96ef3d55-bceb-4799-846d-21c59e603413");

            migrationBuilder.DropColumn(
                name: "userId",
                table: "Demandes");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "862c73fb-d0ad-46ae-a8fa-cd2694234012", "8a596797-48ef-4bc6-9d33-2c054c7db6a8", "Assistant", "ASSISTANT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cfe97db5-2930-44ce-a661-a12556302d43", "fa843365-1ae2-4532-ab23-5205c22d9f58", "Demandeur", "DEMANDEUR" });
        }
    }
}
