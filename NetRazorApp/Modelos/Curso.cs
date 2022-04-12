using System.ComponentModel.DataAnnotations;

namespace NetRazorApp.Modelos
{
    public class Curso
    {
        //esto es la ENTIDAD que va a pasar a ser una tabla despues de la migración
        //[datanotation] , signnifica que la linea 7 es una clave
        [Key]
           // require aplica al primer consecuente de abajo, display puede ser tipo un place holder
       public int Id { get; set; } 
        [Required]
        [Display(Name ="Nombre del curso")]
        public string NombreCurso { get; set; }
        [Display(Name = "Cantidad de Clases")]
        public int CantidadClases { get; set; }
        public int Precio { get; set; }
        [Display(Name = "Fecha de Creación")]
        public DateTime FechaCreacion { get; set; }

    }
}
