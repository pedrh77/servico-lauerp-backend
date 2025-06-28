using AutoMapper;
using Lauerp_Domain.DTOs.Aulas;
using Lauerp_Domain.DTOs.Esportes;
using Lauerp_Domain.DTOs.Eventos;
using Lauerp_Domain.DTOs.Jogador;
using Lauerp_Domain.DTOs.Professor;
using Lauerp_Domain.Models;

namespace Lauerp_Aplication.Mapping;

public class DomainToDTOProfile : Profile
{
    public DomainToDTOProfile()
    {
        CreateMap<Evento, EventoResponseDTO>().ReverseMap();
        CreateMap<NovoEventoRequestDTO, Evento>().ReverseMap();


        CreateMap<Professor, ProfessorDTO>().ReverseMap();
        CreateMap<NovoProfessorDTO, Professor>().ReverseMap();

        CreateMap<NovoJogadorRequestDTO, Jogador>().ReverseMap();

        CreateMap<MatricularJogadorAulaRequestDTO, Matricula>().ReverseMap();

        CreateMap<Esporte, EsporteResponseDTO>().ReverseMap();
        CreateMap<NovoEsporteRequestDTO, Esporte>().ReverseMap();

        CreateMap<NovaAulaRequestDTO, Aula>().ReverseMap();

    }
}
