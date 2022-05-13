﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyectoADS.Migraciones
{
    public partial class PrimeraMigracion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Carreras",
                columns: table => new
                {   
                    idCarrera = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    codigoCarrera = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    nombreCarrera = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carreras", x => x.idCarrera);
                });

            migrationBuilder.CreateTable(
                name: "Estudiantes",
                columns: table => new
                {
                    idEstudiante = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombresEstudiante = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    apellidosEstudiante = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    codigoEstudiante = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    correoEstudiante = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estudiantes", x => x.idEstudiante);
                });

            migrationBuilder.CreateTable(
                name: "Grupos",
                columns: table => new
                {
                    idGrupo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idCarrera = table.Column<int>(type: "int", nullable: false),
                    idMateria = table.Column<int>(type: "int", nullable: false),
                    idProfesor = table.Column<int>(type: "int", nullable: false),
                    ciclo = table.Column<int>(type: "int", nullable: false),
                    anio = table.Column<int>(type: "int", nullable: false),
                    estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grupos", x => x.idGrupo);
                });

            migrationBuilder.CreateTable(
                name: "Materias",
                columns: table => new
                {
                    IdMateria = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Materia = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materias", x => x.IdMateria);
                });

            migrationBuilder.CreateTable(
                name: "Profesor",
                columns: table => new
                {
                    idProfesor = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombresProfesor = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    apellidosProfesor = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    correoProfesor = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profesor", x => x.idProfesor);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Carreras");

            migrationBuilder.DropTable(
                name: "Estudiantes");

            migrationBuilder.DropTable(
                name: "Grupos");

            migrationBuilder.DropTable(
                name: "Materias");

            migrationBuilder.DropTable(
                name: "Profesor");
        }
    }
}
