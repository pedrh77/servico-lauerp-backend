using AutoMapper;
using Lauerp_Domain.DTOs.Jogador;
using Lauerp_Domain.Interfaces;
using Lauerp_Domain.Models;

namespace Lauerp_Domain.Services
{
    public class JogadorService(IMapper _mapper,
        IJogadorRepository _jogadorRepository,
        IAulaRepository _aulaRepository, IMatriculaRepository _matriculaRepository) : IJogadorService

    {
        public async Task<Jogador> BuscaJogadorById(int jogadorId)
        {
            return await _jogadorRepository.BuscarJogadorById(jogadorId);
        }

        public async Task<Jogador> CadastraJogadorAsync(NovoJogadorDTO request)
        {
            var jogador = new Jogador();
            jogador = await _jogadorRepository.BuscaJogadorByMatricula(request.Matricula);

            if (jogador == null)
                jogador = await _jogadorRepository.AddJogadorAsync(_mapper.Map<Jogador>(request));

            return jogador;
        }

        public async Task<Matricula> MatricularJogadorAsync(MatricularJogadorAulaDTO request)
        {
            try
            {
                var jogador = await _jogadorRepository.BuscarJogadorById(request.JogadorId);
                var aula = await _aulaRepository.BuscarAulaById(request.AulaId);

                if (jogador == null) { throw new NotImplementedException(); }
                if (aula == null) { throw new NotImplementedException(); }

                Matricula matriculaJogador = await _matriculaRepository.BuscaMatriculaEmAulaAsync(request.JogadorId, request.AulaId, request.Ano, request.Semestre);

                if (matriculaJogador == null)
                {
                    return await _matriculaRepository.MatricularJogadorAsync(_mapper.Map<Matricula>(request));
                }
                return matriculaJogador;
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
