using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiAutores.Dto;
using WebApiAutores.Entidades;
using WebApiAutores.Migrations;

namespace WebApiAutores.Controllers
{
    [ApiController]
    [Route("api/libreria")]
   public class LibreriaControllers:ControllerBase
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public LibreriaControllers(ApplicationDbContext context, IMapper mapper)
        { 
            this.context = context;
            this.mapper = mapper;
        }
        [HttpGet ("{id:int}")]
        public async Task<ActionResult<libreria>> Get ([FromHeader] int id, [FromQuery] string nombre)
        {
            return await context.Librerias.FirstOrDefaultAsync(x => x.id == id);
        }

        [HttpPost ]
        public async Task<ActionResult> Post ([FromBody] LibreriaCreacionDTO libreriaCreacionDTO)
        { 
            var existeLibro = await context.Libros.AnyAsync(x => x.Titulo == libreriaCreacionDTO.Titulo);
            if (!existeLibro) 
            {
                return BadRequest($"no existe el libro de Id: { libreriaCreacionDTO.Titulo}");
            }
            var libreria = mapper.Map<libreria>(libreriaCreacionDTO);
         
            
            context.Add(libreria);
            await context.SaveChangesAsync();
            return Ok();
        }
    }
}
 