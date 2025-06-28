namespace Lauerp_Domain.DTOs.Eventos;

public class EventoResponseDTO
{
    public int Id { get; set; }
    public string Titulo { get; set; }
    public string Descricao { get; set; }
    public DateTime DataHora { get; set; }
    public string Localizacao { get; set; }
}
