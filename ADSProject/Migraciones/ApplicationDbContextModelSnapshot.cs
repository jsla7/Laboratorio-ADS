﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProyectoADS.Data;

namespace ProyectoADS.Migraciones
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.16")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ADSProject.Models.EstudianteViewModel", b =>
                {
                    b.Property<int>("idEstudiante")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("apellidosEstudiante")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("codigoEstudiante")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.Property<string>("correoEstudiante")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("estado")
                        .HasColumnType("bit");

                    b.Property<int>("idCarrera")
                        .HasColumnType("int");

                    b.Property<string>("nombresEstudiante")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("idEstudiante");

                    b.HasIndex("idCarrera");

                    b.ToTable("Estudiantes");
                });

            modelBuilder.Entity("ProyectoADS.Models.CarrerasViewModel", b =>
                {
                    b.Property<int>("idCarrera")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("codigoCarrera")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("estado")
                        .HasColumnType("bit");

                    b.Property<string>("nombreCarrera")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("idCarrera");

                    b.ToTable("Carreras");
                });

            modelBuilder.Entity("ProyectoADS.Models.GrupoViewModel", b =>
                {
                    b.Property<int>("idGrupo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("IdMateria")
                        .HasColumnType("int");

                    b.Property<int>("anio")
                        .HasColumnType("int");

                    b.Property<int>("ciclo")
                        .HasColumnType("int");

                    b.Property<bool>("estado")
                        .HasColumnType("bit");

                    b.Property<int>("idCarrera")
                        .HasColumnType("int");

                    b.Property<int>("idMateria")
                        .HasColumnType("int");

                    b.Property<int>("idProfesor")
                        .HasColumnType("int");

                    b.HasKey("idGrupo");

                    b.HasIndex("IdMateria");

                    b.HasIndex("idCarrera");

                    b.HasIndex("idProfesor");

                    b.ToTable("Grupos");
                });

            modelBuilder.Entity("ProyectoADS.Models.MateriasViewModel", b =>
                {
                    b.Property<int>("IdMateria")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Materia")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("estado")
                        .HasColumnType("bit");

                    b.Property<int>("idCarrera")
                        .HasColumnType("int");

                    b.HasKey("IdMateria");

                    b.HasIndex("idCarrera");

                    b.ToTable("Materias");
                });

            modelBuilder.Entity("ProyectoADS.Models.ProfesorViewModel", b =>
                {
                    b.Property<int>("idProfesor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("apellidosProfesor")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("correoProfesor")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<bool>("estado")
                        .HasColumnType("bit");

                    b.Property<string>("nombresProfesor")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("idProfesor");

                    b.ToTable("Profesor");
                });

            modelBuilder.Entity("ADSProject.Models.EstudianteViewModel", b =>
                {
                    b.HasOne("ProyectoADS.Models.CarrerasViewModel", "Carreras")
                        .WithMany()
                        .HasForeignKey("idCarrera")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Carreras");
                });

            modelBuilder.Entity("ProyectoADS.Models.GrupoViewModel", b =>
                {
                    b.HasOne("ProyectoADS.Models.MateriasViewModel", "Materias")
                        .WithMany()
                        .HasForeignKey("IdMateria");

                    b.HasOne("ProyectoADS.Models.CarrerasViewModel", "Carreras")
                        .WithMany()
                        .HasForeignKey("idCarrera")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProyectoADS.Models.ProfesorViewModel", "Profesor")
                        .WithMany()
                        .HasForeignKey("idProfesor")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Carreras");

                    b.Navigation("Materias");

                    b.Navigation("Profesor");
                });

            modelBuilder.Entity("ProyectoADS.Models.MateriasViewModel", b =>
                {
                    b.HasOne("ProyectoADS.Models.CarrerasViewModel", "Carreras")
                        .WithMany()
                        .HasForeignKey("idCarrera")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Carreras");
                });
#pragma warning restore 612, 618
        }
    }
}
