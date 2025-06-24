namespace Lauerp_Domain.Models
{
    public class Presenca : EntityBase
    {
        public int Id { get; set; }

        public int JogadorId { get; set; }
        public Jogador Jogador { get; set; }

        public int EsporteId { get; set; }
        public Esporte Esporte { get; set; }

        public bool Presente { get; set; }
        public DateTime Data { get; set; }
    }
}
