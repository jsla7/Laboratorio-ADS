using ADSProject.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoADS.Models
{
    public class MateriasViewModel
    {

        [Display(Name = "ID")]
        [Key]
        [Required(ErrorMessage = Constants.REQUIRED_FIELD)]
        public int IdMateria { get; set; }

        [Required(ErrorMessage = Constants.REQUIRED_FIELD)]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "La longitud del campo no debe ser mayor a 50 caracteres ni menor de 3 caracteres.")]
        [Display(Name = "Materia")]
        public string Materia { get; set; }

        public bool estado { get; set; }

        [Display(Name = "Carrera")]
        [Required(ErrorMessage = Constants.REQUIRED_FIELD)]
        public int idCarrera { get; set; }

        [ForeignKey("idCarrera")]
        public CarrerasViewModel Carreras { get; set; }


    }
}
