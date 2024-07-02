using Microsoft.EntityFrameworkCore;
using WebApiAutores.Entidades;

namespace WebApiAutores
{
    public class ApplicationDbContext : DbContext
    {
        internal object libros;

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Autor> Autores { get; set; }
        public DbSet<libro> Libros { get; set; }
        public DbSet<libreria> Librerias { get; set; }
    }
}
