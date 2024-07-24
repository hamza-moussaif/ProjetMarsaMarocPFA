using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectPFA.Migrations
{
    public partial class _4nd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Affectations_Engins_enginId",
                table: "Affectations");

            migrationBuilder.DropIndex(
                name: "IX_Affectations_enginId",
                table: "Affectations");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c4d3151e-756f-46f1-a2b7-44adc80ae086");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ee1bf092-def9-434c-9711-98d7da67c4b8");

            migrationBuilder.DropColumn(
                name: "enginId",
                table: "Affectations");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b7bdab1c-348e-4a45-b14d-36de13f2a09f", "e86b44a2-27fc-4b43-83b8-6bbdbe2f8958", "Demandeur", "DEMANDEUR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f4644dd8-f201-4d37-bfc0-51bb7b8f4bd6", "de9fd5b5-05d7-469e-8c05-e56c8b679aed", "Assistant", "ASSISTANT" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b7bdab1c-348e-4a45-b14d-36de13f2a09f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f4644dd8-f201-4d37-bfc0-51bb7b8f4bd6");

            migrationBuilder.AddColumn<Guid>(
                name: "enginId",
                table: "Affectations",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c4d3151e-756f-46f1-a2b7-44adc80ae086", "a5270091-fa93-4e5b-bd59-755700f170a5", "Demandeur", "DEMANDEUR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ee1bf092-def9-434c-9711-98d7da67c4b8", "00cc7b43-e80d-48c5-83b6-42abe30705c5", "Assistant", "ASSISTANT" });

            migrationBuilder.CreateIndex(
                name: "IX_Affectations_enginId",
                table: "Affectations",
                column: "enginId");

            migrationBuilder.AddForeignKey(
                name: "FK_Affectations_Engins_enginId",
                table: "Affectations",
                column: "enginId",
                principalTable: "Engins",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
