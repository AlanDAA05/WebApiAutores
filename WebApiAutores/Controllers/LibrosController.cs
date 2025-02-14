﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiAutores.Entidades;

namespace WebApiAutores.Controllers
{
    [ApiController]
    [Route("api/libros")]
    public class LibrosController:ControllerBase
    {
        private ApplicationDbContext context;
        private int id;

        public LibrosController(ApplicationDbContext context)
        { 
            this.context = context;
        }
        [HttpGet("{id:int}")]
        public async Task<ActionResult<libro>> Get(int id)
        {
            return await context.Libros.FirstOrDefaultAsync(x => x.Id == id);
        } 
        [HttpPost]
        public async Task<ActionResult> Post(libro libro)
        {
              var existeAutor = await context.Autores.AnyAsync(x => x.Id == libro.AutorId);

            if (!existeAutor) 
            {
                return BadRequest($"no existe el autor de id: {libro.AutorId}");            
            }

            context.Add(libro);
            await context.SaveChangesAsync();
            return Ok(); 
        }

    } 
}
 