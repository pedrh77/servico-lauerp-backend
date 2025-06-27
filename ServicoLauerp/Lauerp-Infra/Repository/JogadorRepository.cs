using Lauerp_Domain.Interfaces;
using Lauerp_Domain.Models;
using Lauerp_Infra.Database;
using Microsoft.EntityFrameworkCore;

namespace Lauerp_Infra.Repository
{
    public class JogadorRepository(LauerpPostgreDbContext _dbcontext) : IJogadorRepository
    {
        public async Task<Jogador> AddJogadorAsync(Jogador jogador)
        {
            jogador.AdicionaDadosBase();
            await _dbcontext.AddAsync(jogador);
            await _dbcontext.SaveChangesAsync();
            return jogador;

        }

        public async Task<Jogador> BuscaJogadorByMatricula(string matricula)
        {
            return await _dbcontext.Jogadores.FirstOrDefaultAsync(x => x.Matricula.Equals(matricula));
        }

        public async Task<Jogador> BuscarJogadorById(int jogadorId)
        {
            return await _dbcontext.Jogadores.FirstOrDefaultAsync(x => x.Id.Equals(jogadorId));
        }
    }
}
