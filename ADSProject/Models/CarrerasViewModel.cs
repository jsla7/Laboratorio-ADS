using ADSProject.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoADS.Models
{
    public class CarrerasViewModel
    {

        [Display(Name = "ID")]
        [Key]
        [Required(ErrorMessage = Constants.REQUIRED_FIELD)]
        public int idCarrera { get; set; }

        [Required(ErrorMessage = Constants.REQUIRED_FIELD)]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "La longitud del campo no debe ser mayor a 50 caracteres ni menor de 3 caracteres.")]
        [Display(Name = "Codigo")]
        public string codigoCarrera { get; set; }

        [Required(ErrorMessage = Constants.REQUIRED_FIELD)]
        [StringLength(50, MinimumLength = 10, ErrorMessage = "La longitud del campo no debe ser mayor a 50 caracteres ni menor de 10 caracteres.")]
        [Display(Name = "Carrera")]
        public string nombreCarrera { get; set; }

        public bool estado { get; set; }

    }
}
