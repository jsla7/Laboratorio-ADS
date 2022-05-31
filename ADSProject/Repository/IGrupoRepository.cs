using ProyectoADS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoADS.Repository
{
    public interface IGrupoRepository
    {
        int agregarGrupo(GrupoViewModel grupoViewModel);
        
        int actualizarGrupo(int idGrupo, GrupoViewModel grupoViewModel);
        
        bool eliminarGrupo(int idGrupo);

        List<GrupoViewModel> obtenerGrupos(String[] includes);

        GrupoViewModel obtenerGrupoPorId(int idGrupo, String[] includes);

        GrupoViewModel obtenerGrupoPorId(int idGrupo);

    }
}

/*
 List<GrupoViewModel> obtenerGrupos();

        int agregarGrupo(GrupoViewModel grupoViewModel);

        int actualizarGrupo(int idGrupo, GrupoViewModel grupoViewModel);

        bool eliminarGrupo(int idGrupo);

        GrupoViewModel obtenerGrupoPorID(int idGrupo);
 
 */
