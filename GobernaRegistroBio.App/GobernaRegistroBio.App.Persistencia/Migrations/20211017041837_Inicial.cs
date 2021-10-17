using Microsoft.EntityFrameworkCore.Migrations;

namespace GobernaRegistroBio.App.Persistencia.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "dependencias");

            migrationBuilder.DropPrimaryKey(
                name: "PK_registros",
                table: "registros");

            migrationBuilder.DropPrimaryKey(
                name: "PK_personas",
                table: "personas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_gobernacion",
                table: "gobernacion");

            migrationBuilder.RenameTable(
                name: "registros",
                newName: "Registros");

            migrationBuilder.RenameTable(
                name: "personas",
                newName: "Personas");

            migrationBuilder.RenameTable(
                name: "gobernacion",
                newName: "gobernacio");

            migrationBuilder.RenameColumn(
                name: "Sintomas",
                table: "Registros",
                newName: "sintomas");

            migrationBuilder.RenameColumn(
                name: "genero",
                table: "Personas",
                newName: "Genero");

            migrationBuilder.RenameColumn(
                name: "Dependencias",
                table: "gobernacio",
                newName: "Aforo_PorDependencia");

            migrationBuilder.AlterColumn<int>(
                name: "sintomas",
                table: "Registros",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DependenciaId",
                table: "Registros",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "personaId",
                table: "Registros",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Ubicacion",
                table: "Personas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "gobernacio",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Ubicacion",
                table: "gobernacio",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Registros",
                table: "Registros",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Personas",
                table: "Personas",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_gobernacio",
                table: "gobernacio",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Registros_DependenciaId",
                table: "Registros",
                column: "DependenciaId");

            migrationBuilder.CreateIndex(
                name: "IX_Registros_personaId",
                table: "Registros",
                column: "personaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Registros_gobernacio_DependenciaId",
                table: "Registros",
                column: "DependenciaId",
                principalTable: "gobernacio",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Registros_Personas_personaId",
                table: "Registros",
                column: "personaId",
                principalTable: "Personas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Registros_gobernacio_DependenciaId",
                table: "Registros");

            migrationBuilder.DropForeignKey(
                name: "FK_Registros_Personas_personaId",
                table: "Registros");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Registros",
                table: "Registros");

            migrationBuilder.DropIndex(
                name: "IX_Registros_DependenciaId",
                table: "Registros");

            migrationBuilder.DropIndex(
                name: "IX_Registros_personaId",
                table: "Registros");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Personas",
                table: "Personas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_gobernacio",
                table: "gobernacio");

            migrationBuilder.DropColumn(
                name: "DependenciaId",
                table: "Registros");

            migrationBuilder.DropColumn(
                name: "personaId",
                table: "Registros");

            migrationBuilder.DropColumn(
                name: "Ubicacion",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "gobernacio");

            migrationBuilder.DropColumn(
                name: "Ubicacion",
                table: "gobernacio");

            migrationBuilder.RenameTable(
                name: "Registros",
                newName: "registros");

            migrationBuilder.RenameTable(
                name: "Personas",
                newName: "personas");

            migrationBuilder.RenameTable(
                name: "gobernacio",
                newName: "gobernacion");

            migrationBuilder.RenameColumn(
                name: "sintomas",
                table: "registros",
                newName: "Sintomas");

            migrationBuilder.RenameColumn(
                name: "Genero",
                table: "personas",
                newName: "genero");

            migrationBuilder.RenameColumn(
                name: "Aforo_PorDependencia",
                table: "gobernacion",
                newName: "Dependencias");

            migrationBuilder.AlterColumn<string>(
                name: "Sintomas",
                table: "registros",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_registros",
                table: "registros",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_personas",
                table: "personas",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_gobernacion",
                table: "gobernacion",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "dependencias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Aforo_PorDependencia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nombre_Dependencia = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dependencias", x => x.Id);
                });
        }
    }
}
