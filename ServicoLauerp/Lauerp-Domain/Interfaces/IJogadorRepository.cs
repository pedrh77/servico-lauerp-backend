using Lauerp_Domain.Models;

namespace Lauerp_Domain.Interfaces
{
    public interface IJogadorRepository
    {
        Task<Jogador> BuscarJogadorById(int jogadorId);
        Task<Jogador> BuscaJogadorByMatricula(string matricula);
        Task<Jogador> AddJogadorAsync(Jogador jogador);
    }
}
