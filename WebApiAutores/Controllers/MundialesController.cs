using Microsoft.AspNetCore.Mvc;
using WebApiAutores.Dto;

namespace WebApiAutores.Controllers
{
    [ApiController]
    [Route("api/mun")]
    public class MundialesController
    {

        List<MundialDto> Mundiales = new List<MundialDto>();

        public MundialesController()
        {

            MundialDto Mu = new MundialDto();
            Mu.IdMundial = 1;
            Mu.Pais = "URUGUAY";
            Mu.IdSeleccion = 1;
            Mu.FInicial = new DateTime(1989, 4, 9);
            Mu.FFinal = new DateTime(1989,5, 9);

         
            Mundiales.Add(Mu);

            MundialDto MuEsp = new MundialDto();
            MuEsp.IdMundial = 2;
            MuEsp.Pais = "españa";
            MuEsp.IdSeleccion= 2;
            MuEsp.FInicial = new DateTime(1998,5,5);
            MuEsp.FFinal = DateTime.Now;

            Mundiales.Add(MuEsp);

            MundialDto MuSudafrica = new MundialDto();
            MuSudafrica.IdMundial = 3;
            MuSudafrica.Pais = "sudafrica";
            MuSudafrica.IdSeleccion = 3;
            MuSudafrica.FInicial = new DateTime(2002, 5, 5);
            MuSudafrica.FFinal = new DateTime(2002, 7, 5);

            Mundiales.Add(MuEsp);

        }
        [HttpGet]
        public List<MundialDto> Get()
        {
            return Mundiales;
        }
    }
}
