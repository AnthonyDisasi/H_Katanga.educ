using Microsoft.EntityFrameworkCore.Migrations;

namespace H_Katanga.educ.Migrations.AppEvaluationMigrations
{
    public partial class _modification_model_ : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Examens",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    IdentifiantClasse = table.Column<string>(nullable: true),
                    Titre = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    CodeAcces = table.Column<string>(nullable: true),
                    Serie = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Examens", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Series",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    Nom = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Series", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    Enoncer = table.Column<string>(nullable: true),
                    Solution = table.Column<string>(nullable: true),
                    ExamenID = table.Column<string>(nullable: true),
                    ExamenID1 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Questions_Examens_ExamenID",
                        column: x => x.ExamenID,
                        principalTable: "Examens",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Questions_Examens_ExamenID1",
                        column: x => x.ExamenID1,
                        principalTable: "Examens",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Assertions",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    QuestionID = table.Column<string>(nullable: true),
                    reponse = table.Column<string>(nullable: true),
                    Point = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assertions", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Assertions_Questions_QuestionID",
                        column: x => x.QuestionID,
                        principalTable: "Questions",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Assertions_QuestionID",
                table: "Assertions",
                column: "QuestionID");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_ExamenID",
                table: "Questions",
                column: "ExamenID");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_ExamenID1",
                table: "Questions",
                column: "ExamenID1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Assertions");

            migrationBuilder.DropTable(
                name: "Series");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "Examens");
        }
    }
}
