using Microsoft.EntityFrameworkCore.Migrations;

namespace H_Katanga.educ.Migrations
{
    public partial class _modification_model_1_ : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Classes_Eleves_EleveID",
                table: "Classes");

            migrationBuilder.DropIndex(
                name: "IX_Classes_EleveID",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "EleveID",
                table: "Classes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EleveID",
                table: "Classes",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Classes_EleveID",
                table: "Classes",
                column: "EleveID");

            migrationBuilder.AddForeignKey(
                name: "FK_Classes_Eleves_EleveID",
                table: "Classes",
                column: "EleveID",
                principalTable: "Eleves",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
