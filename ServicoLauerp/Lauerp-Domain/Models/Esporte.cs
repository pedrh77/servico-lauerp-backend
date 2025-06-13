namespace Lauerp_Domain.Models;

public class Esporte : EntityBase
{
    public int Id { get; set; }
    string Titulo { get; set; }
    string Descricao { get; set; }
    DateTime CriadaEm { get; set; }

}
