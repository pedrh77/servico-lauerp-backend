using Lauerp_Domain.Models;

namespace Lauerp_Domain.Interfaces
{
    public interface IAulaRepository
    {
        Task<Aula> BuscarAulaById(int aulaId);
    }
}
