using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace H_Katanga.educ.Migrations.AppPerformanceEleveMigrations
{
    public partial class _modification_models_ : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Epreuves",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    IdentifiantCours = table.Column<string>(nullable: true),
                    IdentifiantClasse = table.Column<string>(nullable: true),
                    MAtriculeEleve = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Total = table.Column<int>(nullable: false),
                    Cote = table.Column<double>(nullable: false),
                    DateEpreuve = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Epreuves", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Epreuves");
        }
    }
}
