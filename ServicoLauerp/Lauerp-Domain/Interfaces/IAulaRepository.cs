using Lauerp_Domain.Models;

namespace Lauerp_Domain.Interfaces
{
    public interface IAulaRepository
    {
        Task<Aula> AddAulaAsync(Aula aula);
        Task<Aula> BuscarAulaById(int aulaId);
    }
}
