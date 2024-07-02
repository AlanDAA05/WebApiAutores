using System.ComponentModel.DataAnnotations;

namespace WebApiAutores.Dto
{
    public class SeleccionDto
    {
        [Key]
        public int IdSeleccion { get; set; }
        public string Nombre { get; set; }
        public string Alias { get; set; }
        public DateOnly FAfiliacion { get; set; }
        public List<MundialDto> Mundiales { get; set;}
        
    }
}
