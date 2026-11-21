using AutoMapper;
using WebApi.Dtos;
using WebApi.Models;

namespace WebApi.Profiles
{
    public class CursosProfile : Profile
    {
        public CursosProfile()
        {
            CreateMap<Curso, CursoDto>().ReverseMap();
        }
    }
}
