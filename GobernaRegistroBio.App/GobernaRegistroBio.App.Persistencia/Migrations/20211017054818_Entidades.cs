using Microsoft.EntityFrameworkCore.Migrations;

namespace GobernaRegistroBio.App.Persistencia.Migrations
{
    public partial class Entidades : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_registros",
                table: "registros");

            migrationBuilder.DropPrimaryKey(
                name: "PK_personas",
                table: "personas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_dependencias",
                table: "dependencias");

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
                name: "dependencias",
                newName: "Dependencias");

            migrationBuilder.RenameTable(
                name: "gobernacion",
                newName: "gobernacio");

            migrationBuilder.RenameColumn(
                name: "genero",
                table: "Personas",
                newName: "Genero");

            migrationBuilder.AddColumn<int>(
                name: "personaId",
                table: "Registros",
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
                name: "PK_Dependencias",
                table: "Dependencias",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_gobernacio",
                table: "gobernacio",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Registros_personaId",
                table: "Registros",
                column: "personaId");

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
                name: "FK_Registros_Personas_personaId",
                table: "Registros");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Registros",
                table: "Registros");

            migrationBuilder.DropIndex(
                name: "IX_Registros_personaId",
                table: "Registros");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Personas",
                table: "Personas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Dependencias",
                table: "Dependencias");

            migrationBuilder.DropPrimaryKey(
                name: "PK_gobernacio",
                table: "gobernacio");

            migrationBuilder.DropColumn(
                name: "personaId",
                table: "Registros");

            migrationBuilder.RenameTable(
                name: "Registros",
                newName: "registros");

            migrationBuilder.RenameTable(
                name: "Personas",
                newName: "personas");

            migrationBuilder.RenameTable(
                name: "Dependencias",
                newName: "dependencias");

            migrationBuilder.RenameTable(
                name: "gobernacio",
                newName: "gobernacion");

            migrationBuilder.RenameColumn(
                name: "Genero",
                table: "personas",
                newName: "genero");

            migrationBuilder.AddPrimaryKey(
                name: "PK_registros",
                table: "registros",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_personas",
                table: "personas",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_dependencias",
                table: "dependencias",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_gobernacion",
                table: "gobernacion",
                column: "Id");
        }
    }
}
