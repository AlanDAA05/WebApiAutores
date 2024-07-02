using System.ComponentModel.DataAnnotations;

namespace WebApiAutores.Dto
{
    public class MundialDto
    {
        [Key]
        public int IdMundial { get; set; }
        public string Pais { get; set; }
        public int IdSeleccion { get; set; }
        public DateTime FInicial { get; set; }
        public DateTime FFinal { get; set; }
       




    }
}
