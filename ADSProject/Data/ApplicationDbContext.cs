using ADSProject.Models;
using Microsoft.EntityFrameworkCore;
using ProyectoADS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoADS.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }

        public DbSet<EstudianteViewModel> Estudiantes { get; set; }

        public DbSet<MateriasViewModel> Materias { get; set; }

        public DbSet<CarrerasViewModel> Carreras { get; set; }

        public DbSet<ProfesorViewModel> Profesor { get; set; }

        public DbSet<GrupoViewModel> Grupos { get; set; }
        public DbSet<AsignacionGrupoViewModel> AsignacionGrupos { get; set; }





    }
}
