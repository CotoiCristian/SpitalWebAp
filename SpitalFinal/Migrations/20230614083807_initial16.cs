using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SpitalFinal.Migrations
{
    /// <inheritdoc />
    public partial class initial16 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FisaMedics_Medics_MedicId",
                table: "FisaMedics");

            migrationBuilder.AddForeignKey(
                name: "FK_FisaMedics_Medics_MedicId",
                table: "FisaMedics",
                column: "MedicId",
                principalTable: "Medics",
                principalColumn: "MedicId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FisaMedics_Medics_MedicId",
                table: "FisaMedics");

            migrationBuilder.AddForeignKey(
                name: "FK_FisaMedics_Medics_MedicId",
                table: "FisaMedics",
                column: "MedicId",
                principalTable: "Medics",
                principalColumn: "MedicId");
        }
    }
}
