using System.ComponentModel.DataAnnotations;

namespace WebApiAutores.Entidades
{
    public class libreria
    {
        public int id { get;set;}
        [Required(ErrorMessage ="Se requiere Editorial ")]
        public string Editorial  {get;set;}

        public int libroId { get;set;}

        public libro libro { get;set;}


    }
}
