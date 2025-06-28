using Lauerp_Domain.Enum;
using Lauerp_Domain.Models;

namespace Lauerp_Domain.Interfaces
{
    public interface IUsuarioRepository
    {
        Task AddUsuarioAsync(Usuario usuario);
        Task<Usuario> BuscaUsuarioById(int professorId, TipoUsuario tipoUsuario);
        Task<Usuario> BuscaUsuarioJogadorByMatricula(string matricula);
        Task<Usuario> BuscaUsuarioLoginAsync(string email, string senha);
    }
}
