namespace Lauerp_Domain.Models
{
    public class Matricula : EntityBase
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
        public int AulaId { get; set; }
        public Aula aula { get; set; }
        public int Semestre { get; set; }
        public int Ano { get; set; }


    }
}
