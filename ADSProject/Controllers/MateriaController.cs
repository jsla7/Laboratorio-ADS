using ADSProject.Utils;
using Microsoft.AspNetCore.Mvc;
using ProyectoADS.Models;
using ProyectoADS.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoADS.Controllers
{
    public class MateriaController : Controller
    {
        private readonly IMateriaRepository materiaRepository;

        public MateriaController(IMateriaRepository materiaRepository)
        {
            this.materiaRepository = materiaRepository;
        }


        [HttpGet]
        public IActionResult Index()
        {
            try
            {
                var item = materiaRepository.obtenerMaterias();

                return View(item);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpGet]
        public IActionResult Form(int? IdMateria, Operaciones operaciones) 
        {

            try
            {
                var materia = new MateriasViewModel();

                if (IdMateria.HasValue)
                {
                    materia = materiaRepository.obtenerMateriaPorID(IdMateria.Value);
                }

                ViewData["Operaciones"] = operaciones;

                return View(materia);

            }
            catch (Exception)
            {

                throw;
            }

        }

        [HttpPost]

        public IActionResult Form(MateriasViewModel materiaViewModel)
        {
            try
            {
                if (materiaViewModel.IdMateria == 0)
                {
                    materiaRepository.agregarMateria(materiaViewModel);
                }
                else
                {
                    materiaRepository.actualizarMateria(materiaViewModel.IdMateria, materiaViewModel);
                }

                return RedirectToAction("Index");
            }
            catch (Exception)
            {

                throw;
            }
        }


        [HttpGet]
        public IActionResult Delete(int IdMateria)
        {
            try
            {
                materiaRepository.eliminarMateria(IdMateria);
            }
            catch (Exception)
            {

                throw;
            }

            return RedirectToAction("Index");
        }

    }
}
