using Lauerp_Domain.DTOs.Aulas;

namespace Lauerp_Domain.Interfaces
{
    public interface IAulaService
    {
        Task RegistraAulaAsync(RegistraNovaAulaDTO request);
    }
}
