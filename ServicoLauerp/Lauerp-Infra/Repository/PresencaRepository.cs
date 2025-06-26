using Lauerp_Domain.Interfaces;
using Lauerp_Infra.Database;

namespace Lauerp_Infra.Repository
{
    public class PresencaRepository(LauerpPostgreDbContext _dbcontext) : IPresencaRepository
    {
    }
}
