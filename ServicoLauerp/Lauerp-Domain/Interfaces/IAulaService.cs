using Lauerp_Domain.DTOs.Aulas;
using Lauerp_Domain.Models;

namespace Lauerp_Domain.Interfaces
{
    public interface IAulaService
    {
        Task RegistraAulaAsync(NovaAulaRequestDTO request);
        Task<Matricula> MatricularJogadorAsync(MatricularJogadorRequestDTO request);
    }
}
