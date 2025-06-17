namespace Lauerp_Domain.Models;

public class Evento : EntityBase
{
    public int Id { get; set; }
    public string Titulo { get; set; }
    public string Descricao { get; set; }
    public DateTime DataHora { get; set; }
    public string Localizacao { get; set; }
}
