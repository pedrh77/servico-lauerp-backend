using Lauerp_Domain.Interfaces;
using Lauerp_Domain.Models;

namespace Lauerp_Domain.Services
{
    public class JogadorServices(IJogadorRepository _jogadorRepository) : IJogadorService
    {
        public Task<Jogador> BuscaJogadroById(int jogadorId)
        {
            throw new NotImplementedException();
        }
    }
}
