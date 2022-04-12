using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NetRazorApp.Modelos;
using NetRazorApp.wwwroot.Datos;

namespace NetRazorApp.Pages.Profesores
{
    public class IndexModel : PageModel
    {
        private readonly NetRazorAppDBContext _contexto;
        public IndexModel(NetRazorAppDBContext contexto)
        {
            _contexto = contexto;
        }

        public IEnumerable<Profesor> Profesores { get; set; }
        public async Task OnGet()
        {
            Profesores = await _contexto.Profesor.ToListAsync();
        }
    }
}
