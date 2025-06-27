using Lauerp_Domain.DTOs.Professor;
using Lauerp_Domain.Models;

namespace Lauerp_Domain.Interfaces
{
    public interface IProfessorService
    {
        Task<int> AddProfessorAsync(NovoProfessorDTO request);
        Task<Professor> BuscaProfessorById(int professorId);
    }
}
