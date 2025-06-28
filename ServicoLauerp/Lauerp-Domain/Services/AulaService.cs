using AutoMapper;
using Lauerp_Domain.DTOs.Aulas;
using Lauerp_Domain.Enum;
using Lauerp_Domain.Interfaces;
using Lauerp_Domain.Models;

namespace Lauerp_Domain.Services
{
    public class AulaService(IAulaRepository _aulaRepository,
        IMatriculaRepository _matriculaRepository,
        IUsuarioRepository _usuarioService,
        IEsporteService _esporteService,
        IMapper _mapper) : IAulaService
    {
        public async Task RegistraAulaAsync(NovaAulaRequestDTO request)
        {
            Usuario professor = await _usuarioService.BuscaUsuarioById(request.ProfessorId, TipoUsuario.Professor);
            Esporte esporte = await _esporteService.BuscaEsporteById(request.EsporteId);

            if (professor == null) throw new Exception();
            if (esporte == null) throw new Exception();

            await _aulaRepository.AddAulaAsync(_mapper.Map<Aula>(request));
        }

        public async Task<Matricula> MatricularJogadorAsync(MatricularJogadorRequestDTO request)
        {
            try
            {

                Usuario jogador = await _usuarioService.BuscaUsuarioJogadorByMatricula(request.Matricula);
                var aula = await _aulaRepository.BuscarAulaById(request.AulaId);

                if (jogador == null) { throw new NotImplementedException(); }
                if (aula == null) { throw new NotImplementedException(); }

                Matricula matriculaJogador = await _matriculaRepository.BuscaMatriculaEmAulaAsync(jogador.Id, request.AulaId, request.Ano, request.Semestre);

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
