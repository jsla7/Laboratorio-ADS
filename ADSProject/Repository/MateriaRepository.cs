using ADSProject.Models;
using Microsoft.EntityFrameworkCore;
using ProyectoADS.Data;
using ProyectoADS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoADS.Repository
{
    public class MateriaRepository : IMateriaRepository
    {

        private readonly List<MateriasViewModel> lstMaterias;
        private readonly ApplicationDbContext applicationDbContext;


        public MateriaRepository(ApplicationDbContext applicationDbContext) 
        {
            this.applicationDbContext = applicationDbContext;
        }

        public int agregarMateria(MateriasViewModel materiaViewModel)
        {
            try
            {

                applicationDbContext.Materias.Add(materiaViewModel);
                applicationDbContext.SaveChanges();

                return materiaViewModel.IdMateria;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int actualizarMateria(int IdMateria, MateriasViewModel materiasViewModel)
        {
            try
            {
                var item = applicationDbContext.Materias.SingleOrDefault(x => x.IdMateria == IdMateria);

                applicationDbContext.Entry(item).CurrentValues.SetValues(materiasViewModel);

                applicationDbContext.SaveChanges();

                return materiasViewModel.IdMateria;
            }
            catch (Exception)
            {

                throw;
            }
        }


        public bool eliminarMateria(int IdMateria)
        {
            try
            {
                var item = applicationDbContext.Materias.SingleOrDefault(x => x.IdMateria == IdMateria);

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

        public MateriasViewModel obtenerMateriaPorID(int IdMateria)
        {
            try
            {
                var item = applicationDbContext.Materias.SingleOrDefault(x => x.IdMateria == IdMateria);
                return item;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<MateriasViewModel> obtenerMaterias(String[] includes)
        {
            try
            {
                var lst = applicationDbContext.Materias.Where(x => x.estado == true).AsQueryable();

                foreach (var item in includes)
                {
                    lst = lst.Include(item);
                }

                return lst.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<MateriasViewModel> obtenerMaterias()
        {
            try
            {
                return applicationDbContext.Materias.Where(x => x.estado == true).ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
