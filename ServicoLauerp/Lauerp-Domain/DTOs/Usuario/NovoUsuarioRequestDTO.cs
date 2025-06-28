using Lauerp_Domain.Enum;

namespace Lauerp_Domain.DTOs.Usuario
{
    public class NovoUsuarioRequestDTO
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public TipoUsuario TipoUsuario { get; set; }
        public string? Matricula { get; set; }
    }
}
