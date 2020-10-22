using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace H_Katanga.educ.Migrations.AppSuivisProfesseurMigrations
{
    public partial class _modification_model_3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Inspecteurs",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    Nom = table.Column<string>(nullable: false),
                    Postnom = table.Column<string>(nullable: false),
                    Prenom = table.Column<string>(nullable: false),
                    Genre = table.Column<int>(nullable: true),
                    Matricule = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    DateNaissance = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inspecteurs", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Lecons",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    IdentifiantCours = table.Column<string>(nullable: true),
                    MatriculeProfesseur = table.Column<string>(nullable: true),
                    DateLecon = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lecons", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CotationProfesseurs",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    LeconID = table.Column<string>(nullable: true),
                    InspecteurID = table.Column<string>(nullable: true),
                    Total = table.Column<int>(nullable: false),
                    Cote = table.Column<double>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CotationProfesseurs", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CotationProfesseurs_Inspecteurs_InspecteurID",
                        column: x => x.InspecteurID,
                        principalTable: "Inspecteurs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CotationProfesseurs_Lecons_LeconID",
                        column: x => x.LeconID,
                        principalTable: "Lecons",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CotationProfesseurs_InspecteurID",
                table: "CotationProfesseurs",
                column: "InspecteurID");

            migrationBuilder.CreateIndex(
                name: "IX_CotationProfesseurs_LeconID",
                table: "CotationProfesseurs",
                column: "LeconID",
                unique: true,
                filter: "[LeconID] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CotationProfesseurs");

            migrationBuilder.DropTable(
                name: "Inspecteurs");

            migrationBuilder.DropTable(
                name: "Lecons");
        }
    }
}
