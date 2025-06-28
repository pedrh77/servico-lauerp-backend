using Lauerp_Domain.Enum;
using Lauerp_Domain.Interfaces;
using Lauerp_Domain.Models;
using Lauerp_Infra.Database;
using Microsoft.EntityFrameworkCore;

namespace Lauerp_Infra.Repository
{
    public class UsuarioRepository(LauerpPostgreDbContext _context) : IUsuarioRepository
    {
        public async Task AddUsuarioAsync(Usuario usuario)
        {
            usuario.AdicionaDadosBase();
            await _context.AddAsync(usuario);
            await _context.SaveChangesAsync();
        }

        public Task<Usuario> BuscaUsuarioById(int professorId, TipoUsuario tipoUsuario)
        {
            throw new NotImplementedException();
        }

        public Task<Usuario> BuscaUsuarioJogadorByMatricula(string matricula)
        {
            throw new NotImplementedException();
        }

        public async Task<Usuario> BuscaUsuarioLoginAsync(string email, string senha)
        {
            return await _context.Usuarios.FirstOrDefaultAsync(x => x.Email.Equals(email) && x.SenhaHash.Equals(senha) && x.Deleted.Equals(false));
        }
    }
}
