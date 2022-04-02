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


        public CarreraRepository()
        {

            lstCarreras = new List<CarrerasViewModel>
            {
            new CarrerasViewModel
            {idCarrera = 1, codigoCarrera = "I04", nombreCarrera = "Ingenieria en sistemas"}
            };
        }

        public int agregarCarrera(CarrerasViewModel carrerasViewModel)
        {
            try
            {
                if (lstCarreras.Count > 0)
                {
                    carrerasViewModel.idCarrera = lstCarreras.Last().idCarrera + 1;
                }
                else
                {
                    carrerasViewModel.idCarrera = 1;
                }
                lstCarreras.Add(carrerasViewModel);
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
                lstCarreras[lstCarreras.FindIndex(x => x.idCarrera == idCarrera)] = carrerasViewModel;
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
                lstCarreras.RemoveAt(lstCarreras.FindIndex(x => x.idCarrera == idCarrera));
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
                var item = lstCarreras.Find(x => x.idCarrera == idCarrera);
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
                return lstCarreras;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
