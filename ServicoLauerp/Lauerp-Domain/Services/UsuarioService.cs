using AutoMapper;
using Lauerp_Domain.DTOs.Login;
using Lauerp_Domain.DTOs.Usuario;
using Lauerp_Domain.Enum;
using Lauerp_Domain.Interfaces;
using Lauerp_Domain.Models;

namespace Lauerp_Domain.Services
{
    public class UsuarioService(IMapper _mapper, IUsuarioRepository _usuarioRepository, IMd5HashService _hash) : IUsuarioService
    {
        public async Task RegistraNovoUsuario(NovoUsuarioRequestDTO request)
        {
            var usuario = _mapper.Map<Usuario>(request);

            usuario.SenhaHash = await _hash.GerarHashMd5(await AplicarHashSenha(request.Nome, request.CPF));

            Usuario user = await _usuarioRepository.BuscaUsuarioByCPF(request.CPF, request.TipoUsuario);

            if (user != null) throw new NotImplementedException("Usuario para Tipo Escolhido Já existe.");

            if (request.TipoUsuario == TipoUsuario.Jogador)
            {
                if (String.IsNullOrEmpty(request.Matricula))
                {
                    throw new NotImplementedException();
                }
            }
            await _usuarioRepository.AddUsuarioAsync(usuario);
        }

        public async Task<Usuario> ValidaLoginUsuario(LoginRequestDTO login)
        {
            var senhaCoded = await _hash.GerarHashMd5(login.Senha);

            return await _usuarioRepository.BuscaUsuarioLoginAsync(login.Email, senhaCoded);
        }

        private async Task<string> AplicarHashSenha(string Nome, string CPF)
        {
            string nomeParte = Nome != null && Nome.Length >= 5
                ? Nome.Substring(Nome.Length - 5)
            : Nome ?? "";
            string cpfParte = CPF != null && CPF.Length >= 3
            ? CPF.Substring(CPF.Length - 3)
                : CPF ?? "";

            return nomeParte + cpfParte;
        }
    }
}
