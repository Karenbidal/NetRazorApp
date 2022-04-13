using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NetRazorApp.Modelos;
using NetRazorApp.wwwroot.Datos;

namespace NetRazorApp.Pages.Cursos
{
    public class CrearModel : PageModel
    {
        private readonly NetRazorAppDBContext _contexto;
        public CrearModel(NetRazorAppDBContext contexto)
        {
            _contexto = contexto;
        }

        //vincular la propiedad(curso) de esta parte logica con la de bootstrap
        //bind property vincula la propiedad para que la podamos acceder desde el formulario
        [BindProperty]
        public Curso Curso { get; set; }

        //creo un metodo post, que ya existe, pero me subescribe el funcionamiento
        public async  Task<IActionResult> OnPost()
        {
            //valido el modelo, con los requerimientos que van a parar a la base de datos
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Curso.FechaCreacion = DateTime.Now;

            _contexto.Add(Curso);
            await _contexto.SaveChangesAsync();
            return RedirectToPage("Index");
        }
        public void OnGet()
        {
        }
    }
}
