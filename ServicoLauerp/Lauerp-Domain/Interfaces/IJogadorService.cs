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
        Task<Jogador> BuscaJogadroById(int jogadorId);
    }
}
