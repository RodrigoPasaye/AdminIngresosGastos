using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AdminIngresosGastos.Migrations
{
    public partial class IngresoGastoDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoriId",
                table: "IngresoGasto");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoriId",
                table: "IngresoGasto",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
