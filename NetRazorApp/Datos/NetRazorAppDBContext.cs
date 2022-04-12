using Microsoft.EntityFrameworkCore;
using NetRazorApp.Modelos;

namespace NetRazorApp.wwwroot.Datos
{
    public class NetRazorAppDBContext : DbContext
    {
        //DB Context???
        public NetRazorAppDBContext(DbContextOptions<NetRazorAppDBContext> options): base(options)
        {

        }

        //Modelos
        public DbSet<Curso> Curso { get; set; }
        public DbSet<Alumno> Alumno { get; set; }
        public DbSet<Profesor> Profesor { get; set; }
    }
}
