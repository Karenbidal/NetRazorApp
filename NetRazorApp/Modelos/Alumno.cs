using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NetRazorApp.Modelos
{
    public class Alumno
    {
        /*las data notation van por encima de la propiedad que van a cambiar, la key se vuelve autoincremental automaticamente con esa palabra */
        [Key]
        [Required]
        [Display(Name = "Clave")]
        public int IdAlumno { get; set; }
        [StringLength(100)]
        [Required]
        public string Nombre { get; set; }
        [StringLength(50)]
        [Required]
        public string Apellido { get; set; }
        [Required]
        [Display(Name = "Fecha de ingreso")]
        [DisplayFormat(DataFormatString ="{0: yyyy-MM-dd}")]
        public DateTime Fecha_ing { get; set; }
        [DisplayFormat(DataFormatString = "{0: hh:mm:ss}")]
        [Display(Name = "Hora de ingreso")]
        [Required]
        public DateTime Hora_ing { get; set; }
        [Display(Name = "Fecha de nacimiento")]
        [Required]
        public DateTime Fecha_nac { get; set; }
        [DisplayFormat(DataFormatString = "{0: dd/MM/yyyy}")]
        [Display(Name = "Cantidad de cursos")]
        [Required]
        public int Cant_cursos { get; set; }
        [Required]
        [Display(Name = "Fecha de egreso")]
        [DisplayFormat(DataFormatString = "{0: yyyy/MM/dd}")]
        public DateTime Fecha_egr { get; set; }
    }
}
