using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NetRazorApp.Modelos
{
    public class Profesor
    {
        [Key]
        [Required]
        public int idProf { get; set; }
        [StringLength(100)]
        [Required]
        public string Nombre { get; set; }
        [StringLength(50)]
        [Required]
        public string Apellido { get; set; }
        [Required]
        [Display(Name = "Especialización")]
        public int Esp { get; set; }
        [Required]
        [Display(Name = "Fecha de nacimiento")]
        [DisplayFormat(DataFormatString = "{0: dd-MM-yyyy}")]
        public DateTime Fecha_nac { get; set; }
        [Required]
        [Display(Name = "Fecha de ingreso")]
        [DisplayFormat(DataFormatString = "{0: dd-MM-yyyy}")]
        public DateTime Fecha_ing { get; set; }

    }
}
