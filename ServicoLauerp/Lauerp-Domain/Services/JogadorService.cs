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

        public async Task MatricularJogadorAsync(MatricularJogadorAulaDTO request)
        {
            await _jogadorRepository.BuscarJogadorById(request.JogadorId);
            await _aulaRepository.BuscarAulaById(request.AulaId);
            await _matriculaRepository.MatricularJogadorAsync(_mapper.Map<Matricula>(request));
        }
    }
}
