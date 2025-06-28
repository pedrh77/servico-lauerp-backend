namespace Lauerp_Domain.DTOs.Aulas
{
    public class MatricularJogadorRequestDTO
    {
        public string Matricula { get; set; }
        public int AulaId { get; set; }
        public int Ano { get; set; }
        public int Semestre { get; set; }
    }
}
