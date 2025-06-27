using Lauerp_Domain.DTOs.Professor;
using Lauerp_Domain.Models;

namespace Lauerp_Domain.Interfaces;

public interface IProfessorRepository
{
    Task<int> AddProfessorAsync(Professor professor);
    Task<Professor> BuscaProfessorById(int professorId);
    Task<List<Professor>> BuscaProfessoresAsync();
}
