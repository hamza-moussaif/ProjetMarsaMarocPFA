using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectPFA.Migrations
{
    public partial class _3nd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "58049c88-68bb-45b0-b8a7-2ee9dc81308d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "96ef3d55-bceb-4799-846d-21c59e603413");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.CreateTable(
                name: "Etat",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    klaxon = table.Column<bool>(type: "bit", nullable: false),
                    Sallette_Tracteur = table.Column<bool>(type: "bit", nullable: false),
                    Flexible_Air_Tracteur = table.Column<bool>(type: "bit", nullable: false),
                    Extincteur = table.Column<bool>(type: "bit", nullable: false),
                    Verins_Translation_Fourches = table.Column<bool>(type: "bit", nullable: false),
                    Eclairage = table.Column<bool>(type: "bit", nullable: false),
                    gyrophares = table.Column<bool>(type: "bit", nullable: false),
                    Vitres = table.Column<bool>(type: "bit", nullable: false),
                    Carosserie = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Etat", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Engins",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BCI = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    etatId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Engins", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Engins_Etat_etatId",
                        column: x => x.etatId,
                        principalTable: "Etat",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Affectations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prenom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Departement = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Poste = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BCI = table.Column<int>(type: "int", nullable: false),
                    Shift = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateAffectation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateFinAffectation = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Etat = table.Column<bool>(type: "bit", nullable: false),
                    demandeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    enginId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Affectations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Affectations_Demandes_demandeId",
                        column: x => x.demandeId,
                        principalTable: "Demandes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Affectations_Engins_enginId",
                        column: x => x.enginId,
                        principalTable: "Engins",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c4d3151e-756f-46f1-a2b7-44adc80ae086", "a5270091-fa93-4e5b-bd59-755700f170a5", "Demandeur", "DEMANDEUR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ee1bf092-def9-434c-9711-98d7da67c4b8", "00cc7b43-e80d-48c5-83b6-42abe30705c5", "Assistant", "ASSISTANT" });

            migrationBuilder.CreateIndex(
                name: "IX_Affectations_demandeId",
                table: "Affectations",
                column: "demandeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Affectations_enginId",
                table: "Affectations",
                column: "enginId");

            migrationBuilder.CreateIndex(
                name: "IX_Engins_etatId",
                table: "Engins",
                column: "etatId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Affectations");

            migrationBuilder.DropTable(
                name: "Engins");

            migrationBuilder.DropTable(
                name: "Etat");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c4d3151e-756f-46f1-a2b7-44adc80ae086");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ee1bf092-def9-434c-9711-98d7da67c4b8");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "58049c88-68bb-45b0-b8a7-2ee9dc81308d", "5cdd30ae-19ef-44cc-9158-5dcfa9b719ef", "Demandeur", "DEMANDEUR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "96ef3d55-bceb-4799-846d-21c59e603413", "875ce73f-12ca-48c9-aaf4-c3f20a36996d", "Assistant", "ASSISTANT" });
        }
    }
}
