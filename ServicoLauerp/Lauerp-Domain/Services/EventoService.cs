using AutoMapper;
using Lauerp_Domain.DTOs.Eventos;
using Lauerp_Domain.Interfaces;
using Lauerp_Domain.Models;

namespace Lauerp_Domain.Services
{
    public class EventoService(IEventoRepository _eventoRepository, IMapper _mapper) : IEventoService
    {
        public async Task<List<EventoResponseDTO>> ListaEventosAsync() => _mapper.Map<List<EventoResponseDTO>>(await _eventoRepository.ListaEventosAsync());


        public async Task<EventoResponseDTO> ListaEventosByIdAsync(int Id) => _mapper.Map<EventoResponseDTO>(await _eventoRepository.ListaEventosByIdAsync(Id));

        public async Task<int> NovoEventoAsync(NovoEventoRequestDTO request)
        {
            return await _eventoRepository.AddEventoAsync(_mapper.Map<Evento>(request));

        }
    }
}
