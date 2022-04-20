using ADSProject.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoADS.Models
{
    public class GrupoViewModel
    {
        [Display(Name = "idGrupo")]
        public int idGrupo { get; set; }


        [Required(ErrorMessage = Constants.REQUIRED_FIELD)]
        [Display(Name = "idCarrera")]
        public int idCarrera { get; set; }

        [Display(Name = "Carrera")]
        public string Carrera { get; set; }

        [Required(ErrorMessage = Constants.REQUIRED_FIELD)]
        [Display(Name = "idMateria")]
        public int idMateria { get; set; }

        [Display(Name = "Materia")]
        public string Materia { get; set; }


        [Required(ErrorMessage = Constants.REQUIRED_FIELD)]
        [Display(Name = "idProfesor")]
        public int idProfesor { get; set; }

        [Display(Name = "idCarrera")]
        public string profesor { get; set; }


        [Required(ErrorMessage = Constants.REQUIRED_FIELD)]
        [Display(Name = "Ciclo")]
        public string Ciclo { get; set; }


        [Required(ErrorMessage = Constants.REQUIRED_FIELD)]
        [Display(Name = "Año")]
        public string anio { get; set; }


    }
}
