using Lauerp_Domain.DTOs.Presenca;

namespace Lauerp_Domain.Interfaces
{
    public interface IPresencaRepository
    {
        Task RegistraPresencaAsync(ResgistraPresencaDTO request);
    }
}
