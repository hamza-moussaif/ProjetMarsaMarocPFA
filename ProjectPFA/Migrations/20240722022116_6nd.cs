using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectPFA.Migrations
{
    public partial class _6nd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Affectations_Demandes_demandeId",
                table: "Affectations");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5a66dea1-64bb-44c9-bf6d-46fdbbaa05eb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "82e34fe5-edd1-4c9b-b0dd-bf5ed2811db7");

            migrationBuilder.RenameColumn(
                name: "demandeId",
                table: "Affectations",
                newName: "DemandeId");

            migrationBuilder.RenameIndex(
                name: "IX_Affectations_demandeId",
                table: "Affectations",
                newName: "IX_Affectations_DemandeId");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e6fd64f6-fd55-44e6-82a6-f29e6e8a634e", "d26ac6bc-75ae-4efc-bd9d-f217e7e12834", "Demandeur", "DEMANDEUR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ebde4bb4-2081-4acd-bed5-6a9ba8712ab9", "a019afdf-70de-4c7a-a0ca-23dc556cadbe", "Assistant", "ASSISTANT" });

            migrationBuilder.AddForeignKey(
                name: "FK_Affectations_Demandes_DemandeId",
                table: "Affectations",
                column: "DemandeId",
                principalTable: "Demandes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Affectations_Demandes_DemandeId",
                table: "Affectations");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e6fd64f6-fd55-44e6-82a6-f29e6e8a634e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ebde4bb4-2081-4acd-bed5-6a9ba8712ab9");

            migrationBuilder.RenameColumn(
                name: "DemandeId",
                table: "Affectations",
                newName: "demandeId");

            migrationBuilder.RenameIndex(
                name: "IX_Affectations_DemandeId",
                table: "Affectations",
                newName: "IX_Affectations_demandeId");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5a66dea1-64bb-44c9-bf6d-46fdbbaa05eb", "ef77a761-b9c5-45ea-9a1c-21070132e90d", "Demandeur", "DEMANDEUR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "82e34fe5-edd1-4c9b-b0dd-bf5ed2811db7", "52f7d27c-eb67-4236-ab97-652b0e72b9a0", "Assistant", "ASSISTANT" });

            migrationBuilder.AddForeignKey(
                name: "FK_Affectations_Demandes_demandeId",
                table: "Affectations",
                column: "demandeId",
                principalTable: "Demandes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
