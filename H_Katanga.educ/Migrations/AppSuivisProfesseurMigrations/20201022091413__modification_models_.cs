using Microsoft.EntityFrameworkCore.Migrations;

namespace H_Katanga.educ.Migrations.AppSuivisProfesseurMigrations
{
    public partial class _modification_models_ : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CotationProfesseurs_Inspecteurs_InspecteurID1",
                table: "CotationProfesseurs");

            migrationBuilder.DropIndex(
                name: "IX_CotationProfesseurs_InspecteurID1",
                table: "CotationProfesseurs");

            migrationBuilder.DropColumn(
                name: "InspecteurID1",
                table: "CotationProfesseurs");

            migrationBuilder.RenameColumn(
                name: "Matricule",
                table: "Lecons",
                newName: "MatriculeProfesseur");

            migrationBuilder.AlterColumn<string>(
                name: "InspecteurID",
                table: "CotationProfesseurs",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "MatriculeInspecteur",
                table: "CotationProfesseurs",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_CotationProfesseurs_InspecteurID",
                table: "CotationProfesseurs",
                column: "InspecteurID");

            migrationBuilder.AddForeignKey(
                name: "FK_CotationProfesseurs_Inspecteurs_InspecteurID",
                table: "CotationProfesseurs",
                column: "InspecteurID",
                principalTable: "Inspecteurs",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CotationProfesseurs_Inspecteurs_InspecteurID",
                table: "CotationProfesseurs");

            migrationBuilder.DropIndex(
                name: "IX_CotationProfesseurs_InspecteurID",
                table: "CotationProfesseurs");

            migrationBuilder.DropColumn(
                name: "MatriculeInspecteur",
                table: "CotationProfesseurs");

            migrationBuilder.RenameColumn(
                name: "MatriculeProfesseur",
                table: "Lecons",
                newName: "Matricule");

            migrationBuilder.AlterColumn<int>(
                name: "InspecteurID",
                table: "CotationProfesseurs",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InspecteurID1",
                table: "CotationProfesseurs",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CotationProfesseurs_InspecteurID1",
                table: "CotationProfesseurs",
                column: "InspecteurID1");

            migrationBuilder.AddForeignKey(
                name: "FK_CotationProfesseurs_Inspecteurs_InspecteurID1",
                table: "CotationProfesseurs",
                column: "InspecteurID1",
                principalTable: "Inspecteurs",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
