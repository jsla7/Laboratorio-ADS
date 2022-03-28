using ADSProject.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoADS.Models
{
    public class MateriasViewModel
    {

        [Display(Name = "ID")]
        public int idEstudiante { get; set; }

        [Required(ErrorMessage = Constants.REQUIRED_FIELD)]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "La longitud del campo no debe ser mayor a 50 caracteres ni menor de 3 caracteres.")]
        [Display(Name = "Nombre")]
        public string nombresEstudiante { get; set; }

        [Display(Name = "Apellido")]
        public string apellidosEstudiante { get; set; }
        [Display(Name = "Codigo")]
        public string codigoEstudiante { get; set; }
        [Display(Name = "Correo")]
        public string correoEstudiante { get; set; }

    }
}
