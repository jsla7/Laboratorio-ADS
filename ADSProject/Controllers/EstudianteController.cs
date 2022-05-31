using ADSProject.Models;
using ADSProject.Repository;
using ADSProject.Utils;
using Microsoft.AspNetCore.Mvc;
using ProyectoADS.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ADSProject.Controllers
{
    public class EstudianteController : Controller
    {
        private readonly IEstudianteRepository estudianteRepository;
        private readonly ICarreraRepository carreraRepository;

        public EstudianteController(IEstudianteRepository estudianteRepository, ICarreraRepository carreraRepository)
        {
            this.estudianteRepository = estudianteRepository;
            this.carreraRepository = carreraRepository;
        }

        [HttpGet]
        public IActionResult Index()
        {
            try
            {
                var item = estudianteRepository.obtenerEstudiantes(new string[] { "Carreras" });

                return View(item);
            }
            catch (Exception)
            {

                throw;
            }

        }

        [HttpGet]
        public IActionResult Form(int? idEstudiante, Operaciones operaciones)
        {
            try
            {
                var estudiante = new EstudianteViewModel();

                if (idEstudiante.HasValue)
                {
                    estudiante = estudianteRepository.obtenerEstudiantePorID(idEstudiante.Value);
                }
                ViewData["Operaciones"] = operaciones;

                ViewBag.Carreras = carreraRepository.obtenerCarreras();

                return View(estudiante);

            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPost]
        public IActionResult Form(EstudianteViewModel estudianteViewModel)
        {
            try
            {
                if(estudianteViewModel.idEstudiante == 0) 
                {
                    estudianteRepository.agregarEstudiante(estudianteViewModel);
                } else
                {
                    estudianteRepository.actualizarEstudiante
                        (estudianteViewModel.idEstudiante, estudianteViewModel);
                }

                return RedirectToAction("Index");
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPost]
        public IActionResult Delete(int idEstudiante)
        {
            try
            {
                estudianteRepository.eliminarEstudiante(idEstudiante);
            }
            catch (Exception)
            {

                throw;
            }

            return RedirectToAction("Index");
        }
    }
}
