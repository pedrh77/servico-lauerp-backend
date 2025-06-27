using Lauerp_Domain.Models;

namespace Lauerp_Domain.Interfaces
{
    public interface IMatriculaRepository
    {
        Task<Matricula> BuscaMatriculaEmAulaAsync(int jogadorId, int aulaId, int ano, int semestre);
        Task<Matricula> MatricularJogadorAsync(Matricula request);
    }
}
