namespace Lauerp_Domain.DTOs.Jogador
{
    public class NovoJogadorRequestDTO
    {
        public string Nome { get; set; }
        public string Matricula { get; set; }
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
    }
}
