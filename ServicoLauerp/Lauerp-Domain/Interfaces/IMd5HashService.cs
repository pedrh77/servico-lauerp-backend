using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lauerp_Domain.Interfaces
{
    public interface IMd5HashService
    {
        Task<string> GerarHashMd5(string senha);
    }
}
