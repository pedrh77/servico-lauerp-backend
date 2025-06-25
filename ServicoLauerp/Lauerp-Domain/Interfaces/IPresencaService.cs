using Lauerp_Domain.DTOs.Presenca;

namespace Lauerp_Domain.Interfaces
{
    public interface IPresencaService
    {
        Task RegistraPresencaAsync(ResgistraPresencaDTO request);
    }
}
