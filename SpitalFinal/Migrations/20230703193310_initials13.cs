using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SpitalFinal.Migrations
{
    /// <inheritdoc />
    public partial class initials13 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FisaMedics_RetetaMedicalas_RetetaMedicalaId",
                table: "FisaMedics");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RetetaMedicalas",
                table: "RetetaMedicalas");

            migrationBuilder.RenameTable(
                name: "RetetaMedicalas",
                newName: "RetetaMedicals");

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

            migrationBuilder.AddPrimaryKey(
                name: "PK_RetetaMedicals",
                table: "RetetaMedicals",
                column: "RetetaMedicalaId");

            migrationBuilder.AddForeignKey(
                name: "FK_FisaMedics_RetetaMedicals_RetetaMedicalaId",
                table: "FisaMedics",
                column: "RetetaMedicalaId",
                principalTable: "RetetaMedicals",
                principalColumn: "RetetaMedicalaId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FisaMedics_RetetaMedicals_RetetaMedicalaId",
                table: "FisaMedics");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RetetaMedicals",
                table: "RetetaMedicals");

            migrationBuilder.RenameTable(
                name: "RetetaMedicals",
                newName: "RetetaMedicalas");

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

            migrationBuilder.AddPrimaryKey(
                name: "PK_RetetaMedicalas",
                table: "RetetaMedicalas",
                column: "RetetaMedicalaId");

            migrationBuilder.AddForeignKey(
                name: "FK_FisaMedics_RetetaMedicalas_RetetaMedicalaId",
                table: "FisaMedics",
                column: "RetetaMedicalaId",
                principalTable: "RetetaMedicalas",
                principalColumn: "RetetaMedicalaId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
