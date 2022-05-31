using ProyectoADS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoADS.Repository
{
    public interface IAsignacionGrupoRepository
    {
        public int agregarAsignacionGrupo(GrupoViewModel grupoViewModel);

        public void agregarAsignacionGrupo(ICollection<AsignacionGrupoViewModel> asignacionGrupoViewModel);

        public int actualizarAsignacionGrupo(int idAGrupo, AsignacionGrupoViewModel asignacionGrupoViewModel);

        public bool deleteAsignacionGrupo(int idAGrupo);

        public List<AsignacionGrupoViewModel> obtenerAsignacionesGrupo();

        public AsignacionGrupoViewModel obtenerAsignacionPorID(int idAGrupo);

        
    }
}
