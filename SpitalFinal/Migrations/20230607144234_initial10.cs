using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SpitalFinal.Migrations
{
    /// <inheritdoc />
    public partial class initial10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FisaMedics_Medics_MedicId",
                table: "FisaMedics");

            migrationBuilder.AlterColumn<int>(
                name: "MedicId",
                table: "FisaMedics",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataExternare",
                table: "FisaMedics",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_FisaMedics_Medics_MedicId",
                table: "FisaMedics",
                column: "MedicId",
                principalTable: "Medics",
                principalColumn: "MedicId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FisaMedics_Medics_MedicId",
                table: "FisaMedics");

            migrationBuilder.AlterColumn<int>(
                name: "MedicId",
                table: "FisaMedics",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataExternare",
                table: "FisaMedics",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddForeignKey(
                name: "FK_FisaMedics_Medics_MedicId",
                table: "FisaMedics",
                column: "MedicId",
                principalTable: "Medics",
                principalColumn: "MedicId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
