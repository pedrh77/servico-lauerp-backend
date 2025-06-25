using Lauerp_Domain.Models;

namespace Lauerp_Domain.Interfaces
{
    public interface IEsporteService
    {
        Task<Esporte> BuscaEsporteById(int esporteId);
    }
}
