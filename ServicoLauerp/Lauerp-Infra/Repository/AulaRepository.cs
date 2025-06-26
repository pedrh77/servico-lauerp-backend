using Lauerp_Domain.Interfaces;
using Lauerp_Infra.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lauerp_Infra.Repository
{
    public class AulaRepository(LauerpPostgreDbContext _dbcontext) : IAulaRepository
    {
    }
}
