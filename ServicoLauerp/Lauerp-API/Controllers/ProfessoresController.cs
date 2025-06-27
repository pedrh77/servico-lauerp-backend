using Lauerp_Domain.DTOs.Professor;
using Lauerp_Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Lauerp_API.Controllers;

[ApiController]
[Route("[controller]")]
[Produces("application/json")]
public class ProfessoresController(IProfessorService _professorServices) : ControllerBase
{

    [HttpPost]
    public async Task<IActionResult> AdicionaNovoProfessorAsync([FromBody] NovoProfessorDTO request)
    {
        try
        {
            await _professorServices.AddProfessorAsync(request);
            return Created();
        }
        catch (Exception ex)
        {

            throw new Exception("");
        }
    }

    [HttpGet]
    public IActionResult ListaProfessoresAsync()
    {
        throw new NotImplementedException();
    }

    [HttpGet]
    public IActionResult ListaProfessoresByIdAsync(int Id)
    {
        throw new NotImplementedException();
    }
}
