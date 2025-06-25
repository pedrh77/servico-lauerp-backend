using Lauerp_Aplication.Interfaces;
using Lauerp_Domain.DTOs.Presenca;
using Lauerp_Domain.Interfaces;

namespace Lauerp_Aplication.ApplicationService
{
    public class PresencaApplicationService(IPresencaService _presencaService) : IPresencaApplication
    {
        public Task RegistraPresencaAsync(ResgistraPresencaDTO request)
        {
            throw new NotImplementedException();
        }
    }
}
