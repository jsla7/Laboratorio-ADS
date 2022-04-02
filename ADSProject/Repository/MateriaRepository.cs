using ADSProject.Models;
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


        public MateriaRepository() {

            lstMaterias = new List<MateriasViewModel>
            {
            new MateriasViewModel{IdMateria = 1, Materia = "Analisis de sistemas"}
            };
        }


        
        public int agregarMateria(MateriasViewModel materiaViewModel)
        {
            try
            {
                if (lstMaterias.Count > 0)
                {
                    materiaViewModel.IdMateria = lstMaterias.Last().IdMateria + 1;
                }
                else
                {
                    materiaViewModel.IdMateria = 1;
                }
                lstMaterias.Add(materiaViewModel);
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
                lstMaterias[lstMaterias.FindIndex(x => x.IdMateria == IdMateria)] = materiasViewModel;
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
                lstMaterias.RemoveAt(lstMaterias.FindIndex(x => x.IdMateria == IdMateria));
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
                var item = lstMaterias.Find(x => x.IdMateria == IdMateria);
                return item;
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
                return lstMaterias;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
