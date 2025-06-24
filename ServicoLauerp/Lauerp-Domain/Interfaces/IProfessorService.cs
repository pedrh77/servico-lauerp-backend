using Lauerp_Domain.DTOs.Professor;

namespace Lauerp_Domain.Interfaces
{
    public interface IProfessorService
    {
        Task<int> AddProfessorAsync(NovoProfessorDTO request);
    }
}
