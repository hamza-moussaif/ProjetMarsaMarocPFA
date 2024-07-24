using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectPFA.Migrations
{
    public partial class _9nd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "70df6eb4-fd32-43a7-988c-a9bdda69cded");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e416009f-d2ab-409c-a053-11bfd10236b6");

            migrationBuilder.AlterColumn<byte[]>(
                name: "Image",
                table: "Engins",
                type: "varbinary(max)",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)");

            migrationBuilder.AlterColumn<int>(
                name: "BCI",
                table: "Engins",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0c42266f-b617-4342-b396-4b0ad40d055f", "55f483ac-7d9f-4e71-b225-6f1b1db89564", "Demandeur", "DEMANDEUR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "87cd754e-6b84-451f-b056-94ea7e189dfd", "1c8c80fb-ce86-4635-9a88-c5d2b1a23633", "Assistant", "ASSISTANT" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0c42266f-b617-4342-b396-4b0ad40d055f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "87cd754e-6b84-451f-b056-94ea7e189dfd");

            migrationBuilder.AlterColumn<byte[]>(
                name: "Image",
                table: "Engins",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0],
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BCI",
                table: "Engins",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "70df6eb4-fd32-43a7-988c-a9bdda69cded", "268cfbe7-1d24-4f79-8fee-e3b87007a551", "Demandeur", "DEMANDEUR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e416009f-d2ab-409c-a053-11bfd10236b6", "3ae48a93-54d6-40d2-b247-27bf45bb2934", "Assistant", "ASSISTANT" });
        }
    }
}
