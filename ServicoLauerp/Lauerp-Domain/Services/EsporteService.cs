using AutoMapper;
using Lauerp_Domain.DTOs.Esportes;
using Lauerp_Domain.Interfaces;
using Lauerp_Domain.Models;

namespace Lauerp_Domain.Services
{
    public class EsporteService(IMapper _mapper, IEsporteRepository _esporteRepository) : IEsporteService
    {
        public async Task<Esporte> BuscaEsporteById(int esporteId)
        {
            return await _esporteRepository.BuscaEsporteById(esporteId);
        }

        public async Task<Esporte> RegistraNovoEsporteAsync(NovoEsporteRequestDTO request)
        {
            return await _esporteRepository.AddEsporteAsync(_mapper.Map<Esporte>(request));
        }
    }
}
