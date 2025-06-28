namespace Lauerp_Domain.Models
{
    public class Aula
    {
        public int Id { get; set; }
        public int UsuarioId{ get; set; }
        public Usuario usuario{ get; set; }
        public int EsporteId { get; set; }
        public Esporte Esporte { get; set; }
        public int Semestre { get; set; }
        public int Ano { get; set; }
    }
}
