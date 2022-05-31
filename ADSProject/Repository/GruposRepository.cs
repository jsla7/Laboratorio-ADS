using ProyectoADS.Models;
using System.Collections.Generic;
using System.Linq;
using System;
using ProyectoADS.Data;
using Microsoft.EntityFrameworkCore;

namespace ProyectoADS.Repository
{
    public class GrupoRepository : IGrupoRepository
    {

        private readonly ApplicationDbContext applicationDbContext;


        public GrupoRepository(ApplicationDbContext applicationDbContext)
        {

            this.applicationDbContext = applicationDbContext;

        }

        public int agregarGrupo(GrupoViewModel grupoViewModel)
        {
            try
            {
                applicationDbContext.Grupos.Add(grupoViewModel);

                applicationDbContext.SaveChanges();

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
                //  lstGrupos[lstGrupos.FindIndex(x => x.idGrupo == idGrupo)] = grupoViewModel;

                var item = applicationDbContext.Grupos.SingleOrDefault(x => x.idGrupo == idGrupo);

                applicationDbContext.Entry(item).CurrentValues.SetValues(grupoViewModel);

                applicationDbContext.SaveChanges();

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
                //   lstGrupos.RemoveAt(lstGrupos.FindIndex(x => x.idGrupo == idGrupo));

                var item = applicationDbContext.Grupos.SingleOrDefault(x => x.idGrupo == idGrupo);

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

        public GrupoViewModel obtenerGrupoPorId(int idGrupo)
        {
            try
            {
                //var item = lstGrupos.Find(x => x.idGrupo == idGrupo);

                return applicationDbContext.Grupos.SingleOrDefault(x => x.idGrupo == idGrupo);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<GrupoViewModel> obtenerGrupos(string[] includes)
        {
            try
            {
                var lst = applicationDbContext.Grupos.Where(x => x.estado == true).AsQueryable();

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

        // Obtener grupo filtrado
        public GrupoViewModel obtenerGrupoPorId(int idGrupo, string[] includes)
        {
            try
            {
                var lst = applicationDbContext.Grupos.Where(x => x.estado == true).AsQueryable();

                if (includes != null && includes.Count() > 0)
                {
                    foreach (var item in includes)
                    {
                        lst = lst.Include(item);
                    }
                }

                return lst.SingleOrDefault(x => x.idGrupo == idGrupo);
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}