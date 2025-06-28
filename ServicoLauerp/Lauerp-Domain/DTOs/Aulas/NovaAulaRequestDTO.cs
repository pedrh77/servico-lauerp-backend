namespace Lauerp_Domain.DTOs.Aulas
{
    public class NovaAulaRequestDTO
    {
        public int ProfessorId { get; set; }
        public int EsporteId { get; set; }
        public DateTime Data { get; set; }
        public int Semestre { get; set; }
        public int Ano { get; set; }
    }
}
