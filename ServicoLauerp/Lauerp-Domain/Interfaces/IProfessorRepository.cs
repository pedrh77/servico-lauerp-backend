using Lauerp_Domain.Models;

namespace Lauerp_Domain.Interfaces;

public interface IProfessorRepository
{
    Task<int> AddProfessorAsync(Professor professor);
}
