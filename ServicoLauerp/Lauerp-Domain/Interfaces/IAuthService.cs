using Lauerp_Domain.DTOs.Login;

namespace Lauerp_Domain.Interfaces
{
    public interface IAuthService
    {
        Task<LoginResponseDTO> AutenticarAsync(LoginRequestDTO login);
    }
}
