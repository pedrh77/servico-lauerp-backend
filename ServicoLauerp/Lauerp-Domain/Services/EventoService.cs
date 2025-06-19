using AutoMapper;
using Lauerp_Domain.DTOs.Eventos;
using Lauerp_Domain.Interfaces;
using Lauerp_Domain.Models;

namespace Lauerp_Domain.Services
{
    public class EventoService(IEventoRepository _eventoRepository, IMapper _mapper) : IEventoService
    {
        public async Task<List<EventoDTO>> ListaEventosAsync() => _mapper.Map<List<EventoDTO>>(await _eventoRepository.ListaEventosAsync());


        public async Task<EventoDTO> ListaEventosByIdAsync(int Id) => _mapper.Map<EventoDTO>(await _eventoRepository.ListaEventosByIdAsync(Id));

        public async Task<Evento> NovoEventoAsync(NovoEventoDTO request)
        {
            return await _eventoRepository.AddEventoAsync(_mapper.Map<Evento>(request));

        }
    }
}
