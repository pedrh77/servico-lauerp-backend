namespace Lauerp_Domain.DTOs.Jogador
{
    public class MatricularJogadorAulaRequestDTO
    {
        public int JogadorId { get; set; }
        public int AulaId { get; set; }
        public int Ano { get; set; }
        public int Semestre { get; set; }
    }
}
