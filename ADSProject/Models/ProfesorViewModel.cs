﻿using ADSProject.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoADS.Models
{
    public class ProfesorViewModel
    {
        [Display(Name = "ID")]
        [Key]
        public int idProfesor { get; set; }

        [Required(ErrorMessage = Constants.REQUIRED_FIELD)]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "La longitud del campo no debe ser mayor a 50 caracteres ni menor de 3 caracteres.")]
        [Display(Name = "Nombre")]
        public string nombresProfesor { get; set; }


        [Required(ErrorMessage = Constants.REQUIRED_FIELD)]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "La longitud del campo no debe ser mayor a 50 caracteres ni menor de 3 caracteres.")]
        [Display(Name = "Apellido")]
        public string apellidosProfesor { get; set; }



        [Required(ErrorMessage = Constants.REQUIRED_FIELD)]
        [StringLength(70, MinimumLength = 10, ErrorMessage = "La longitud del campo no debe ser mayor a 70 caracteres ni menor de 10 caracteres.")]
        [Display(Name = "Correo")]
        public string correoProfesor { get; set; }
        public bool estado { get; set; }
    }
}
