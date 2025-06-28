using Lauerp_Domain.DTOs.Aulas;

namespace Lauerp_Domain.Interfaces
{
    public interface IAulaService
    {
        Task RegistraAulaAsync(NovaAulaRequestDTO request);
    }
}
