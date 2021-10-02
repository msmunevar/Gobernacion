using Microsoft.EntityFrameworkCore.Migrations;

namespace GobernaRegistroBio.App.Persistencia.Migrations
{
    public partial class Incial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Id_gobenasesores",
                table: "personas");

            migrationBuilder.DropColumn(
                name: "Id_personalaseo",
                table: "personas");

            migrationBuilder.DropColumn(
                name: "Id_proveedores",
                table: "personas");

            migrationBuilder.DropColumn(
                name: "Id_secretarios",
                table: "personas");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Id_gobenasesores",
                table: "personas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Id_personalaseo",
                table: "personas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Id_proveedores",
                table: "personas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Id_secretarios",
                table: "personas",
                type: "int",
                nullable: true);
        }
    }
}
