using Lauerp_Domain.Enum;

namespace Lauerp_Domain.Models
{
    public class Usuario : EntityBase
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string SenhaHash { get; set; }
        public TipoUsuario  Role { get; set; }
        public string? Matricula { get; set; }
    }
}
