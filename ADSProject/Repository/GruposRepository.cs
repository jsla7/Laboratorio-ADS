using ProyectoADS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoADS.Repository
{
    public class GruposRepository : IGrupoRepository
    {
        private readonly List<GrupoViewModel> lstGrupos;


        public GruposRepository()
        {
            lstGrupos = new List<GrupoViewModel>();
        }

        public int agregarGrupo(GrupoViewModel grupoViewModel)
        {
            try
            {
                if (lstGrupos.Count > 0)
                {
                    grupoViewModel.idGrupo = lstGrupos.Last().idGrupo + 1;
                }
                else
                {
                    grupoViewModel.idGrupo = 1;
                }

                lstGrupos.Add(grupoViewModel);

                return grupoViewModel.idGrupo;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public int actualizarGrupo(int idGrupo, GrupoViewModel grupoViewModel)
        {
            try
            {
                lstGrupos[lstGrupos.FindIndex(x => x.idGrupo == idGrupo)] = grupoViewModel;

                return grupoViewModel.idGrupo;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool eliminarGrupo(int idGrupo)
        {
            try
            {
                lstGrupos.RemoveAt(lstGrupos.FindIndex(x => x.idGrupo == idGrupo));

                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public GrupoViewModel obtenerGrupoPorId(int idGrupo)
        {
            try
            {
                var item = lstGrupos.Find(x => x.idGrupo == idGrupo);

                return item;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<GrupoViewModel> obtenerGrupos()
        {
            try
            {
                return lstGrupos;
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}

/*
 private readonly List<GrupoViewModel> lstGrupos;
        List<CarrerasViewModel> lstCarrera;
        CarreraRepository avc = new CarreraRepository();

        List<MateriasViewModel> lstMateria;
        MateriaRepository avm = new MateriaRepository();

        List<ProfesorViewModel> lstProf;
        ProfesorRepository avp = new ProfesorRepository();


        public GruposRepository()
        {

            lstGrupos = new List<GrupoViewModel>
            {
            new GrupoViewModel
            {idGrupo = 1, idCarrera = 1,Carrera = "Ingenieria en Sistemas", idMateria = 1,Materia = "Analisis de sistemas", idProfesor = 1,profesor = "Raul Gonzales", Ciclo = "01", anio = "2022"}
            };
        }


        public int agregarGrupo(GrupoViewModel grupoViewModel)
        {
            try
            {
                if (lstGrupos.Count > 0)
                {
                    grupoViewModel.idGrupo = lstGrupos.Last().idGrupo + 1;
                }
                else
                {
                    grupoViewModel.idGrupo = 1;
                }

                lstCarrera = avc.obtenerCarreras();
                lstMateria = avm.obtenerMaterias();
                lstProf = avp.obtenerProfesor();


                grupoViewModel.Carrera = 
                lstCarrera[lstCarrera.FindIndex(x => x.idCarrera == grupoViewModel.idCarrera)].nombreCarrera; ;
                

                grupoViewModel.Materia =
                lstMateria[lstMateria.FindIndex(x => x.IdMateria == grupoViewModel.idMateria)].Materia;

                grupoViewModel.profesor =
                lstProf[lstProf.FindIndex(x => x.idProfesor == grupoViewModel.idProfesor)].nombresProfesor + " " +
                lstProf[lstProf.FindIndex(x => x.idProfesor == grupoViewModel.idProfesor)].apellidosProfesor;

                lstGrupos.Add(grupoViewModel);
                return grupoViewModel.idGrupo;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int actualizarGrupo(int idGrupo, GrupoViewModel grupoViewModel)
        {
            try
            {
                lstGrupos[lstGrupos.FindIndex(x => x.idGrupo == idGrupo)] = grupoViewModel;

                lstCarrera = avc.obtenerCarreras();
                lstMateria = avm.obtenerMaterias();
                lstProf = avp.obtenerProfesor();

                grupoViewModel.Carrera =
                lstCarrera[lstCarrera.FindIndex(x => x.idCarrera == grupoViewModel.idCarrera)].nombreCarrera; ;


                grupoViewModel.Materia =
                lstMateria[lstMateria.FindIndex(x => x.IdMateria == grupoViewModel.idMateria)].Materia;

                grupoViewModel.profesor =
                lstProf[lstProf.FindIndex(x => x.idProfesor == grupoViewModel.idProfesor)].nombresProfesor + " " +
                lstProf[lstProf.FindIndex(x => x.idProfesor == grupoViewModel.idProfesor)].apellidosProfesor;


                return grupoViewModel.idCarrera;
            }
            catch (Exception)
            {

                throw;
            }
        }


        public bool eliminarGrupo(int idGrupo)
        {
            try
            {
                lstGrupos.RemoveAt(lstGrupos.FindIndex(x => x.idGrupo == idGrupo));
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public GrupoViewModel obtenerGrupoPorID(int idGrupo)
        {
            try
            {
                var item = lstGrupos.Find(x => x.idGrupo == idGrupo);
                return item;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<GrupoViewModel> obtenerGrupos()
        {
            try
            {
                return lstGrupos;
            }
            catch (Exception)
            {

                throw;
            }
        }
 */