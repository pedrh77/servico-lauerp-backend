using Lauerp_Domain.DTOs.Presenca;

namespace Lauerp_Aplication.Interfaces
{
    public interface IPresencaApplication
    {
        Task RegistraPresencaAsync(ResgistraPresencaDTO request);
    }
}
