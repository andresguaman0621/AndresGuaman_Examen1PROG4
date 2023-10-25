using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AndresGuaman_Examen1PROG.Migrations
{
    public partial class agBaseDatos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AndresGuaman_tabla",
                columns: table => new
                {
                    agEmpleadoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    agSalario = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    agNombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    agConNombramiento = table.Column<bool>(type: "bit", nullable: false),
                    agFecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    agCedula = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AndresGuaman_tabla", x => x.agEmpleadoId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AndresGuaman_tabla");
        }
    }
}
