using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NetRazorApp.Modelos;
using NetRazorApp.wwwroot.Datos;

namespace NetRazorApp.Pages.Cursos
{
    public class EditarModel : PageModel
    {
        private readonly NetRazorAppDBContext _contexto;
        public EditarModel(NetRazorAppDBContext contexto)
        {
            _contexto = contexto;
        }

        //vincular la propiedad(curso) de esta parte logica con la de bootstrap
        //bind property vincula la propiedad para que la podamos acceder desde el formulario
        [BindProperty]
        public Curso Curso { get; set; }

        public async Task OnGet(int id)
        {
            //el que nos va abuscar y traer el ID
            Curso = await _contexto.Curso.FindAsync(id);
        }

        public async Task<IActionResult> OnPost()
        {
            //valido el modelo, con los requerimientos que van a parar a la base de datos
            if (ModelState.IsValid)
            {
                var CursoDesdeBD = await _contexto.Curso.FindAsync(Curso.Id);

                CursoDesdeBD.NombreCurso = Curso.NombreCurso;
                CursoDesdeBD.CantidadClases = Curso.CantidadClases;
                CursoDesdeBD.Precio = Curso.Precio;

                _contexto.SaveChangesAsync();
                return RedirectToPage("Index");
            }

            return RedirectToPage("");

            
        }
        
    }
}
