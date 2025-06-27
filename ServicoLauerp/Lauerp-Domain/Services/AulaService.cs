using Lauerp_Domain.DTOs.Aulas;
using Lauerp_Domain.Interfaces;
using Lauerp_Domain.Models;

namespace Lauerp_Domain.Services
{
    public class AulaService(IAulaRepository _aulaRepository, IProfessorService _professorService, IEsporteService _esporteService) : IAulaService
    {
        public async Task RegistraAulaAsync(RegistraNovaAulaDTO request)
        {
            Professor professor = await _professorService.BuscaProfessorById(request.ProfessorId);
            Esporte esporte = await _esporteService.BuscaEsporteById(request.EsporteId);



        }
    }
}
                                                                                                                                                                           