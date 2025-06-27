using Lauerp_Domain.DTOs.Presenca;
using Lauerp_Domain.Interfaces;

namespace Lauerp_Domain.Services
{
    public class PresencaService(IPresencaRepository _presencaRepository,
        IJogadorService _jogadorService, IAulaService _aulaService) : IPresencaService
    {
        public async Task RegistraPresencaAsync(ResgistraPresencaDTO request)
        {

            throw new NotImplementedException();


        }
    }
}
