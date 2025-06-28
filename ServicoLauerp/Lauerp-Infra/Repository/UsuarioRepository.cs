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

        public async Task<Usuario> BuscaUsuarioByCPF(string Cpf, TipoUsuario tipoUsuario)
        {
            return await _context.Usuarios.FirstOrDefaultAsync(x => x.CPF.Equals(Cpf) && x.TipoUsuario.Equals(tipoUsuario) && x.Deleted.Equals(false));
        }


        public async Task<Usuario> BuscaUsuarioById(int UsuarioId, TipoUsuario tipoUsuario)
        {
            return await _context.Usuarios.FirstOrDefaultAsync(x => x.Id.Equals(UsuarioId) && x.TipoUsuario.Equals(tipoUsuario) && x.Deleted.Equals(false));
        }

        public async Task<Usuario> BuscaUsuarioJogadorByMatricula(string matricula)
        {
            return await _context.Usuarios.FirstOrDefaultAsync(x => x.Matricula.Equals(matricula) && x.Deleted.Equals(false));
        }

        public async Task<Usuario> BuscaUsuarioLoginAsync(string email, string senha)
        {
            return await _context.Usuarios.FirstOrDefaultAsync(x => x.Email.Equals(email) && x.SenhaHash.Equals(senha) && x.Deleted.Equals(false));
        }
    }
}
