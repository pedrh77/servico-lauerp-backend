using AutoMapper;
using Lauerp_Domain.DTOs.Aulas;
using Lauerp_Domain.Interfaces;
using Lauerp_Domain.Models;

namespace Lauerp_Domain.Services
{
    public class AulaService(IAulaRepository _aulaRepository, IProfessorService _professorService, IEsporteService _esporteService, IMapper _mapper) : IAulaService
    {
        public async Task RegistraAulaAsync(NovaAulaRequestDTO request)
        {
            Professor professor = await _professorService.BuscaProfessorById(request.ProfessorId);
            Esporte esporte = await _esporteService.BuscaEsporteById(request.EsporteId);

            if (professor == null) throw new Exception();
            if (esporte == null) throw new Exception();

            await _aulaRepository.AddAulaAsync(_mapper.Map<Aula>(request));




        }
    }
}
                                                                                                                                                                           