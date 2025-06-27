using Lauerp_Domain.DTOs.Esportes;
using Lauerp_Domain.Models;

namespace Lauerp_Domain.Interfaces
{
    public interface IEsporteService
    {
        Task<Esporte> BuscaEsporteById(int esporteId);
        Task<Esporte> RegistraNovoEsporteAsync(NovoEsporteDTO request);
    }
}
