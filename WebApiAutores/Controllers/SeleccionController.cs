using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using System.Threading;
using WebApiAutores.Dto;

namespace WebApiAutores.Controllers
{
    [ApiController]
    [Route("api/sele")]
    public class SeleccionController
    {
        private readonly IMapper _mapper;

        List<SeleccionDto> Concacaf = new List<SeleccionDto>();
        static List<MundialDto> Mundiales = new List<MundialDto>();


        public SeleccionController()
        {

            MundialDto Mu = new MundialDto();
            Mu.IdMundial = 1;
            Mu.Pais = "URUGUAY";
            Mu.IdSeleccion = 1;
            Mu.FInicial = new DateTime(1989, 4, 9);
            Mu.FFinal = new DateTime(1989, 5, 9);


            Mundiales.Add(Mu);

            MundialDto MuEsp = new MundialDto();
            MuEsp.IdMundial = 2;
            MuEsp.Pais = "españa";
            MuEsp.IdSeleccion = 2;
            MuEsp.FInicial = new DateTime(1998, 5, 5);
            MuEsp.FFinal = DateTime.Now;

            Mundiales.Add(MuEsp);

            MundialDto MuSudafrica = new MundialDto();
            MuSudafrica.IdMundial = 3;
            MuSudafrica.Pais = "sudafrica";
            MuSudafrica.IdSeleccion = 3;
            MuSudafrica.FInicial = new DateTime(2002, 5, 5);
            MuSudafrica.FFinal = new DateTime(2002, 7, 5);

            Mundiales.Add(MuSudafrica);

            SeleccionDto Mexico = new SeleccionDto();
            Mexico.Nombre = "MEXICO";
            Mexico.Alias = "DECEPCION";
            Mexico.IdSeleccion = 1;
            Mexico.FAfiliacion = new DateOnly(1994, 6, 17);
            Mexico.Mundiales = Mundiales;

     
            Concacaf.Add(Mexico);

            SeleccionDto USA = new SeleccionDto();
            string nombreSeleccion = "EstadosUnidos";
            USA.Nombre = nombreSeleccion;
            USA.Alias = "DreamTeam";
            USA.IdSeleccion = 2;
            USA.FAfiliacion = new DateOnly (1998, 5, 5);
            List<MundialDto>Mespaña = new List<MundialDto>();
            Mespaña.Add(MuEsp);
            USA.Mundiales = Mespaña;

            Concacaf.Add(USA);

  
;        }

        [HttpGet]
        public List<SeleccionDto> GetAll()
        {
            return Concacaf;
        }

        /* [HttpGet ("by-date")]

         public List<SeleccionDto> Get(DateTime starDate, DateTime endDate)
         {

         }*/
        [HttpGet ("mundiales")]
        public List<MundialDto> GetAllMun()
        {
            return Mundiales;
        }

        [HttpPost]

        public List<MundialDto> Create (MundialDto entrada)
        {
            Mundiales.Add(entrada);

            return Mundiales;
        }
    }

    


    

}
