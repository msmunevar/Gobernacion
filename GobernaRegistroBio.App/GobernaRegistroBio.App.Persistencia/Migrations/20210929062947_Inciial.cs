using Microsoft.EntityFrameworkCore.Migrations;

namespace GobernaRegistroBio.App.Persistencia.Migrations
{
    public partial class Inciial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "dependencias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre_Dependencia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aforo_PorDependencia = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dependencias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "gobernacion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Dependencias = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aforo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gobernacion", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "personas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Identificacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Edad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rol = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    genero = table.Column<int>(type: "int", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Id_gobenasesores = table.Column<int>(type: "int", nullable: true),
                    Oficinas_Visitadas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Id_personalaseo = table.Column<int>(type: "int", nullable: true),
                    Turno_Servicio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Id_proveedores = table.Column<int>(type: "int", nullable: true),
                    Servicio_Realizado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Unidad_Servicio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Id_secretarios = table.Column<int>(type: "int", nullable: true),
                    Despacho = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_personas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "registros",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha_Diagnostico = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sintomas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tiempo_Aislamiento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Autoriza_Ingreso = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_registros", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "dependencias");

            migrationBuilder.DropTable(
                name: "gobernacion");

            migrationBuilder.DropTable(
                name: "personas");

            migrationBuilder.DropTable(
                name: "registros");
        }
    }
}
