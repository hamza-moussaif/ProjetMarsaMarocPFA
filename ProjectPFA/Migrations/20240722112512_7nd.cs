using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectPFA.Migrations
{
    public partial class _7nd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Engins_Etat_etatId",
                table: "Engins");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e6fd64f6-fd55-44e6-82a6-f29e6e8a634e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ebde4bb4-2081-4acd-bed5-6a9ba8712ab9");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Engins",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "etatId",
                table: "Engins",
                newName: "EtatId");

            migrationBuilder.RenameIndex(
                name: "IX_Engins_etatId",
                table: "Engins",
                newName: "IX_Engins_EtatId");

            migrationBuilder.AddColumn<byte[]>(
                name: "Image",
                table: "Engins",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "70df6eb4-fd32-43a7-988c-a9bdda69cded", "268cfbe7-1d24-4f79-8fee-e3b87007a551", "Demandeur", "DEMANDEUR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e416009f-d2ab-409c-a053-11bfd10236b6", "3ae48a93-54d6-40d2-b247-27bf45bb2934", "Assistant", "ASSISTANT" });

            migrationBuilder.AddForeignKey(
                name: "FK_Engins_Etat_EtatId",
                table: "Engins",
                column: "EtatId",
                principalTable: "Etat",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Engins_Etat_EtatId",
                table: "Engins");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "70df6eb4-fd32-43a7-988c-a9bdda69cded");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e416009f-d2ab-409c-a053-11bfd10236b6");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Engins");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Engins",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "EtatId",
                table: "Engins",
                newName: "etatId");

            migrationBuilder.RenameIndex(
                name: "IX_Engins_EtatId",
                table: "Engins",
                newName: "IX_Engins_etatId");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e6fd64f6-fd55-44e6-82a6-f29e6e8a634e", "d26ac6bc-75ae-4efc-bd9d-f217e7e12834", "Demandeur", "DEMANDEUR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ebde4bb4-2081-4acd-bed5-6a9ba8712ab9", "a019afdf-70de-4c7a-a0ca-23dc556cadbe", "Assistant", "ASSISTANT" });

            migrationBuilder.AddForeignKey(
                name: "FK_Engins_Etat_etatId",
                table: "Engins",
                column: "etatId",
                principalTable: "Etat",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
