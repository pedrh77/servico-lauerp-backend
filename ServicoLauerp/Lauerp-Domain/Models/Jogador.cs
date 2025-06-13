namespace Lauerp_Domain.Models;

public class Jogador : EntityBase
{
    public int Id { get; set; }
    string Nome { get; set; }
    string CPF { get; set; }
    DateTime DataNascimento { get; set; }
    string Telefone { get; set; }
    string Email { get; set; }

}
