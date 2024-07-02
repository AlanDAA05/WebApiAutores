using System.ComponentModel.DataAnnotations;

namespace WebApiAutores.Dto
{
    public class LibreriaCreacionDTO
    {
        public string Titulo { get; set; }
        public int id { get; set; }
        [Required(ErrorMessage = "Se requiere Editorial ")]
        public string Editorial { get; set; } 

    }
}
