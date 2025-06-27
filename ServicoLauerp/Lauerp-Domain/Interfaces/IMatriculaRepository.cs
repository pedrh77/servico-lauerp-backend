using Lauerp_Domain.Models;

namespace Lauerp_Domain.Interfaces
{
    public interface IMatriculaRepository
    {
        Task<Matricula> MatricularJogadorAsync(Matricula request);
    }
}
