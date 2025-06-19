using System.ComponentModel.DataAnnotations;

namespace Lauerp_Domain.DTOs.Eventos;

public class NovoEventoDTO
{

    [Required]
    public string Titulo { get; set; }

    [Required]
    public string Descricao { get; set; }

    [Required]
    public DateTime DataHora { get; set; }

    [Required]
    public string Localizacao { get; set; }
}

