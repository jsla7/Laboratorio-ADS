using ADSProject.Models;
using Microsoft.EntityFrameworkCore;
using ProyectoADS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ADSProject.Repository
{
    public class EstudianteRepository : IEstudianteRepository
    {
        private readonly List<EstudianteViewModel> lstEstudiantes;
        private readonly ApplicationDbContext applicationDbContext;

        public EstudianteRepository(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;

        }

        public int agregarEstudiante(EstudianteViewModel estudianteViewModel)
        {
            try
            {

                applicationDbContext.Estudiantes.Add(estudianteViewModel);
                applicationDbContext.SaveChanges();

                return estudianteViewModel.idEstudiante;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int actualizarEstudiante(int idEstudiante, EstudianteViewModel estudianteViewModel)
        {
            try
            {
                var item = applicationDbContext.Estudiantes.SingleOrDefault(x => x.idEstudiante == idEstudiante);

                applicationDbContext.Entry(item).CurrentValues.SetValues(estudianteViewModel);

                applicationDbContext.SaveChanges();

                return estudianteViewModel.idEstudiante;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool eliminarEstudiante(int idEstudiante)
        {
            try
            {
                var item = applicationDbContext.Estudiantes.SingleOrDefault(x => x.idEstudiante == idEstudiante);

             
                item.estado = false;

                applicationDbContext.Attach(item);

                applicationDbContext.Entry(item).Property(x => x.estado).IsModified = true;

                applicationDbContext.SaveChanges();

                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public EstudianteViewModel obtenerEstudiantePorID(int idEstudiante)
        {
            try
            {
                // var item = lstEstudiantes.Find(x => x.idEstudiante == idEstudiante);
                var item = applicationDbContext.Estudiantes.SingleOrDefault(x => x.idEstudiante == idEstudiante);
                return item;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<EstudianteViewModel> obtenerEstudiantes(String[] includes)
        {
            try
            {
                var lst = applicationDbContext.Estudiantes.Where(x => x.estado == true).AsQueryable();

                foreach (var item in includes)
                {
                    lst = lst.Include(item);
                }

                return lst.ToList();
                // Obtener todos los estudiante con filtro (estado = 1)
                //return applicationDbContext.Estudiantes.Where(x => x.estado == true).ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<EstudianteViewModel> obtenerEstudiantes()
        {
            try
            {
                // Obtener todos los estudiante con filtro (estado = 1)
                return applicationDbContext.Estudiantes.Where(x => x.estado == true).ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
