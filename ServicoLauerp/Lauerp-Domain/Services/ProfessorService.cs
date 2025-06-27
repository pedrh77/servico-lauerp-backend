using AutoMapper;
using Lauerp_Domain.DTOs.Professor;
using Lauerp_Domain.Interfaces;
using Lauerp_Domain.Models;

namespace Lauerp_Domain.Services
{
    public class ProfessorService(IProfessorRepository _professorRepository, IMapper _mapper) : IProfessorService
    {
        public async Task<int> AddProfessorAsync(NovoProfessorDTO request)
        {
            return await _professorRepository.AddProfessorAsync(_mapper.Map<Professor>(request));
        }

        public async Task<Professor> BuscaProfessorById(int professorId)
        {
            return await _professorRepository.BuscaProfessorById(professorId);
        }

        public async Task<List<ProfessorDTO>> BuscaProfessoresAsync()
        {
            return _mapper.Map<List<ProfessorDTO>>(await _professorRepository.BuscaProfessoresAsync());
        }
    }
}
