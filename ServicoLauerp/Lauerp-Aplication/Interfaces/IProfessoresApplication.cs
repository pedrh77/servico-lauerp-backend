using Lauerp_Domain.DTOs.Professor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lauerp_Aplication.Interfaces
{
    public interface IProfessoresApplication
    {
        Task<int> AddProfessorAsync(NovoProfessorDTO request);
    }
}
