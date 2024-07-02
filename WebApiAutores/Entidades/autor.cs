namespace WebApiAutores.Entidades
{
    public class Autor
    {
        public int Id{ get; set; } 

        public string Nombre { get; set; }

        public List<libro> Libros { get; set; }
    }
}
