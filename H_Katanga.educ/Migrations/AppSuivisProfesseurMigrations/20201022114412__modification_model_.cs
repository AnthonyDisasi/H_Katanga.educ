using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace H_Katanga.educ.Migrations.AppSuivisProfesseurMigrations
{
    public partial class _modification_model_ : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CotationProfesseurs_Lecons_LeconID",
                table: "CotationProfesseurs");

            migrationBuilder.DropIndex(
                name: "IX_CotationProfesseurs_LeconID",
                table: "CotationProfesseurs");

            migrationBuilder.DropColumn(
                name: "MatriculeInspecteur",
                table: "CotationProfesseurs");

            migrationBuilder.AlterColumn<string>(
                name: "ID",
                table: "Lecons",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<string>(
                name: "LeconID",
                table: "CotationProfesseurs",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "ID",
                table: "CotationProfesseurs",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.CreateIndex(
                name: "IX_CotationProfesseurs_LeconID",
                table: "CotationProfesseurs",
                column: "LeconID",
                unique: true,
                filter: "[LeconID] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_CotationProfesseurs_Lecons_LeconID",
                table: "CotationProfesseurs",
                column: "LeconID",
                principalTable: "Lecons",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CotationProfesseurs_Lecons_LeconID",
                table: "CotationProfesseurs");

            migrationBuilder.DropIndex(
                name: "IX_CotationProfesseurs_LeconID",
                table: "CotationProfesseurs");

            migrationBuilder.AlterColumn<int>(
                name: "ID",
                table: "Lecons",
                nullable: false,
                oldClrType: typeof(string))
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<int>(
                name: "LeconID",
                table: "CotationProfesseurs",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ID",
                table: "CotationProfesseurs",
                nullable: false,
                oldClrType: typeof(string))
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<int>(
                name: "MatriculeInspecteur",
                table: "CotationProfesseurs",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_CotationProfesseurs_LeconID",
                table: "CotationProfesseurs",
                column: "LeconID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CotationProfesseurs_Lecons_LeconID",
                table: "CotationProfesseurs",
                column: "LeconID",
                principalTable: "Lecons",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
