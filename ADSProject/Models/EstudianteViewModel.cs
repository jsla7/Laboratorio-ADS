﻿using ADSProject.Utils;
using ProyectoADS.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ADSProject.Models
{
    public class EstudianteViewModel
    {
        [Display(Name = "ID")]
        [Key]
        public int idEstudiante { get; set; }

        [Required(ErrorMessage = Constants.REQUIRED_FIELD)]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "La longitud del campo no debe ser mayor a 50 caracteres ni menor de 3 caracteres.")]
        [Display(Name = "Nombre")]
        public string nombresEstudiante { get; set; }


        [Required(ErrorMessage = Constants.REQUIRED_FIELD)]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "La longitud del campo no debe ser mayor a 50 caracteres ni menor de 3 caracteres.")]
        [Display(Name = "Apellido")]
        public string apellidosEstudiante { get; set; }



        [Required(ErrorMessage = Constants.REQUIRED_FIELD)]
        [StringLength(12, MinimumLength = 12, ErrorMessage = "La longitud del campo no debe ser mayor a 12 caracteres ni menor de 12 caracteres.")]
        [Display(Name = "Codigo")]
        public string codigoEstudiante { get; set; }



        [Required(ErrorMessage = Constants.REQUIRED_FIELD)]
        [StringLength(50, MinimumLength = 10, ErrorMessage = "La longitud del campo no debe ser mayor a 50 caracteres ni menor de 10 caracteres.")]
        [Display(Name = "Correo")]
        public string correoEstudiante { get; set; }

        public bool estado { get; set; }

        [Display(Name = "Carrera")]
        [Required(ErrorMessage = Constants.REQUIRED_FIELD)]
        public int idCarrera { get; set; }

        [ForeignKey("idCarrera")]
        public CarrerasViewModel Carreras { get; set; }
        public ICollection<AsignacionGrupoViewModel> AsignacionGrupos { get; set; }

    }
}
