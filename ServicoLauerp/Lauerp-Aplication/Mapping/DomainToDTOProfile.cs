using AutoMapper;
using Lauerp_Domain.DTOs.Eventos;
using Lauerp_Domain.DTOs.Professor;
using Lauerp_Domain.Models;

namespace Lauerp_Aplication.Mapping;

public class DomainToDTOProfile : Profile
{
    public DomainToDTOProfile()
    {
        CreateMap<Evento, EventoDTO>().ReverseMap();
        CreateMap<NovoEventoDTO, Evento>().ReverseMap();


        CreateMap<Professor, ProfessorDTO>().ReverseMap();
        CreateMap<NovoProfessorDTO, Professor>().ReverseMap();

    }
}
