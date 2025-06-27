namespace Lauerp_Domain.DTOs.Presenca;

public class ResgistraPresencaDTO
{
    public int JogadorId { get; set; }
    public int AulaId { get; set; }
    public bool Presente { get; set; }
    public DateTime Data { get; set; }

}
