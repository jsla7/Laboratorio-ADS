using ProyectoADS.Data;
using ProyectoADS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoADS.Repository
{
    public class CarreraRepository : ICarreraRepository
    {

        private readonly List<CarrerasViewModel> lstCarreras;
        private readonly ApplicationDbContext applicationDbContext;


        public CarreraRepository(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }

        public int agregarCarrera(CarrerasViewModel carrerasViewModel)
        {
            try
            {

                applicationDbContext.Carreras.Add(carrerasViewModel);
                applicationDbContext.SaveChanges();

                return carrerasViewModel.idCarrera;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int actualizarCarrera(int idCarrera, CarrerasViewModel carrerasViewModel)
        {
            try
            {
                var item = applicationDbContext.Carreras.SingleOrDefault(x => x.idCarrera == idCarrera);

                applicationDbContext.Entry(item).CurrentValues.SetValues(carrerasViewModel);

                applicationDbContext.SaveChanges();

                return carrerasViewModel.idCarrera;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool eliminarCarrera(int idCarrera)
        {
            try
            {
                var item = applicationDbContext.Carreras.SingleOrDefault(x => x.idCarrera == idCarrera);


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

        public CarrerasViewModel obtenerCarreraPorID(int idCarrera)
        {
            try
            {
                var item = applicationDbContext.Carreras.SingleOrDefault(x => x.idCarrera == idCarrera);
                return item;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<CarrerasViewModel> obtenerCarreras()
        {
            try
            {
                // Obtener todos las carreras con filtro (estado = 1)
                return applicationDbContext.Carreras.Where(x => x.estado == true).ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
