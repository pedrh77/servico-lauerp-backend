using Lauerp_Aplication.Interfaces;
using Lauerp_Domain.DTOs.Professor;
using Microsoft.AspNetCore.Mvc;

namespace Lauerp_API.Controllers;

[ApiController]
[Route("[controller]")]
[Produces("application/json")]
public class ProfessoresController(IProfessoresApplication _professorApplication) : ControllerBase
{

    [HttpPost]
    public async Task<IActionResult> AdicionaNovoProfessorAsync([FromBody] NovoProfessorDTO request)
    {
        try
        {
            await _professorApplication.AddProfessorAsync(request);
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
