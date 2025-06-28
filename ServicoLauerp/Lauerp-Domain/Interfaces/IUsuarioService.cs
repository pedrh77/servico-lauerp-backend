using Lauerp_Domain.DTOs.Login;
using Lauerp_Domain.DTOs.Usuario;
using Lauerp_Domain.Models;

namespace Lauerp_Domain.Interfaces
{
    public interface IUsuarioService
    {
        Task RegistraNovoUsuario(NovoUsuarioRequestDTO request);
        Task<Usuario> ValidaLoginUsuario(LoginRequestDTO login);
    }
}
