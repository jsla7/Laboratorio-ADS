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
        private readonly ICarreraRepository carreraRepository;

        public MateriaController(IMateriaRepository materiaRepository, ICarreraRepository carreraRepository)
        {
            this.materiaRepository = materiaRepository;
            this.carreraRepository = carreraRepository;
        }


        [HttpGet]
        public IActionResult Index()
        {
            try
            {
                var item = materiaRepository.obtenerMaterias(new string[] { "Carreras" });

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

                ViewBag.Carreras = carreraRepository.obtenerCarreras();

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


        [HttpPost]
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
