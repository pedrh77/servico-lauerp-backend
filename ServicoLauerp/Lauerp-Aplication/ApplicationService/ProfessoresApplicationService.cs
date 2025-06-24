using Lauerp_Aplication.Interfaces;
using Lauerp_Domain.DTOs.Professor;
using Lauerp_Domain.Interfaces;

namespace Lauerp_Aplication.ApplicationService
{
    public class ProfessoresApplicationService(IProfessorService _professorService) : IProfessoresApplication
    {
        public async Task<int> AddProfessorAsync(NovoProfessorDTO request)
        {
            return await _professorService.AddProfessorAsync(request);
        }
    }
}
