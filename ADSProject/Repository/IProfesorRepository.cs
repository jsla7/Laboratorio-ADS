using ProyectoADS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoADS.Repository
{
    public interface IProfesorRepository
    {

        List<ProfesorViewModel> obtenerProfesor();

        int agregarProfesor(ProfesorViewModel profesorViewModel);

        int actualizarProfesor(int idProfesor, ProfesorViewModel profesorViewModel);

        bool eliminarProfesor(int idProfesor);

        ProfesorViewModel obtenerProfesorPorID(int idProfesor);


    }
}
