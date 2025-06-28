using Lauerp_Domain.DTOs.Jogador;
using Lauerp_Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lauerp_Domain.Interfaces
{
    public interface IJogadorService
    {
        Task<Jogador> BuscaJogadorById(int jogadorId);
        Task<Matricula> MatricularJogadorAsync(MatricularJogadorAulaRequestDTO request);
        Task<Jogador> CadastraJogadorAsync(NovoJogadorRequestDTO request);
    }
}
