using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaWebEmpleado.Migrations
{
    public partial class holox : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "DNI",
                table: "Empleados",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "DNI",
                table: "Empleados",
                type: "int",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
