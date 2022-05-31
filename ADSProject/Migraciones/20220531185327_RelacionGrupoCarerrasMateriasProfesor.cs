using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyectoADS.Migraciones
{
    public partial class RelacionGrupoCarerrasMateriasProfesor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdMateria",
                table: "Grupos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Grupos_idCarrera",
                table: "Grupos",
                column: "idCarrera");

            migrationBuilder.CreateIndex(
                name: "IX_Grupos_IdMateria",
                table: "Grupos",
                column: "IdMateria");

            migrationBuilder.CreateIndex(
                name: "IX_Grupos_idProfesor",
                table: "Grupos",
                column: "idProfesor");

            migrationBuilder.AddForeignKey(
                name: "FK_Grupos_Carreras_idCarrera",
                table: "Grupos",
                column: "idCarrera",
                principalTable: "Carreras",
                principalColumn: "idCarrera",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Grupos_Materias_IdMateria",
                table: "Grupos",
                column: "IdMateria",
                principalTable: "Materias",
                principalColumn: "IdMateria",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Grupos_Profesor_idProfesor",
                table: "Grupos",
                column: "idProfesor",
                principalTable: "Profesor",
                principalColumn: "idProfesor",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Grupos_Carreras_idCarrera",
                table: "Grupos");

            migrationBuilder.DropForeignKey(
                name: "FK_Grupos_Materias_IdMateria",
                table: "Grupos");

            migrationBuilder.DropForeignKey(
                name: "FK_Grupos_Profesor_idProfesor",
                table: "Grupos");

            migrationBuilder.DropIndex(
                name: "IX_Grupos_idCarrera",
                table: "Grupos");

            migrationBuilder.DropIndex(
                name: "IX_Grupos_IdMateria",
                table: "Grupos");

            migrationBuilder.DropIndex(
                name: "IX_Grupos_idProfesor",
                table: "Grupos");

            migrationBuilder.DropColumn(
                name: "IdMateria",
                table: "Grupos");
        }
    }
}
