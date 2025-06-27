using Lauerp_Domain.DTOs.Presenca;
using Lauerp_Domain.Interfaces;
using Lauerp_Domain.Models;

namespace Lauerp_Domain.Services
{
    public class PresencaService(IPresencaRepository _presencaRepository,
        IJogadorService _jogadorService,IAulaService _aulaService) : IPresencaService
    {
        public async Task RegistraPresencaAsync(ResgistraPresencaDTO request)
        {
            
            Jogador responseJogador = await _jogadorService.BuscaJogadorById(request.JogadorId);

            await  _presencaRepository.RegistraPresencaAsync(request);


        }
    }
}
