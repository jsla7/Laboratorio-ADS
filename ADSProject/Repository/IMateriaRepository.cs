using ProyectoADS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoADS.Repository
{
    public interface IMateriaRepository
    {

        List<MateriasViewModel> obtenerMaterias(String[] includes);
        List<MateriasViewModel> obtenerMaterias();

        int agregarMateria(MateriasViewModel materiaViewModel);

        int actualizarMateria(int IdMateria, MateriasViewModel materiasViewModel);

        bool eliminarMateria(int IdMateria);

        MateriasViewModel obtenerMateriaPorID(int IdMateria);

    }
}
