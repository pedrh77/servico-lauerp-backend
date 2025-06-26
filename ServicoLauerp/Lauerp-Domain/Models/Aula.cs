namespace Lauerp_Domain.Models
{
    public class Aula
    {
        public int Id { get; set; }

        public int ProfessorId { get; set; }
        public Professor Professor { get; set; }

        public int EsporteId { get; set; }
        public Esporte Esporte { get; set; }
    }
}
