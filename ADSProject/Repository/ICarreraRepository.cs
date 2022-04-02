using ProyectoADS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoADS.Repository
{
    public interface ICarreraRepository
    {

        List<CarrerasViewModel> obtenerCarreras();

        int agregarCarrera(CarrerasViewModel carrerasViewModel);

        int actualizarCarrera(int idCarrera, CarrerasViewModel carrerasViewModel);

        bool eliminarCarrera(int idCarrera);

        CarrerasViewModel obtenerCarreraPorID(int idCarrera);

    }
}
