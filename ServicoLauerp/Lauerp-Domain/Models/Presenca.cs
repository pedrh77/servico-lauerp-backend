namespace Lauerp_Domain.Models
{
    public class Presenca : EntityBase
    {
        public int Id { get; set; }
        public int MatriculaId { get; set; }
        public Matricula Matricula { get; set; }
        public bool Presente { get; set; }
        public DateTime Data { get; set; }
    }
}
