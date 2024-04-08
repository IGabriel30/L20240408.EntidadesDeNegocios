using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace L20240408.AccesoADatos.Migrations
{
    public partial class L20240408 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Persona",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreL = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    ApellidoL = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    FechaNacimientoL = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SueldoL = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    StatusL = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persona", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Persona");
        }
    }
}
