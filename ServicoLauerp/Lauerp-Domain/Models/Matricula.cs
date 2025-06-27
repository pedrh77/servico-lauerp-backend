namespace Lauerp_Domain.Models
{
    public class Matricula : EntityBase
    {
        public int Id { get; set; }
        public int JogadorId { get; set; }
        public Jogador jogador { get; set; }
        public int AulaId { get; set; }
        public Aula aula { get; set; }


    }
}
