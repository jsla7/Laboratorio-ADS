using ADSProject.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoADS.Models
{
    public class GrupoViewModel
    {
        [Display(Name = "ID")]
        [Key]
        public int idGrupo { get; set; }

        [Required(ErrorMessage = Constants.REQUIRED_FIELD)]
        [Display(Name = "Carrera")]
        public int idCarrera { get; set; }

        [ForeignKey("idCarrera")]
        public CarrerasViewModel Carreras { get; set; }

        [Required(ErrorMessage = Constants.REQUIRED_FIELD)]
        [Display(Name = "Materia")]
        public int idMateria { get; set; }

        [ForeignKey("IdMateria")]
        public MateriasViewModel Materias { get; set; }

        [Required(ErrorMessage = Constants.REQUIRED_FIELD)]
        [Display(Name = "Profesor")]
        public int idProfesor { get; set; }

        [ForeignKey("idProfesor")]
        public ProfesorViewModel Profesor { get; set; }

        [Required(ErrorMessage = Constants.REQUIRED_FIELD)]
        [Display(Name = "Ciclo")]
        public int ciclo { get; set; }

        [Required(ErrorMessage = Constants.REQUIRED_FIELD)]
        [Display(Name = "Anio")]
        public int anio { get; set; }

        public bool estado { get; set; }

        public ICollection<AsignacionGrupoViewModel> AsignacionGrupos { get; set; }

    }
}




/*
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
        [Key]
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

        public bool estado { get; set; }


    }
}

 
 
 */