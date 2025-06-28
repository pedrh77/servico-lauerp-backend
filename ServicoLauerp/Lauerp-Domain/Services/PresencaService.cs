using Lauerp_Domain.DTOs.Presenca;
using Lauerp_Domain.Interfaces;

namespace Lauerp_Domain.Services
{
    public class PresencaService(IPresencaRepository _presencaRepository,
        IUsuarioService _usuarioService, IAulaService _aulaService) : IPresencaService
    {
        public async Task RegistraPresencaAsync(ResgistraPresencaRequestDTO request)
        {

            //Jogador responseJogador = await _usuarioService.BuscaUsuario(request.JogadorId);

            await _presencaRepository.RegistraPresencaAsync(request);


        }
    }
}
