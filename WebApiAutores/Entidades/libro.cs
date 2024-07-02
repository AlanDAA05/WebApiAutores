namespace WebApiAutores.Entidades
{
    public class libro
    {
        public int Id {get; set;}   
        public string Titulo { get; set;}
        public int AutorId {  get; set;}  
        public Autor Autor { get; set;}
         
       // public List<libreria> Librerias { get; set;}
    }
}
