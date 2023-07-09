using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SpitalFinal.Migrations
{
    /// <inheritdoc />
    public partial class initial13 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("ALTER TABLE Programares ADD CONSTRAINT UC_ProgramLucruId UNIQUE (ProgramLucruId)");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
