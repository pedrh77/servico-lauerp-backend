namespace Lauerp_Domain.Models;

public class EntityBase
{
    public DateTime Criado_em { get; set; }
    public DateTime Modificado_em { get; set; }
    public bool Deleted { get; set; } = false;


    public void AdicionaDadosBase()
    {
        Criado_em = DateTime.UtcNow;
        Modificado_em = DateTime.UtcNow;
        Deleted = false;
    }

}
