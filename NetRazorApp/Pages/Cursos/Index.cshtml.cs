using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NetRazorApp.Modelos;
using Microsoft.EntityFrameworkCore;
using NetRazorApp.wwwroot.Datos;

namespace NetRazorApp.Pages.Cursos
{
    public class IndexModel : PageModel
    {

        //logica
        //creo una propiedad que me almacee el contezto y luego una propiedad que me almacene el valor de la propiedad y genero otra propiedad que es una lista de los cursos
        private readonly NetRazorAppDBContext _contexto;
        public IndexModel(NetRazorAppDBContext contexto)
        {
            _contexto = contexto;
        }
        
        public IEnumerable<Curso> Cursos { get; set; }
        public async Task OnGet()
        {
            Cursos = await _contexto.Curso.ToListAsync();
        }
    }
}
