using AutoMapper;
using WebApiAutores.Dto;
using WebApiAutores.Entidades;

namespace WebApiAutores.Utilidades
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<LibreriaCreacionDTO, libreria>();
        }
    }
}
